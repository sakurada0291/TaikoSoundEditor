﻿using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TaikoSoundEditor
{
    internal class GZ
    {

        public static string DecompressBytes(byte[] bytes)
        {
            Logger.Info("GZ Decompressing bytes");
            using MemoryStream ms = new MemoryStream(bytes);
            using GZipStream decompressionStream = new GZipStream(ms, CompressionMode.Decompress);
            using StreamReader reader = new StreamReader(decompressionStream);
            return reader.ReadToEnd();
        }

        public static string DecompressString(string gzPath)
        {
            Logger.Info("GZ Decompressing string");

            using FileStream originalFileStream = File.OpenRead(gzPath);
            using GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress);
            using StreamReader reader = new StreamReader(decompressionStream);
            return reader.ReadToEnd();
        }

        public static byte[] DecompressBytes(string gzPath)
        {
            Logger.Info("GZ Decompressing bytes");

            using FileStream originalFileStream = File.OpenRead(gzPath);
            using GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress);
            using MemoryStream ms = new MemoryStream();
            decompressionStream.CopyTo(ms);
            return ms.ToArray();
        }

        public static byte[] CompressToBytes(string content)
        {
            Logger.Info("GZ Compressing bytes");

            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(content);
            using var ostream = new MemoryStream();
            using (var compressionStream = new GZipStream(ostream, CompressionMode.Compress)) 
            {
                stream.CopyTo(compressionStream);
            }

            return ostream.ToArray();
        }

        public static string CompressToFile(string fileName, string content)
        {
            Logger.Info("GZ Compressing file");

            var uncompressed = Encoding.UTF8.GetBytes(content);

            using (MemoryStream outStream = new MemoryStream()) 
            {
                using (GZipOutputStream gzoStream = new GZipOutputStream(outStream))
                {
                    gzoStream.SetLevel(5);
                    gzoStream.Write(uncompressed, 0, uncompressed.Length);
                }
                File.WriteAllBytes(fileName, outStream.ToArray());
            }

            return "";

            var tmp = "~ztmp";
            if (!Directory.Exists(tmp))
                Directory.CreateDirectory(tmp);

            var fn = Path.GetFileNameWithoutExtension(fileName);
            fn = Path.Combine(tmp, fn);
            File.WriteAllText(fn, content);

            fileName = Path.GetFullPath(fileName);            
            

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(@"Tools\7z\7za.exe");
            p.StartInfo.ArgumentList.Add("a");
            p.StartInfo.ArgumentList.Add("-tgzip");
            p.StartInfo.ArgumentList.Add(fileName);
            p.StartInfo.ArgumentList.Add(Path.GetFullPath(fn));
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;

            foreach (var a in p.StartInfo.ArgumentList)
                Debug.WriteLine(a);

            p.Start();
            p.WaitForExit();
            int exitCode = p.ExitCode;
            string stderr = p.StandardError.ReadToEnd();
            string stdout = p.StandardError.ReadToEnd();

            if (exitCode != 0)
                throw new Exception($"Process 7za failed with exit code {exitCode}:\n" + stderr);

            return stdout;
        }
    }
}
