using MP3TagEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3TagEditor
{
    public partial class ReplacementArguments : Form
    {
        public ReplacementArguments()
        {
            InitializeComponent();
            TextEraser eraser = new TextEraser("[Interpret]");

            for(int i = 0; i < eraser.löschText.Length; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(eraser.löschText[i]);
                lv_Arguments.Items.Add(item);
            }
        }

        private void Btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
