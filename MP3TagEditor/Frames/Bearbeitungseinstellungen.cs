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
    public partial class Bearbeitungseinstellungen : Form
    {
        public Bearbeitungseinstellungen()
        {
            InitializeComponent();
            SetUp();
        }

        void SetUp()
        {
            if (Settings.Settings.Default["UseRPA"].ToString() == "1")
                check_RPAs.Checked = true;
            else
                check_RPAs.Checked = false;
            if (Settings.Settings.Default["UseCustRPA"].ToString() == "1")
                check_CustRPAs.Checked = true;
            else
                check_CustRPAs.Checked = false;
        }

        private void check_CustRPAs_CheckedChanged(object sender, EventArgs e)
        {
            if (check_CustRPAs.Checked)
                Settings.Settings.Default["UseCustRPA"] = "1";
            else
                Settings.Settings.Default["UseCustRPA"] = "0";
        }

        private void check_RPAs_CheckedChanged(object sender, EventArgs e)
        {
            if (check_RPAs.Checked)
                Settings.Settings.Default["UseRPA"] = "1";
            else
                Settings.Settings.Default["UseRPA"] = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MP3TagEditor.Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
