﻿using System.Diagnostics;
using System.Drawing.Drawing2D;
using TaikoSoundEditor.Data;
using TaikoSoundEditor.Commons.Extensions;
using TaikoSoundEditor.Properties;
using TaikoSoundEditor.Commons.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;
using TaikoSoundEditor.Collections;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TaikoSoundEditor.Commons.Controls
{
    public partial class MusicOrderViewer : UserControl
    {
        public MusicOrderViewer()
        {
            InitializeComponent();


            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(MusicOrdersPanel, true);                    
        }

        internal WordList WordList { get; set; }        

        public List<SongCard> SongCards { get; } = new List<SongCard>();        

        public void AddSong(IMusicOrder mo)
        {
            var songCard = new SongCard(WordList, mo);
            SongCards.Add(songCard);
            CurrentPage = CurrentPage;
        }

        public void SortSongs()
        {
            if (Config.MusicOrderSort == Config.MusicOrderSortValueId) SongCards.Sort((c1, c2) => c1.MusicOrder.UniqueId.CompareTo(c2.MusicOrder.UniqueId));
            else if (Config.MusicOrderSort == Config.MusicOrderSortValueTitle) SongCards.Sort((c1, c2) => c1.Title.CompareTo(c2.Title));
            else if (Config.MusicOrderSort == Config.MusicOrderSortValueGenre) SongCards.Sort((c1, c2) => {
                var ret = c1.Genre.CompareTo(c2.Genre);
                if (ret == 0) ret = c1.Title.CompareTo(c2.Title);
                return ret;
            });
        }

        public void RemoveAllSongs(int uniqueId)
        {
            SongCards.RemoveAll(c => c.MusicOrder.UniqueId == uniqueId);
            Selection.RemoveWhere(c => c.MusicOrder.UniqueId == uniqueId);
            CutSelection.RemoveWhere(c => c.MusicOrder.UniqueId == uniqueId);

            PasteActive = CutSelection.Count > 0;
            CutActive = RemoveActive = Selection.Count > 0;
            if (!PasteActive) PasteMode = false;
            CurrentPage = CurrentPage;
            Invalidate();

        }

        public void RemoveSong(IMusicOrder mo)
        {
            SongCards.RemoveAll(c => c.MusicOrder == mo);
            Selection.RemoveWhere(c => c.MusicOrder == mo);
            CutSelection.RemoveWhere(c => c.MusicOrder == mo);

            PasteActive = CutSelection.Count > 0;
            CutActive = RemoveActive = Selection.Count > 0;
            if (!PasteActive) PasteMode = false;
            CurrentPage = CurrentPage;
            Invalidate();
        }

        private int _CurrentPage = 0;       
        public int CurrentPage
        {
            get => _CurrentPage;
            set
            {
                _CurrentPage = value.Clamp(0, PagesCount - 1);
                PageLabel.Text = $"Page {_CurrentPage + 1} of {PagesCount}";
                MusicOrdersPanel.Invalidate();

                LeftButton.Enabled = _CurrentPage > 0;
                RightButton.Enabled = _CurrentPage < PagesCount - 1;
            }
        }

        public int PagesCount => (SongCards.Count + ItemsPerPage - 1) / ItemsPerPage;

        private int _ItemsPerRow = 4;
        private int _ItemsPerCol = 5;
        public int ItemsPerRow
        {
            get => _ItemsPerRow;
            set
            {
                _ItemsPerRow = value;
                MusicOrdersPanel.Invalidate();
            }
        }

        public int ItemsPerCol
        {
            get => _ItemsPerCol;
            set
            {
                _ItemsPerCol = value;
                MusicOrdersPanel.Invalidate();
            }
        }

        public int ItemsPerPage => ItemsPerRow * ItemsPerCol;
          

        private static int ItemsPadding = 3;

        public void RefreshMusicOrdersPanel(Graphics g)
        {
            var cards = SongCards.Skip(CurrentPage * ItemsPerPage).Take(ItemsPerPage).ToArray();

            int itemW = MusicOrdersPanel.Width / ItemsPerRow - 2 * ItemsPadding;
            int itemH = MusicOrdersPanel.Height / ItemsPerCol - 2 * ItemsPadding;

            var cursor = MusicOrdersPanel.PointToClient(Cursor.Position);

            for (int r = 0; r < ItemsPerCol; r++) 
            {
                for (int c = 0; c < ItemsPerRow; c++) 
                {
                    int index = r * ItemsPerRow + c;

                    var rect = new Rectangle(
                        c * (itemW + 2 * ItemsPadding) + ItemsPadding,
                        r * (itemH + 2 * ItemsPadding) + ItemsPadding,
                        itemW,
                        itemH);

                    if (index >= cards.Length)
                    {
                        if (index == cards.Length && rect.Contains(cursor) && PasteMode) 
                        {


                            g.DrawLine(Pens.Black, rect.Left - 2, rect.Top, rect.Left - 2, rect.Top + rect.Height);
                        }
                        break;
                    }                        

                    var card = cards[index];                    

                    g.FillRectangle(new SolidBrush(card.Color), rect);                    

                    if(card.IsSelected)
                    {
                        g.DrawRectangle(Pens.Blue, rect.Left - 1, rect.Top - 1, rect.Width + 1, rect.Height + 1);
                        g.DrawRectangle(Pens.Green, rect.Left - 2, rect.Top - 2, rect.Width + 3, rect.Height + 3);
                        g.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.White)), rect);
                    }

                    if(card.IsCut)
                    {
                        g.FillRectangle(new HatchBrush(HatchStyle.ForwardDiagonal, Color.White, card.Color), rect);
                    }

                    if (rect.Contains(cursor))
                    {
                        if (PasteMode)
                        {                            
                            g.DrawLine(Pens.Black, rect.Left - 2, rect.Top, rect.Left - 2, rect.Top + rect.Height);
                        }
                        else
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(192, Color.White)), rect);
                        }
                    }

                    var cardInfo = $"{card.Id} ({card.Genre})\n{card.Title}\n{card.Subtitle}";
                    g.DrawString(cardInfo, Font, Brushes.Black, rect);
                }
            }
        }

        public void MusicOrdersPanel_Update() => MusicOrdersPanel.Invalidate();

        private void MusicOrdersPanel_Resize(object sender, EventArgs e) => ExceptionGuard.Run(() =>
        {
            MusicOrdersPanel.Invalidate();
        });

        private void MusicOrdersPanel_Paint(object sender, PaintEventArgs e) => ExceptionGuard.Run(() =>
        {
            RefreshMusicOrdersPanel(e.Graphics);
        });

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 0) CurrentPage--;            
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage < PagesCount - 1) CurrentPage++;
        }

        private void MusicOrdersPanel_MouseMove(object sender, MouseEventArgs e) => ExceptionGuard.Run(() =>
        {
            Invalidate();
        });

        private void MusicOrdersPanel_MouseLeave(object sender, EventArgs e) => ExceptionGuard.Run(() =>
        {
            Invalidate();
        });

        public HashSet<SongCard> Selection = new HashSet<SongCard>();        
        public HashSet<SongCard> CutSelection = new HashSet<SongCard>();


        private void MusicOrdersPanel_MouseDown(object sender, MouseEventArgs e) => ExceptionGuard.Run(() =>
        {
            if (e.Button == MouseButtons.Right)
            {
                Select();
                var cursor = e.Location;

                int itemW = MusicOrdersPanel.Width / ItemsPerRow;
                int itemH = MusicOrdersPanel.Height / ItemsPerCol;

                int row = cursor.Y / itemH;
                int col = cursor.X / itemW;
                //Debug.WriteLine($"{row} {col}");            


                if (row < 0 || row >= ItemsPerCol || col < 0 || col >= ItemsPerRow)
                    return;
                var index = CurrentPage * ItemsPerPage + row * ItemsPerRow + col;
                if (index < 0 || index > SongCards.Count) return;

                CardToClone = SongCards[index];                
                GenreCloneMenuStrip.Show(MusicOrdersPanel, cursor);
            }
            else
            {

                if (e.Button != MouseButtons.Left) return;
                Select();
                var cursor = e.Location;

                int itemW = MusicOrdersPanel.Width / ItemsPerRow;
                int itemH = MusicOrdersPanel.Height / ItemsPerCol;

                int row = cursor.Y / itemH;
                int col = cursor.X / itemW;
                //Debug.WriteLine($"{row} {col}");            


                if (row < 0 || row >= ItemsPerCol || col < 0 || col >= ItemsPerRow)
                    return;
                var index = CurrentPage * ItemsPerPage + row * ItemsPerRow + col;

                if (PasteMode)
                {
                    if (index < 0 || index > SongCards.Count) return;

                    SongCard before = null, after = null;

                    for (int i = index; i < SongCards.Count; i++)
                        if (!SongCards[i].IsCut)
                        {
                            before = SongCards[i];
                            break;
                        }
                    for (int i = index - 1; i >= 0; i--)
                        if (!SongCards[i].IsCut)
                        {
                            after = SongCards[i];
                            break;
                        }

                    string message = "Do you want to move the selected songs?";

                    if (before != null)
                    {
                        if (after != null && before != after)
                        {
                            message = $"Do you want to move the selected songs before {before.Id} and after {after.Id}?";
                        }
                        else
                        {
                            message = $"Do you want to move the selected songs before {before.Id}?";
                        }
                    }
                    else if (after != null)
                    {
                        message = $"Do you want to move the selected songs after {after.Id}?";
                    }

                    if (MessageBox.Show(message, "Move songs?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    SongCards.RemoveAll(CutSelection.Contains);
                    var ix = after != null ? SongCards.IndexOf(after) + 1 : before != null ? SongCards.IndexOf(before) : 0;
                    SongCards.InsertRange(ix, CutSelection);

                    foreach (var c in CutSelection) c.IsCut = false;
                    CutSelection.Clear();
                    PasteMode = false;
                    PasteActive = false;
                    CutActive = RemoveActive = false;
                    MusicOrdersPanel.Invalidate();

                    return;
                }

                if (index < 0 || index >= SongCards.Count) return;

                var card = SongCards[index];

                if (Form.ModifierKeys == Keys.Control)
                {
                    if (card.IsSelected)
                    {
                        card.IsSelected = false;
                        Selection.Remove(card);
                    }
                    else
                    {
                        card.IsSelected = true;
                        Selection.Add(card);
                    }
                    MusicOrdersPanel.Invalidate();
                }
                else
                {
                    foreach (var sel in Selection)
                    {
                        sel.IsSelected = false;
                    }
                    Selection.Clear();

                    card.IsSelected = true;
                    Selection.Add(card);
                    MusicOrdersPanel.Invalidate();
                }

                CutActive = RemoveActive = Selection.Count > 0;
            }
        });

        private bool _CutActive = false;
        public bool CutActive
        {
            get => _CutActive;
            set
            {
                _CutActive = value;
                CutButton.BackgroundImage = CutActive ? Resources.ic_cut : Resources.ic_cut_gs;
                CutButton.Enabled = CutActive;
            }
        }

        private bool _PasteActive = false;
        public bool PasteActive
        {
            get => _PasteActive;
            set
            {
                _PasteActive = value;
                PasteButton.BackgroundImage = PasteActive ? Resources.ic_paste : Resources.ic_paste_gs;
                PasteButton.Enabled = PasteActive;
            }
        }

        private bool _RemoveActive=false;

        public bool RemoveActive
        {
            get => _RemoveActive;
            set
            {
                _RemoveActive = value;
                RemoveButton.BackgroundImage = RemoveActive ? Resources.ic_remove : Resources.ic_remove_gs;
                RemoveButton.Enabled = RemoveActive;
            }
        }

        private void CutButton_Click(object sender, EventArgs e) => ExceptionGuard.Run(() =>
        {
            PasteMode = false;
            foreach (var card in CutSelection)
            {
                card.IsCut = false;
            }
            CutSelection.Clear();

            foreach (var card in Selection)
            {
                card.IsCut = true;
                card.IsSelected = false;
                CutSelection.Add(card);
            }
            Selection.Clear();

            PasteActive = CutSelection.Count > 0;
            CutActive = RemoveActive = Selection.Count > 0;

            MusicOrdersPanel.Invalidate();
        });

        private bool _PasteMode = false;

        public bool PasteMode
        {
            get => _PasteMode;
            set
            {
                _PasteMode = value;
                PasteButton.FlatAppearance.BorderSize = _PasteMode ? 1 : 0;
            }
        }


        private void PasteButton_Click(object sender, EventArgs e) => ExceptionGuard.Run(() =>
        {
            PasteMode = !PasteMode;

            foreach (var card in Selection)
                card.IsSelected = false;
            Selection.Clear();
            CutActive = RemoveActive = false;
            MusicOrdersPanel.Invalidate();
        });

        public bool SongExists(int uniqueId) => SongCards.Any(c => c.MusicOrder.UniqueId == uniqueId);

        private void RemoveButton_Click(object sender, EventArgs e) => ExceptionGuard.Run(() =>
        {
            var toRemove = Selection.ToList();
            if (Selection.Count == 0)
                return;

            var message = $"Are you sure you want to remove {toRemove.Count} song{(toRemove.Count != 1 ? "s" : "")}?";

            if (MessageBox.Show(message, "Remove?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            foreach (var card in Selection)
            {
                SongCards.Remove(card);
                CutSelection.Remove(card);
                SongRemoved?.Invoke(this, card.MusicOrder);
            }
            Selection.Clear();

            CutActive = RemoveActive = false;
            PasteActive = CutSelection.Count > 0;
            if (!PasteActive) PasteMode = false;
            CurrentPage = CurrentPage;
            MusicOrdersPanel.Invalidate();
        });

        public delegate void OnSongRemoved(MusicOrderViewer sender, IMusicOrder mo);
        public event OnSongRemoved SongRemoved;

        private void ListStartButton_Click(object sender, EventArgs e)
        {
            CurrentPage = 0;
            MusicOrdersPanel.Invalidate();
        }

        private void ListEndButton_Click(object sender, EventArgs e)
        {
            CurrentPage = PagesCount - 1;
            MusicOrdersPanel.Invalidate();
        }

        private void Left10Button_Click(object sender, EventArgs e)
        {
            CurrentPage -= 10;
            MusicOrdersPanel.Invalidate();
        }

        private void Right10Button_Click(object sender, EventArgs e)
        {
            CurrentPage += 10;
            MusicOrdersPanel.Invalidate();
        }

        public bool Locate(IMusicOrder mo)
        {
            var card = SongCards.Where(c => c.MusicOrder == mo).FirstOrDefault();
            if (card == null) return false;
            var index = SongCards.IndexOf(card);
            Select(index);
            return true;
        }

        private void Select(int index)
        {
            CurrentPage = index / ItemsPerPage;

            SongCards[index].IsSelected = true;
            Selection.Add(SongCards[index]);

            CutActive = RemoveActive = true;            
            MusicOrdersPanel.Invalidate();
        }     

        public delegate void OnSongDoubleClick(MusicOrderViewer sender, IMusicOrder mo);
        public event OnSongDoubleClick SongDoubleClick;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {            
            if (keyData == (Keys.Control | Keys.X) || keyData == (Keys.Control | Keys.C))
            {
                //MessageBox.Show("Here?");
                if(CutActive)
                {
                    CutButton_Click(null, null);
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.V))
            {
                if(PasteActive)
                {
                    PasteButton_Click(null, null);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MusicOrdersPanel_DoubleClick(object sender, EventArgs e)
        {            
            var cursor = MusicOrdersPanel.PointToClient(Cursor.Position);

            int itemW = MusicOrdersPanel.Width / ItemsPerRow;
            int itemH = MusicOrdersPanel.Height / ItemsPerCol;

            int row = cursor.Y / itemH;
            int col = cursor.X / itemW;
            //MessageBox.Show($"{row} {col}");            



            if (row < 0 || row >= ItemsPerCol || col < 0 || col >= ItemsPerRow)
                return;
            var index = CurrentPage * ItemsPerPage + row * ItemsPerRow + col;

            //MessageBox.Show($"{index}");
            if (index < 0 || index > SongCards.Count) return;

            SongDoubleClick?.Invoke(this, SongCards[index].MusicOrder);
        }

        private SongCard CardToClone = null;
        private void GenreCloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CardToClone == null) return;

            var genre = (Genre)Enum.Parse(typeof(Genre), (sender as ToolStripMenuItem).Text);
            //MessageBox.Show(genre.ToString());

            var newMO = DatatableTypes.Clone(CardToClone.MusicOrder);
            newMO.Genre = genre;
            AddSong(newMO);
            SortSongs();
        }
    }
}
