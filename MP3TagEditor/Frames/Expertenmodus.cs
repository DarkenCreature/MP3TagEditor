using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Id3;

namespace MP3TagEditor.Frames
{
    public partial class Expertenmodus : Form
    {
        public Expertenmodus()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            lV_Dateien.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(txt_path.Text + "\\");
            int i = 1;

            foreach(FileInfo fi in directory.GetFiles("*.mp3", SearchOption.AllDirectories))
            {
                using(var mp3 = new Mp3(fi.FullName, Mp3Permissions.ReadWrite))
                {
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);

                    ListViewItem item = new ListViewItem(i.ToString()); // ID
                    item.SubItems.Add("." + fi.Name.Split('.')[fi.Name.Split('.').Length -1]); // Dateiformat
                    item.SubItems.Add(fi.Name.Replace("." + fi.Name.Split('.')[fi.Name.Split('.').Length - 1], ""));       // Dateiname
                    item.SubItems.Add(fi.FullName.Replace(fi.Name, ""));    // Pfad

                    try
                    {
                        item.SubItems.Add(tag.Artists.Value[0]);
                        item.SubItems.Add(tag.Album);
                    }
                    catch
                    {
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }

                    lV_Dateien.Items.Add(item);
                }
                i++;
            }
        }

        private void Btt_check_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lV_Dateien.SelectedItems)
            {
                if (!(txt_Artist.Text == ""))
                    lvi.SubItems[4].Text = txt_Artist.Text;

                if (!(txt_Album.Text == ""))
                    lvi.SubItems[5].Text = txt_Album.Text;
            }
        }

        private void Btt_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dlg = fbd.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                txt_path.Text = fbd.SelectedPath;
                LoadData();
            }
        }

        private void Btt_start_Click(object sender, EventArgs e)
        {
            if (lV_Dateien.Items.Count > 0)
            {
                DialogResult dlgres = MessageBox.Show("Wollen Sie den Vorgang wirklich starten? Die Änderungen können nicht rückgängig gemacht werden.", "Vorgang starten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgres == DialogResult.Yes)
                    StarteProzess();
            }
            else
                MessageBox.Show("Es wurden keine Dateien in die Liste geladen. Der Vorgang wird abgebrochen.");
        }

        public void StarteProzess()
        {
            string title = "";

            foreach (ListViewItem lvi in lV_Dateien.Items)
            {
                TextEraser eraser = new TextEraser(lvi.SubItems[4].Text);

                try
                {
                    using (var mp3 = new Mp3(lvi.SubItems[3].Text + lvi.SubItems[2].Text + lvi.SubItems[1].Text, Mp3Permissions.ReadWrite))
                    {
                        Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);

                        if (tag == null)
                            tag = new Id3Tag();

                        tag.Album.Value = lvi.SubItems[5].Text;

                        if (!(lvi.SubItems[4].Text == ""))
                        {
                            tag.Artists.Value.Clear();
                            tag.Artists.Value.Add(lvi.SubItems[4].Text);
                        }

                        title = eraser.EraseText(lvi.SubItems[2].Text);
                        tag.Title.Value = title;
                        mp3.WriteTag(tag, Id3Version.V23, WriteConflictAction.Replace);
                    }
                    File.Move(lvi.SubItems[3].Text + lvi.SubItems[2].Text + lvi.SubItems[1].Text, lvi.SubItems[3].Text + title + ".mp3");
                }
                catch (Exception fe)
                {
                    MessageBox.Show("Es wurde ein Fehler festgestellt.\n\nFehlercode: " + fe.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Successfull!");
            LoadData();
        }

        private void Btt_delete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lV_Dateien.SelectedItems)
            {
                lvi.SubItems[4].Text = "";
                lvi.SubItems[5].Text = "";
            }
        }
    }
}
