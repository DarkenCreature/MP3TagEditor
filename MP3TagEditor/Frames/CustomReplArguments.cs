using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MP3TagEditor.Frames
{
    public partial class CustomReplArguments : Form
    {
        Settings.CustomRpl crpl;
        public bool close;
        bool dataSaved;

        public CustomReplArguments()
        {
            InitializeComponent();

            close = false;
            dataSaved = true;
            crpl = new Settings.CustomRpl(Application.StartupPath + "\\");
            if (!crpl.TestingCustomArg())
            {
                DialogResult dlgres = MessageBox.Show("Sie haben keine eigenen ReplacementArguments definiert. Wollen Sie Argumente definieren?", "Keine Argumente vorhanden", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dlgres == DialogResult.Yes)
                {
                    string input = Interaction.InputBox("Gib dein erstes eigenes Argument ein:", "Argument hinzufügen", "");
                    if (input.Length > 0)
                    {
                        crpl.AddNew(input);
                        crpl.SaveData();
                        LoadCustoms();
                    }
                    else
                    {
                        MessageBox.Show("Ihre Eingabe konnte nicht angenommen werden. Probieren Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    close = true;
                }
            }
            else
            {
                LoadCustoms();
            }
        }

        private void Btt_add_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Gib ein eigenes Argument ein:", "Argument hinzufügen", "");
            if (input.Length > 0)
            {
                crpl.AddNew(input);
                dataSaved = false;
                LoadCustoms();
            }
            else
            {
                MessageBox.Show("Ihre Eingabe konnte nicht angenommen werden. Probieren Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btt_save_Click(object sender, EventArgs e)
        {
            crpl.SaveData();
            dataSaved = true;
            this.Close();
        }

        private void Btt_remove_Click(object sender, EventArgs e)
        {
            if (lv_Arguments.SelectedItems.Count > 0)
                crpl.Remove(int.Parse(lv_Arguments.SelectedItems[0].SubItems[0].Text));
            dataSaved = false;
            LoadCustoms();
        }

        private void LoadCustoms()
        {
            lv_Arguments.Items.Clear();
            for (int i = 0; i < crpl.arguments.Length; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(crpl.arguments[i]);
                lv_Arguments.Items.Add(item);
            }
        }

        private void CustomReplArguments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dataSaved)
            {
                DialogResult dlgres = MessageBox.Show("Wollen Sie das Fenster wirklich schließen? Nicht gespeicherte Argumente gehen verloren!", "Schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgres == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
