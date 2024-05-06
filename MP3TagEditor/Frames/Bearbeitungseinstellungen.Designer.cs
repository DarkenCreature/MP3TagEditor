namespace MP3TagEditor.Frames
{
    partial class Bearbeitungseinstellungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bearbeitungseinstellungen));
            this.check_RPAs = new System.Windows.Forms.CheckBox();
            this.check_CustRPAs = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_RPAs
            // 
            this.check_RPAs.AutoSize = true;
            this.check_RPAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_RPAs.Location = new System.Drawing.Point(12, 12);
            this.check_RPAs.Name = "check_RPAs";
            this.check_RPAs.Size = new System.Drawing.Size(203, 20);
            this.check_RPAs.TabIndex = 1;
            this.check_RPAs.Text = "Use Replacement Arguments";
            this.check_RPAs.UseVisualStyleBackColor = true;
            this.check_RPAs.CheckedChanged += new System.EventHandler(this.check_RPAs_CheckedChanged);
            // 
            // check_CustRPAs
            // 
            this.check_CustRPAs.AutoSize = true;
            this.check_CustRPAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_CustRPAs.Location = new System.Drawing.Point(12, 38);
            this.check_CustRPAs.Name = "check_CustRPAs";
            this.check_CustRPAs.Size = new System.Drawing.Size(251, 20);
            this.check_CustRPAs.TabIndex = 3;
            this.check_CustRPAs.Text = "Use Custom Replacement Arguments";
            this.check_CustRPAs.UseVisualStyleBackColor = true;
            this.check_CustRPAs.CheckedChanged += new System.EventHandler(this.check_CustRPAs_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bearbeitungseinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 116);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_CustRPAs);
            this.Controls.Add(this.check_RPAs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bearbeitungseinstellungen";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_RPAs;
        private System.Windows.Forms.CheckBox check_CustRPAs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}