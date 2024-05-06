using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3TagEditor.Frames
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Btt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
