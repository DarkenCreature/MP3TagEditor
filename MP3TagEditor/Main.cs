using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Id3;
using Id3.Frames;
using Id3.InfoFx;
using Id3.v2;

namespace MP3TagEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btt_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Musik (*.mp3)|*.mp3";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
                txt_Pfad.Text = ofd.FileName.Replace(ofd.SafeFileName, "");
            else
                txt_Pfad.Text = "";

            ListFiles();
        }

        private void ListFiles()
        {
            lV_Dateien.Items.Clear();
            if (!(txt_Pfad.Text == ""))
                foreach (System.IO.FileInfo f in new DirectoryInfo(txt_Pfad.Text).GetFiles())
                {
                    Char splitter = '.';
                    ListViewItem item = new ListViewItem(f.Name.Split(splitter)[0]);
                    item.SubItems.Add("." + f.Name.Split(splitter)[1]);
                    lV_Dateien.Items.Add(item);
                }
        }


        private void Btt_Begin_Click(object sender, EventArgs e)
        {
            if(lV_Dateien.Items.Count > 0 && !(txt_Pfad.Text == ""))
            {
                TextEraser eraser = new TextEraser(txt_Interpret.Text);

                foreach (ListViewItem lvi in lV_Dateien.Items)
                {
                    string title = "";
                    
                    if(lvi.SubItems[1].Text == ".mp3")
                    {
                        try
                        {
                            using (var mp3 = new Mp3(txt_Pfad.Text + lvi.SubItems[0].Text + ".mp3", Mp3Permissions.ReadWrite))
                            {
                                Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);

                                if (tag == null)
                                    tag = new Id3Tag();

                                tag.Album.Value = txt_Album.Text;

                                if (!(txt_Interpret.Text == ""))
                                {
                                    tag.Artists.Value.Clear();
                                    tag.Artists.Value.Add(txt_Interpret.Text);
                                }

                                tag.Comments.Clear();

                                title = eraser.EraseText(lvi.SubItems[0].Text);
                                tag.Title.Value = title;
                                mp3.WriteTag(tag, Id3Version.V23, WriteConflictAction.Replace);
                            }
                            File.Move(txt_Pfad.Text + lvi.SubItems[0].Text + ".mp3", txt_Pfad.Text + title + ".mp3");
                        }
                        catch (Exception fe)
                        {
                            MessageBox.Show($"Es wurde ein Fehler festgestellt.\n\nFehlernachricht:\n{fe.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Successfull!");
                ListFiles();
            }
        }


        private void Btt_del_Click(object sender, EventArgs e)
        {
            if (lV_Dateien.SelectedItems.Count > 0)
            {
                foreach(ListViewItem lvi in lV_Dateien.SelectedItems)
                    lV_Dateien.Items.Remove(lvi);
            }
        }

        private void Btt_delAll_Click(object sender, EventArgs e)
        {
            lV_Dateien.Items.Clear();
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frames.Information inf = new Frames.Information();
            inf.ShowDialog();
        }

        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // === HILFE ===

        }

        private void ReplacementStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementArguments arguments = new ReplacementArguments();
            arguments.ShowDialog();
        }

        private void EigeneReplacementArgumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frames.CustomReplArguments crpl = new Frames.CustomReplArguments();
            if (crpl.close)
                crpl.Dispose();
            else
                crpl.ShowDialog();
        }

        private void ExpertenmodusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frames.Expertenmodus exp = new Frames.Expertenmodus();
            exp.Show();
        }

        private void bearbeitungsseinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frames.Bearbeitungseinstellungen bearbeitung = new Frames.Bearbeitungseinstellungen();
            bearbeitung.ShowDialog();
        }
    }
}
