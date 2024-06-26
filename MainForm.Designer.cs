﻿using System.Windows.Forms;
using TaikoSoundEditor.Commons.Controls;

namespace TaikoSoundEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DatatableDef = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.UseEncryptionBox = new System.Windows.Forms.CheckBox();
            this.FumenKeyBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.DatatableKeyBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DirSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WordListPathSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.MusicInfoPathSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.MusicOrderPathSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.MusicAttributePathSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musicOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundViewTab = new System.Windows.Forms.TabControl();
            this.SoundViewerSimple = new System.Windows.Forms.TabPage();
            this.LocateInMusicOrderButton = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SimpleStarUraBox = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.SimpleStarManiaBox = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.SimpleStarHardBox = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.SimpleStarNormalBox = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.SimpleStarEasyBox = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.SimpleIdBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SimpleGenreBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SimpleDetailBox = new System.Windows.Forms.TextBox();
            this.SimpleSubtitleBox = new System.Windows.Forms.TextBox();
            this.SimpleTitleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SoundViewerExpert = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EditorTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.MusicAttributesGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.MusicOrderGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MusicInfoGrid = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WordDetailGB = new System.Windows.Forms.GroupBox();
            this.WordDetailGrid = new System.Windows.Forms.PropertyGrid();
            this.WordSubGB = new System.Windows.Forms.GroupBox();
            this.WordSubGrid = new System.Windows.Forms.PropertyGrid();
            this.WordsGB = new System.Windows.Forms.GroupBox();
            this.WordsGrid = new System.Windows.Forms.PropertyGrid();
            this.MusicOrderTab = new System.Windows.Forms.TabPage();
            this.MusicOrderViewer = new TaikoSoundEditor.Commons.Controls.MusicOrderViewer();
            this.RemoveSongButton = new System.Windows.Forms.Button();
            this.DatatableSpaces = new System.Windows.Forms.CheckBox();
            this.ExportOpenOnFinished = new System.Windows.Forms.CheckBox();
            this.ExportAllButton = new System.Windows.Forms.Button();
            this.ExportSoundBanksButton = new System.Windows.Forms.Button();
            this.ExportSoundFoldersButton = new System.Windows.Forms.Button();
            this.ExportDatatableButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.NewSoundsBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadedMusicBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SilenceBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.TjaEncShiftJIS = new System.Windows.Forms.RadioButton();
            this.TjaEncUTF8 = new System.Windows.Forms.RadioButton();
            this.TjaEncAuto = new System.Windows.Forms.RadioButton();
            this.AddSilenceBox = new System.Windows.Forms.CheckBox();
            this.FeedbackBox = new System.Windows.Forms.TextBox();
            this.CreateBackButton = new System.Windows.Forms.Button();
            this.CreateOkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SongNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TJASelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.AudioFileSelector = new TaikoSoundEditor.Commons.Controls.PathSelector();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SoundViewTab.SuspendLayout();
            this.SoundViewerSimple.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarUraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarManiaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarHardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarNormalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarEasyBox)).BeginInit();
            this.SoundViewerExpert.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.EditorTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.WordDetailGB.SuspendLayout();
            this.WordSubGB.SuspendLayout();
            this.WordsGB.SuspendLayout();
            this.MusicOrderTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilenceBox)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(984, 561);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox13);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(85, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 537);
            this.panel1.TabIndex = 1;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.DatatableDef);
            this.groupBox13.Location = new System.Drawing.Point(3, 277);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(780, 75);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Config";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Datatable def";
            // 
            // DatatableDef
            // 
            this.DatatableDef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatatableDef.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            this.DatatableDef.Location = new System.Drawing.Point(83, 19);
            this.DatatableDef.Name = "DatatableDef";
            this.DatatableDef.Path = "";
            this.DatatableDef.SelectsFolder = false;
            this.DatatableDef.Size = new System.Drawing.Size(691, 20);
            this.DatatableDef.TabIndex = 13;
            this.DatatableDef.PathChanged += new TaikoSoundEditor.Commons.Controls.PathSelector.OnPathChanged(this.DatatableDef_PathChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.UseEncryptionBox);
            this.groupBox12.Controls.Add(this.FumenKeyBox);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.DatatableKeyBox);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Location = new System.Drawing.Point(3, 177);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(780, 94);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "AES keys";
            // 
            // UseEncryptionBox
            // 
            this.UseEncryptionBox.AutoSize = true;
            this.UseEncryptionBox.Location = new System.Drawing.Point(58, 72);
            this.UseEncryptionBox.Name = "UseEncryptionBox";
            this.UseEncryptionBox.Size = new System.Drawing.Size(98, 17);
            this.UseEncryptionBox.TabIndex = 14;
            this.UseEncryptionBox.Text = "Use Encryption";
            this.UseEncryptionBox.UseVisualStyleBackColor = true;
            this.UseEncryptionBox.CheckedChanged += new System.EventHandler(this.UseEncryptionBox_CheckedChanged);
            // 
            // FumenKeyBox
            // 
            this.FumenKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FumenKeyBox.Location = new System.Drawing.Point(58, 45);
            this.FumenKeyBox.Name = "FumenKeyBox";
            this.FumenKeyBox.Size = new System.Drawing.Size(716, 20);
            this.FumenKeyBox.TabIndex = 13;
            this.FumenKeyBox.TextChanged += new System.EventHandler(this.FumenKeyBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Fumen";
            // 
            // DatatableKeyBox
            // 
            this.DatatableKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatatableKeyBox.Location = new System.Drawing.Point(58, 20);
            this.DatatableKeyBox.Name = "DatatableKeyBox";
            this.DatatableKeyBox.Size = new System.Drawing.Size(716, 20);
            this.DatatableKeyBox.TabIndex = 11;
            this.DatatableKeyBox.TextChanged += new System.EventHandler(this.DatatableKeyBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Datatable";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(690, 508);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 26);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "Looks good";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DirSelector);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Or specify the game diretory (/datatable)";
            // 
            // DirSelector
            // 
            this.DirSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirSelector.Filter = "All files(*.*)|*.*";
            this.DirSelector.Location = new System.Drawing.Point(58, 19);
            this.DirSelector.Name = "DirSelector";
            this.DirSelector.Path = "";
            this.DirSelector.SelectsFolder = true;
            this.DirSelector.Size = new System.Drawing.Size(716, 20);
            this.DirSelector.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Directory";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.WordListPathSelector);
            this.groupBox1.Controls.Add(this.MusicInfoPathSelector);
            this.groupBox1.Controls.Add(this.MusicOrderPathSelector);
            this.groupBox1.Controls.Add(this.MusicAttributePathSelector);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select individual files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "wordlist.bin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "musicinfo.bin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "music_order.bin";
            // 
            // WordListPathSelector
            // 
            this.WordListPathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WordListPathSelector.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            this.WordListPathSelector.Location = new System.Drawing.Point(101, 88);
            this.WordListPathSelector.Name = "WordListPathSelector";
            this.WordListPathSelector.Path = "";
            this.WordListPathSelector.SelectsFolder = false;
            this.WordListPathSelector.Size = new System.Drawing.Size(673, 20);
            this.WordListPathSelector.TabIndex = 12;
            // 
            // MusicInfoPathSelector
            // 
            this.MusicInfoPathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicInfoPathSelector.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            this.MusicInfoPathSelector.Location = new System.Drawing.Point(101, 63);
            this.MusicInfoPathSelector.Name = "MusicInfoPathSelector";
            this.MusicInfoPathSelector.Path = "";
            this.MusicInfoPathSelector.SelectsFolder = false;
            this.MusicInfoPathSelector.Size = new System.Drawing.Size(673, 20);
            this.MusicInfoPathSelector.TabIndex = 11;
            // 
            // MusicOrderPathSelector
            // 
            this.MusicOrderPathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicOrderPathSelector.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            this.MusicOrderPathSelector.Location = new System.Drawing.Point(101, 38);
            this.MusicOrderPathSelector.Name = "MusicOrderPathSelector";
            this.MusicOrderPathSelector.Path = "";
            this.MusicOrderPathSelector.SelectsFolder = false;
            this.MusicOrderPathSelector.Size = new System.Drawing.Size(673, 20);
            this.MusicOrderPathSelector.TabIndex = 10;
            // 
            // MusicAttributePathSelector
            // 
            this.MusicAttributePathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicAttributePathSelector.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            this.MusicAttributePathSelector.Location = new System.Drawing.Point(101, 13);
            this.MusicAttributePathSelector.Name = "MusicAttributePathSelector";
            this.MusicAttributePathSelector.Path = "";
            this.MusicAttributePathSelector.SelectsFolder = false;
            this.MusicAttributePathSelector.Size = new System.Drawing.Size(673, 20);
            this.MusicAttributePathSelector.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "music_atribute.bin";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Controls.Add(this.SoundViewTab);
            this.tabPage2.Controls.Add(this.RemoveSongButton);
            this.tabPage2.Controls.Add(this.DatatableSpaces);
            this.tabPage2.Controls.Add(this.ExportOpenOnFinished);
            this.tabPage2.Controls.Add(this.ExportAllButton);
            this.tabPage2.Controls.Add(this.ExportSoundBanksButton);
            this.tabPage2.Controls.Add(this.ExportSoundFoldersButton);
            this.tabPage2.Controls.Add(this.ExportDatatableButton);
            this.tabPage2.Controls.Add(this.CreateButton);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.preferencesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicOrderToolStripMenuItem});
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem1.Text = "Preferences";
            // 
            // musicOrderToolStripMenuItem
            // 
            this.musicOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByTitleToolStripMenuItem,
            this.SortByGenreToolStripMenuItem,
            this.SortByIdToolStripMenuItem,
            this.noSortToolStripMenuItem});
            this.musicOrderToolStripMenuItem.Name = "musicOrderToolStripMenuItem";
            this.musicOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musicOrderToolStripMenuItem.Text = "Music order";
            // 
            // sortByTitleToolStripMenuItem
            // 
            this.sortByTitleToolStripMenuItem.Name = "sortByTitleToolStripMenuItem";
            this.sortByTitleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByTitleToolStripMenuItem.Text = "Sort by title";
            this.sortByTitleToolStripMenuItem.Click += new System.EventHandler(this.MusicOrderSortToolStripMenuItem_Click);
            // 
            // SortByGenreToolStripMenuItem
            // 
            this.SortByGenreToolStripMenuItem.CheckOnClick = true;
            this.SortByGenreToolStripMenuItem.Name = "SortByGenreToolStripMenuItem";
            this.SortByGenreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByGenreToolStripMenuItem.Text = "Sort by genre";
            this.SortByGenreToolStripMenuItem.Click += new System.EventHandler(this.MusicOrderSortToolStripMenuItem_Click);
            // 
            // SortByIdToolStripMenuItem
            // 
            this.SortByIdToolStripMenuItem.CheckOnClick = true;
            this.SortByIdToolStripMenuItem.Name = "SortByIdToolStripMenuItem";
            this.SortByIdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByIdToolStripMenuItem.Text = "Sort by Id";
            this.SortByIdToolStripMenuItem.Click += new System.EventHandler(this.MusicOrderSortToolStripMenuItem_Click);
            // 
            // noSortToolStripMenuItem
            // 
            this.noSortToolStripMenuItem.Name = "noSortToolStripMenuItem";
            this.noSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noSortToolStripMenuItem.Text = "No Sort";
            this.noSortToolStripMenuItem.Click += new System.EventHandler(this.MusicOrderSortToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Visible = false;
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // SoundViewTab
            // 
            this.SoundViewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundViewTab.Controls.Add(this.SoundViewerSimple);
            this.SoundViewTab.Controls.Add(this.SoundViewerExpert);
            this.SoundViewTab.Controls.Add(this.MusicOrderTab);
            this.SoundViewTab.Location = new System.Drawing.Point(119, 30);
            this.SoundViewTab.Name = "SoundViewTab";
            this.SoundViewTab.SelectedIndex = 0;
            this.SoundViewTab.Size = new System.Drawing.Size(849, 408);
            this.SoundViewTab.TabIndex = 13;
            this.SoundViewTab.SelectedIndexChanged += new System.EventHandler(this.SoundViewTab_SelectedIndexChanged);
            // 
            // SoundViewerSimple
            // 
            this.SoundViewerSimple.Controls.Add(this.LocateInMusicOrderButton);
            this.SoundViewerSimple.Controls.Add(this.groupBox11);
            this.SoundViewerSimple.Controls.Add(this.label14);
            this.SoundViewerSimple.Controls.Add(this.SimpleIdBox);
            this.SoundViewerSimple.Controls.Add(this.label13);
            this.SoundViewerSimple.Controls.Add(this.SimpleGenreBox);
            this.SoundViewerSimple.Controls.Add(this.label12);
            this.SoundViewerSimple.Controls.Add(this.label11);
            this.SoundViewerSimple.Controls.Add(this.SimpleDetailBox);
            this.SoundViewerSimple.Controls.Add(this.SimpleSubtitleBox);
            this.SoundViewerSimple.Controls.Add(this.SimpleTitleBox);
            this.SoundViewerSimple.Controls.Add(this.label4);
            this.SoundViewerSimple.Location = new System.Drawing.Point(4, 22);
            this.SoundViewerSimple.Name = "SoundViewerSimple";
            this.SoundViewerSimple.Padding = new System.Windows.Forms.Padding(3);
            this.SoundViewerSimple.Size = new System.Drawing.Size(841, 382);
            this.SoundViewerSimple.TabIndex = 1;
            this.SoundViewerSimple.Text = "Simple View";
            this.SoundViewerSimple.UseVisualStyleBackColor = true;
            // 
            // LocateInMusicOrderButton
            // 
            this.LocateInMusicOrderButton.Location = new System.Drawing.Point(628, 108);
            this.LocateInMusicOrderButton.Name = "LocateInMusicOrderButton";
            this.LocateInMusicOrderButton.Size = new System.Drawing.Size(132, 20);
            this.LocateInMusicOrderButton.TabIndex = 11;
            this.LocateInMusicOrderButton.Text = "Locate in Music Order";
            this.LocateInMusicOrderButton.UseVisualStyleBackColor = true;
            this.LocateInMusicOrderButton.Click += new System.EventHandler(this.LocateInMusicOrderButton_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.SimpleStarUraBox);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.SimpleStarManiaBox);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.SimpleStarHardBox);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.SimpleStarNormalBox);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.SimpleStarEasyBox);
            this.groupBox11.Location = new System.Drawing.Point(628, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(208, 97);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Stars";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Ura";
            // 
            // SimpleStarUraBox
            // 
            this.SimpleStarUraBox.Location = new System.Drawing.Point(36, 69);
            this.SimpleStarUraBox.Name = "SimpleStarUraBox";
            this.SimpleStarUraBox.Size = new System.Drawing.Size(55, 20);
            this.SimpleStarUraBox.TabIndex = 8;
            this.SimpleStarUraBox.ValueChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(96, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Mania";
            // 
            // SimpleStarManiaBox
            // 
            this.SimpleStarManiaBox.Location = new System.Drawing.Point(141, 44);
            this.SimpleStarManiaBox.Name = "SimpleStarManiaBox";
            this.SimpleStarManiaBox.Size = new System.Drawing.Size(55, 20);
            this.SimpleStarManiaBox.TabIndex = 6;
            this.SimpleStarManiaBox.ValueChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Hard";
            // 
            // SimpleStarHardBox
            // 
            this.SimpleStarHardBox.Location = new System.Drawing.Point(36, 44);
            this.SimpleStarHardBox.Name = "SimpleStarHardBox";
            this.SimpleStarHardBox.Size = new System.Drawing.Size(55, 20);
            this.SimpleStarHardBox.TabIndex = 4;
            this.SimpleStarHardBox.ValueChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(96, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Normal";
            // 
            // SimpleStarNormalBox
            // 
            this.SimpleStarNormalBox.Location = new System.Drawing.Point(141, 19);
            this.SimpleStarNormalBox.Name = "SimpleStarNormalBox";
            this.SimpleStarNormalBox.Size = new System.Drawing.Size(55, 20);
            this.SimpleStarNormalBox.TabIndex = 2;
            this.SimpleStarNormalBox.ValueChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Easy";
            // 
            // SimpleStarEasyBox
            // 
            this.SimpleStarEasyBox.Location = new System.Drawing.Point(36, 19);
            this.SimpleStarEasyBox.Name = "SimpleStarEasyBox";
            this.SimpleStarEasyBox.Size = new System.Drawing.Size(55, 20);
            this.SimpleStarEasyBox.TabIndex = 0;
            this.SimpleStarEasyBox.ValueChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Id";
            // 
            // SimpleIdBox
            // 
            this.SimpleIdBox.Location = new System.Drawing.Point(66, 5);
            this.SimpleIdBox.Name = "SimpleIdBox";
            this.SimpleIdBox.ReadOnly = true;
            this.SimpleIdBox.Size = new System.Drawing.Size(556, 20);
            this.SimpleIdBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Genre";
            // 
            // SimpleGenreBox
            // 
            this.SimpleGenreBox.FormattingEnabled = true;
            this.SimpleGenreBox.Location = new System.Drawing.Point(66, 106);
            this.SimpleGenreBox.Name = "SimpleGenreBox";
            this.SimpleGenreBox.Size = new System.Drawing.Size(556, 21);
            this.SimpleGenreBox.TabIndex = 6;
            this.SimpleGenreBox.SelectedIndexChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Detail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Subtitle";
            // 
            // SimpleDetailBox
            // 
            this.SimpleDetailBox.Location = new System.Drawing.Point(66, 81);
            this.SimpleDetailBox.Name = "SimpleDetailBox";
            this.SimpleDetailBox.Size = new System.Drawing.Size(556, 20);
            this.SimpleDetailBox.TabIndex = 3;
            this.SimpleDetailBox.TextChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // SimpleSubtitleBox
            // 
            this.SimpleSubtitleBox.Location = new System.Drawing.Point(66, 55);
            this.SimpleSubtitleBox.Name = "SimpleSubtitleBox";
            this.SimpleSubtitleBox.Size = new System.Drawing.Size(556, 20);
            this.SimpleSubtitleBox.TabIndex = 2;
            this.SimpleSubtitleBox.TextChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // SimpleTitleBox
            // 
            this.SimpleTitleBox.Location = new System.Drawing.Point(66, 30);
            this.SimpleTitleBox.Name = "SimpleTitleBox";
            this.SimpleTitleBox.Size = new System.Drawing.Size(556, 20);
            this.SimpleTitleBox.TabIndex = 1;
            this.SimpleTitleBox.TextChanged += new System.EventHandler(this.SimpleBoxChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title";
            // 
            // SoundViewerExpert
            // 
            this.SoundViewerExpert.Controls.Add(this.groupBox4);
            this.SoundViewerExpert.Location = new System.Drawing.Point(4, 22);
            this.SoundViewerExpert.Name = "SoundViewerExpert";
            this.SoundViewerExpert.Padding = new System.Windows.Forms.Padding(3);
            this.SoundViewerExpert.Size = new System.Drawing.Size(841, 382);
            this.SoundViewerExpert.TabIndex = 0;
            this.SoundViewerExpert.Text = "Expert View";
            this.SoundViewerExpert.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EditorTable);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(835, 376);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sound Data";
            // 
            // EditorTable
            // 
            this.EditorTable.ColumnCount = 3;
            this.EditorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.EditorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.EditorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.EditorTable.Controls.Add(this.panel3, 1, 0);
            this.EditorTable.Controls.Add(this.groupBox5, 0, 0);
            this.EditorTable.Controls.Add(this.panel2, 2, 0);
            this.EditorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTable.Location = new System.Drawing.Point(3, 16);
            this.EditorTable.Name = "EditorTable";
            this.EditorTable.RowCount = 1;
            this.EditorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorTable.Size = new System.Drawing.Size(829, 357);
            this.EditorTable.TabIndex = 7;
            this.EditorTable.Resize += new System.EventHandler(this.EditorTable_Resize);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(276, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 351);
            this.panel3.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.MusicAttributesGrid);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 223);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Music Attributes";
            // 
            // MusicAttributesGrid
            // 
            this.MusicAttributesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicAttributesGrid.HelpVisible = false;
            this.MusicAttributesGrid.Location = new System.Drawing.Point(3, 16);
            this.MusicAttributesGrid.Name = "MusicAttributesGrid";
            this.MusicAttributesGrid.Size = new System.Drawing.Size(269, 204);
            this.MusicAttributesGrid.TabIndex = 3;
            this.MusicAttributesGrid.ToolbarVisible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.MusicOrderGrid);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(0, 223);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(275, 128);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Music Order";
            // 
            // MusicOrderGrid
            // 
            this.MusicOrderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicOrderGrid.HelpVisible = false;
            this.MusicOrderGrid.Location = new System.Drawing.Point(3, 16);
            this.MusicOrderGrid.Name = "MusicOrderGrid";
            this.MusicOrderGrid.Size = new System.Drawing.Size(269, 109);
            this.MusicOrderGrid.TabIndex = 3;
            this.MusicOrderGrid.ToolbarVisible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MusicInfoGrid);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 351);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Music Info";
            // 
            // MusicInfoGrid
            // 
            this.MusicInfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicInfoGrid.HelpVisible = false;
            this.MusicInfoGrid.Location = new System.Drawing.Point(3, 16);
            this.MusicInfoGrid.Name = "MusicInfoGrid";
            this.MusicInfoGrid.Size = new System.Drawing.Size(261, 332);
            this.MusicInfoGrid.TabIndex = 3;
            this.MusicInfoGrid.ToolbarVisible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WordDetailGB);
            this.panel2.Controls.Add(this.WordSubGB);
            this.panel2.Controls.Add(this.WordsGB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(557, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 351);
            this.panel2.TabIndex = 6;
            // 
            // WordDetailGB
            // 
            this.WordDetailGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WordDetailGB.Controls.Add(this.WordDetailGrid);
            this.WordDetailGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordDetailGB.Location = new System.Drawing.Point(0, 239);
            this.WordDetailGB.Name = "WordDetailGB";
            this.WordDetailGB.Size = new System.Drawing.Size(269, 112);
            this.WordDetailGB.TabIndex = 8;
            this.WordDetailGB.TabStop = false;
            this.WordDetailGB.Text = "Word Detail";
            // 
            // WordDetailGrid
            // 
            this.WordDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordDetailGrid.HelpVisible = false;
            this.WordDetailGrid.Location = new System.Drawing.Point(3, 16);
            this.WordDetailGrid.Name = "WordDetailGrid";
            this.WordDetailGrid.Size = new System.Drawing.Size(263, 93);
            this.WordDetailGrid.TabIndex = 3;
            this.WordDetailGrid.ToolbarVisible = false;
            // 
            // WordSubGB
            // 
            this.WordSubGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WordSubGB.Controls.Add(this.WordSubGrid);
            this.WordSubGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordSubGB.Location = new System.Drawing.Point(0, 122);
            this.WordSubGB.Name = "WordSubGB";
            this.WordSubGB.Size = new System.Drawing.Size(269, 117);
            this.WordSubGB.TabIndex = 7;
            this.WordSubGB.TabStop = false;
            this.WordSubGB.Text = "Word Sub";
            // 
            // WordSubGrid
            // 
            this.WordSubGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordSubGrid.HelpVisible = false;
            this.WordSubGrid.Location = new System.Drawing.Point(3, 16);
            this.WordSubGrid.Name = "WordSubGrid";
            this.WordSubGrid.Size = new System.Drawing.Size(263, 98);
            this.WordSubGrid.TabIndex = 3;
            this.WordSubGrid.ToolbarVisible = false;
            // 
            // WordsGB
            // 
            this.WordsGB.Controls.Add(this.WordsGrid);
            this.WordsGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordsGB.Location = new System.Drawing.Point(0, 0);
            this.WordsGB.Name = "WordsGB";
            this.WordsGB.Size = new System.Drawing.Size(269, 122);
            this.WordsGB.TabIndex = 6;
            this.WordsGB.TabStop = false;
            this.WordsGB.Text = "Words";
            // 
            // WordsGrid
            // 
            this.WordsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordsGrid.HelpVisible = false;
            this.WordsGrid.Location = new System.Drawing.Point(3, 16);
            this.WordsGrid.Name = "WordsGrid";
            this.WordsGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.WordsGrid.Size = new System.Drawing.Size(263, 103);
            this.WordsGrid.TabIndex = 3;
            this.WordsGrid.ToolbarVisible = false;
            // 
            // MusicOrderTab
            // 
            this.MusicOrderTab.Controls.Add(this.MusicOrderViewer);
            this.MusicOrderTab.Location = new System.Drawing.Point(4, 22);
            this.MusicOrderTab.Name = "MusicOrderTab";
            this.MusicOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.MusicOrderTab.Size = new System.Drawing.Size(841, 382);
            this.MusicOrderTab.TabIndex = 2;
            this.MusicOrderTab.Text = "Music Order";
            this.MusicOrderTab.UseVisualStyleBackColor = true;
            // 
            // MusicOrderViewer
            // 
            this.MusicOrderViewer.CurrentPage = 0;
            this.MusicOrderViewer.CutActive = false;
            this.MusicOrderViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicOrderViewer.ItemsPerCol = 5;
            this.MusicOrderViewer.ItemsPerRow = 4;
            this.MusicOrderViewer.Location = new System.Drawing.Point(3, 3);
            this.MusicOrderViewer.Name = "MusicOrderViewer";
            this.MusicOrderViewer.PasteActive = false;
            this.MusicOrderViewer.PasteMode = false;
            this.MusicOrderViewer.RemoveActive = false;
            this.MusicOrderViewer.Size = new System.Drawing.Size(835, 376);
            this.MusicOrderViewer.TabIndex = 0;
            this.MusicOrderViewer.SongRemoved += new TaikoSoundEditor.Commons.Controls.MusicOrderViewer.OnSongRemoved(this.MusicOrderViewer_SongRemoved);
            this.MusicOrderViewer.SongDoubleClick += new TaikoSoundEditor.Commons.Controls.MusicOrderViewer.OnSongDoubleClick(this.MusicOrderViewer_SongDoubleClick);
            // 
            // RemoveSongButton
            // 
            this.RemoveSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveSongButton.Location = new System.Drawing.Point(193, 447);
            this.RemoveSongButton.Name = "RemoveSongButton";
            this.RemoveSongButton.Size = new System.Drawing.Size(64, 20);
            this.RemoveSongButton.TabIndex = 12;
            this.RemoveSongButton.Text = "Remove";
            this.RemoveSongButton.UseVisualStyleBackColor = true;
            this.RemoveSongButton.Click += new System.EventHandler(this.RemoveSongButton_Click);
            // 
            // DatatableSpaces
            // 
            this.DatatableSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DatatableSpaces.AutoSize = true;
            this.DatatableSpaces.Location = new System.Drawing.Point(123, 472);
            this.DatatableSpaces.Name = "DatatableSpaces";
            this.DatatableSpaces.Size = new System.Drawing.Size(276, 17);
            this.DatatableSpaces.TabIndex = 11;
            this.DatatableSpaces.Text = "Remove spaces in datatable files (musicinfo, wordlist)";
            this.DatatableSpaces.UseVisualStyleBackColor = true;
            // 
            // ExportOpenOnFinished
            // 
            this.ExportOpenOnFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportOpenOnFinished.AutoSize = true;
            this.ExportOpenOnFinished.Checked = true;
            this.ExportOpenOnFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportOpenOnFinished.Location = new System.Drawing.Point(123, 492);
            this.ExportOpenOnFinished.Name = "ExportOpenOnFinished";
            this.ExportOpenOnFinished.Size = new System.Drawing.Size(181, 17);
            this.ExportOpenOnFinished.TabIndex = 10;
            this.ExportOpenOnFinished.Text = "Open folder when export finished";
            this.ExportOpenOnFinished.UseVisualStyleBackColor = true;
            // 
            // ExportAllButton
            // 
            this.ExportAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAllButton.Location = new System.Drawing.Point(842, 519);
            this.ExportAllButton.Name = "ExportAllButton";
            this.ExportAllButton.Size = new System.Drawing.Size(122, 20);
            this.ExportAllButton.TabIndex = 9;
            this.ExportAllButton.Text = "Export All";
            this.ExportAllButton.UseVisualStyleBackColor = true;
            this.ExportAllButton.Click += new System.EventHandler(this.ExportAllButton_Click);
            // 
            // ExportSoundBanksButton
            // 
            this.ExportSoundBanksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSoundBanksButton.Location = new System.Drawing.Point(842, 494);
            this.ExportSoundBanksButton.Name = "ExportSoundBanksButton";
            this.ExportSoundBanksButton.Size = new System.Drawing.Size(122, 20);
            this.ExportSoundBanksButton.TabIndex = 8;
            this.ExportSoundBanksButton.Text = "Export Sound Banks";
            this.ExportSoundBanksButton.UseVisualStyleBackColor = true;
            this.ExportSoundBanksButton.Click += new System.EventHandler(this.ExportSoundBanksButton_Click);
            // 
            // ExportSoundFoldersButton
            // 
            this.ExportSoundFoldersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSoundFoldersButton.Location = new System.Drawing.Point(842, 469);
            this.ExportSoundFoldersButton.Name = "ExportSoundFoldersButton";
            this.ExportSoundFoldersButton.Size = new System.Drawing.Size(122, 20);
            this.ExportSoundFoldersButton.TabIndex = 7;
            this.ExportSoundFoldersButton.Text = "Export Sound Folders";
            this.ExportSoundFoldersButton.UseVisualStyleBackColor = true;
            this.ExportSoundFoldersButton.Click += new System.EventHandler(this.ExportSoundFoldersButton_Click);
            // 
            // ExportDatatableButton
            // 
            this.ExportDatatableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportDatatableButton.Location = new System.Drawing.Point(842, 444);
            this.ExportDatatableButton.Name = "ExportDatatableButton";
            this.ExportDatatableButton.Size = new System.Drawing.Size(122, 20);
            this.ExportDatatableButton.TabIndex = 6;
            this.ExportDatatableButton.Text = "Export Datatable";
            this.ExportDatatableButton.UseVisualStyleBackColor = true;
            this.ExportDatatableButton.Click += new System.EventHandler(this.ExportDatatableButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.Location = new System.Drawing.Point(123, 447);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(64, 20);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create...";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.NewSoundsBox);
            this.groupBox8.Location = new System.Drawing.Point(10, 310);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(107, 231);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "New Sounds List";
            // 
            // NewSoundsBox
            // 
            this.NewSoundsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewSoundsBox.FormattingEnabled = true;
            this.NewSoundsBox.Location = new System.Drawing.Point(3, 16);
            this.NewSoundsBox.Name = "NewSoundsBox";
            this.NewSoundsBox.Size = new System.Drawing.Size(101, 212);
            this.NewSoundsBox.TabIndex = 1;
            this.NewSoundsBox.SelectedIndexChanged += new System.EventHandler(this.NewSoundsBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchBox);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.LoadedMusicBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sounds List";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(25, 17);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(78, 20);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaikoSoundEditor.Properties.Resources.ic_search;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoadedMusicBox
            // 
            this.LoadedMusicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadedMusicBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LoadedMusicBox.FormattingEnabled = true;
            this.LoadedMusicBox.Location = new System.Drawing.Point(3, 42);
            this.LoadedMusicBox.Name = "LoadedMusicBox";
            this.LoadedMusicBox.Size = new System.Drawing.Size(103, 225);
            this.LoadedMusicBox.TabIndex = 1;
            this.LoadedMusicBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LoadedMusicBox_DrawItem);
            this.LoadedMusicBox.SelectedIndexChanged += new System.EventHandler(this.LoadedMusicBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.SilenceBox);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Controls.Add(this.AddSilenceBox);
            this.groupBox10.Controls.Add(this.FeedbackBox);
            this.groupBox10.Controls.Add(this.CreateBackButton);
            this.groupBox10.Controls.Add(this.CreateOkButton);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.SongNameBox);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.TJASelector);
            this.groupBox10.Controls.Add(this.AudioFileSelector);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Location = new System.Drawing.Point(102, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(766, 537);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Create new sound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "seconds";
            // 
            // SilenceBox
            // 
            this.SilenceBox.Location = new System.Drawing.Point(117, 146);
            this.SilenceBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SilenceBox.Name = "SilenceBox";
            this.SilenceBox.Size = new System.Drawing.Size(36, 20);
            this.SilenceBox.TabIndex = 20;
            this.SilenceBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.TjaEncShiftJIS);
            this.groupBox9.Controls.Add(this.TjaEncUTF8);
            this.groupBox9.Controls.Add(this.TjaEncAuto);
            this.groupBox9.Location = new System.Drawing.Point(5, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(306, 33);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "TJAEncoding";
            // 
            // TjaEncShiftJIS
            // 
            this.TjaEncShiftJIS.AutoSize = true;
            this.TjaEncShiftJIS.Location = new System.Drawing.Point(109, 14);
            this.TjaEncShiftJIS.Name = "TjaEncShiftJIS";
            this.TjaEncShiftJIS.Size = new System.Drawing.Size(64, 17);
            this.TjaEncShiftJIS.TabIndex = 24;
            this.TjaEncShiftJIS.TabStop = true;
            this.TjaEncShiftJIS.Text = "Shift-JIS";
            this.TjaEncShiftJIS.UseVisualStyleBackColor = true;
            // 
            // TjaEncUTF8
            // 
            this.TjaEncUTF8.AutoSize = true;
            this.TjaEncUTF8.Location = new System.Drawing.Point(56, 14);
            this.TjaEncUTF8.Name = "TjaEncUTF8";
            this.TjaEncUTF8.Size = new System.Drawing.Size(55, 17);
            this.TjaEncUTF8.TabIndex = 23;
            this.TjaEncUTF8.TabStop = true;
            this.TjaEncUTF8.Text = "UTF-8";
            this.TjaEncUTF8.UseVisualStyleBackColor = true;
            // 
            // TjaEncAuto
            // 
            this.TjaEncAuto.AutoSize = true;
            this.TjaEncAuto.Checked = true;
            this.TjaEncAuto.Location = new System.Drawing.Point(7, 14);
            this.TjaEncAuto.Name = "TjaEncAuto";
            this.TjaEncAuto.Size = new System.Drawing.Size(47, 17);
            this.TjaEncAuto.TabIndex = 22;
            this.TjaEncAuto.TabStop = true;
            this.TjaEncAuto.Text = "Auto";
            this.TjaEncAuto.UseVisualStyleBackColor = true;
            // 
            // AddSilenceBox
            // 
            this.AddSilenceBox.AutoSize = true;
            this.AddSilenceBox.Checked = true;
            this.AddSilenceBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddSilenceBox.Location = new System.Drawing.Point(9, 147);
            this.AddSilenceBox.Name = "AddSilenceBox";
            this.AddSilenceBox.Size = new System.Drawing.Size(112, 17);
            this.AddSilenceBox.TabIndex = 19;
            this.AddSilenceBox.Text = "Delay before song";
            this.AddSilenceBox.UseVisualStyleBackColor = true;
            this.AddSilenceBox.CheckedChanged += new System.EventHandler(this.AddSilenceBox_CheckedChanged);
            // 
            // FeedbackBox
            // 
            this.FeedbackBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedbackBox.Enabled = false;
            this.FeedbackBox.Location = new System.Drawing.Point(21, 181);
            this.FeedbackBox.Multiline = true;
            this.FeedbackBox.Name = "FeedbackBox";
            this.FeedbackBox.Size = new System.Drawing.Size(724, 219);
            this.FeedbackBox.TabIndex = 18;
            // 
            // CreateBackButton
            // 
            this.CreateBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBackButton.Location = new System.Drawing.Point(628, 511);
            this.CreateBackButton.Name = "CreateBackButton";
            this.CreateBackButton.Size = new System.Drawing.Size(64, 20);
            this.CreateBackButton.TabIndex = 17;
            this.CreateBackButton.Text = "Back";
            this.CreateBackButton.UseVisualStyleBackColor = true;
            this.CreateBackButton.Click += new System.EventHandler(this.CreateBackButton_Click);
            // 
            // CreateOkButton
            // 
            this.CreateOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOkButton.Location = new System.Drawing.Point(697, 511);
            this.CreateOkButton.Name = "CreateOkButton";
            this.CreateOkButton.Size = new System.Drawing.Size(64, 20);
            this.CreateOkButton.TabIndex = 16;
            this.CreateOkButton.Text = "Ok";
            this.CreateOkButton.UseVisualStyleBackColor = true;
            this.CreateOkButton.Click += new System.EventHandler(this.CreateOkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Song name";
            // 
            // SongNameBox
            // 
            this.SongNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongNameBox.Location = new System.Drawing.Point(72, 113);
            this.SongNameBox.Name = "SongNameBox";
            this.SongNameBox.Size = new System.Drawing.Size(688, 20);
            this.SongNameBox.TabIndex = 14;
            this.SongNameBox.Text = "(6 characters id...)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "TJA file";
            // 
            // TJASelector
            // 
            this.TJASelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TJASelector.Filter = ".tja files(*.tja)|*.tja|All files(*.*)|*.*";
            this.TJASelector.Location = new System.Drawing.Point(72, 61);
            this.TJASelector.Name = "TJASelector";
            this.TJASelector.Path = "";
            this.TJASelector.SelectsFolder = false;
            this.TJASelector.Size = new System.Drawing.Size(688, 20);
            this.TJASelector.TabIndex = 10;
            this.TJASelector.PathChanged += new TaikoSoundEditor.Commons.Controls.PathSelector.OnPathChanged(this.TJASelector_PathChanged);
            // 
            // AudioFileSelector
            // 
            this.AudioFileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioFileSelector.Filter = "OGG files(*.ogg)|*.ogg|mp3 files(*.mp3)|*.mp3|WAV files(*.wav)|*.wav|All files(*." +
    "*)|*.*";
            this.AudioFileSelector.Location = new System.Drawing.Point(73, 89);
            this.AudioFileSelector.Name = "AudioFileSelector";
            this.AudioFileSelector.Path = "";
            this.AudioFileSelector.SelectsFolder = false;
            this.AudioFileSelector.Size = new System.Drawing.Size(688, 20);
            this.AudioFileSelector.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Audio file";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(129, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 276);
            this.panel4.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Taiko Sound Editor";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SoundViewTab.ResumeLayout(false);
            this.SoundViewerSimple.ResumeLayout(false);
            this.SoundViewerSimple.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarUraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarManiaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarHardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarNormalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleStarEasyBox)).EndInit();
            this.SoundViewerExpert.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.EditorTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.WordDetailGB.ResumeLayout(false);
            this.WordSubGB.ResumeLayout(false);
            this.WordsGB.ResumeLayout(false);
            this.MusicOrderTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilenceBox)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private PathSelector WordListPathSelector;
        private PathSelector MusicInfoPathSelector;
        private PathSelector MusicOrderPathSelector;
        private PathSelector MusicAttributePathSelector;
        private Label label8;
        private GroupBox groupBox2;
        private Button OkButton;
        private PathSelector DirSelector;
        private Label label1;
        private ListBox LoadedMusicBox;
        private GroupBox groupBox3;
        private PropertyGrid MusicInfoGrid;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private PropertyGrid MusicAttributesGrid;
        private GroupBox WordsGB;
        private PropertyGrid WordsGrid;
        private TableLayoutPanel EditorTable;
        private Panel panel2;
        private GroupBox WordDetailGB;
        private PropertyGrid WordDetailGrid;
        private GroupBox WordSubGB;
        private PropertyGrid WordSubGrid;
        private Panel panel3;
        private GroupBox groupBox7;
        private PropertyGrid MusicOrderGrid;
        private GroupBox groupBox8;
        private ListBox NewSoundsBox;
        private Button CreateButton;
        private TabPage tabPage3;
        private Panel panel4;
        private GroupBox groupBox10;
        private Label label9;
        private PathSelector TJASelector;
        private PathSelector AudioFileSelector;
        private Label label10;
        private TextBox SongNameBox;
        private Label label2;
        private Button CreateOkButton;
        private Button CreateBackButton;
        private TextBox FeedbackBox;
        private Button ExportAllButton;
        private Button ExportSoundBanksButton;
        private Button ExportSoundFoldersButton;
        private Button ExportDatatableButton;
        private CheckBox ExportOpenOnFinished;
        private CheckBox AddSilenceBox;
        private CheckBox DatatableSpaces;
        private Button RemoveSongButton;
        private GroupBox groupBox9;
        private RadioButton TjaEncShiftJIS;
        private RadioButton TjaEncUTF8;
        private RadioButton TjaEncAuto;
        private NumericUpDown SilenceBox;
        private Label label3;
        private TabControl SoundViewTab;
        private TabPage SoundViewerExpert;
        private TabPage SoundViewerSimple;
        private TextBox SimpleSubtitleBox;
        private TextBox SimpleTitleBox;
        private Label label4;
        private TextBox SimpleDetailBox;
        private Label label12;
        private Label label11;
        private ComboBox SimpleGenreBox;
        private Label label13;
        private Label label14;
        private TextBox SimpleIdBox;
        private TabPage MusicOrderTab;
        private GroupBox groupBox11;
        private Label label17;
        private NumericUpDown SimpleStarManiaBox;
        private Label label18;
        private NumericUpDown SimpleStarHardBox;
        private Label label16;
        private NumericUpDown SimpleStarNormalBox;
        private Label label15;
        private NumericUpDown SimpleStarEasyBox;
        private Label label19;
        private NumericUpDown SimpleStarUraBox;
        private Button LocateInMusicOrderButton;
        private MusicOrderViewer MusicOrderViewer;
        private TextBox SearchBox;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem preferencesToolStripMenuItem1;
        private ToolStripMenuItem musicOrderToolStripMenuItem;
        private ToolStripMenuItem SortByGenreToolStripMenuItem;
        private ToolStripMenuItem SortByIdToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private GroupBox groupBox12;
        private Label label20;
        private TextBox FumenKeyBox;
        private Label label21;
        private TextBox DatatableKeyBox;
        private CheckBox UseEncryptionBox;
        private GroupBox groupBox13;
        private Label label22;
        private PathSelector DatatableDef;
        private ToolStripMenuItem sortByTitleToolStripMenuItem;
        private ToolStripMenuItem noSortToolStripMenuItem;
    }
}