namespace MP3TagEditor
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txt_Pfad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_path = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Interpret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Album = new System.Windows.Forms.TextBox();
            this.btt_Begin = new System.Windows.Forms.Button();
            this.lV_Dateien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btt_del = new System.Windows.Forms.Button();
            this.btt_delAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anwendungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertenmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigeneReplacementArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitungsseinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pfad
            // 
            this.txt_Pfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pfad.Location = new System.Drawing.Point(283, 57);
            this.txt_Pfad.Name = "txt_Pfad";
            this.txt_Pfad.Size = new System.Drawing.Size(493, 22);
            this.txt_Pfad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(280, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordnerpfad:";
            // 
            // btt_path
            // 
            this.btt_path.Location = new System.Drawing.Point(785, 56);
            this.btt_path.Name = "btt_path";
            this.btt_path.Size = new System.Drawing.Size(30, 23);
            this.btt_path.TabIndex = 2;
            this.btt_path.Text = "...";
            this.btt_path.UseVisualStyleBackColor = true;
            this.btt_path.Click += new System.EventHandler(this.Btt_path_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(280, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interpret:";
            // 
            // txt_Interpret
            // 
            this.txt_Interpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Interpret.Location = new System.Drawing.Point(283, 101);
            this.txt_Interpret.Name = "txt_Interpret";
            this.txt_Interpret.Size = new System.Drawing.Size(259, 22);
            this.txt_Interpret.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(552, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album:";
            // 
            // txt_Album
            // 
            this.txt_Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Album.Location = new System.Drawing.Point(555, 101);
            this.txt_Album.Name = "txt_Album";
            this.txt_Album.Size = new System.Drawing.Size(259, 22);
            this.txt_Album.TabIndex = 5;
            // 
            // btt_Begin
            // 
            this.btt_Begin.Location = new System.Drawing.Point(739, 129);
            this.btt_Begin.Name = "btt_Begin";
            this.btt_Begin.Size = new System.Drawing.Size(75, 23);
            this.btt_Begin.TabIndex = 9;
            this.btt_Begin.Text = "start";
            this.btt_Begin.UseVisualStyleBackColor = true;
            this.btt_Begin.Click += new System.EventHandler(this.Btt_Begin_Click);
            // 
            // lV_Dateien
            // 
            this.lV_Dateien.BackColor = System.Drawing.SystemColors.Control;
            this.lV_Dateien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lV_Dateien.FullRowSelect = true;
            this.lV_Dateien.HideSelection = false;
            this.lV_Dateien.Location = new System.Drawing.Point(283, 185);
            this.lV_Dateien.Name = "lV_Dateien";
            this.lV_Dateien.Size = new System.Drawing.Size(532, 230);
            this.lV_Dateien.TabIndex = 10;
            this.lV_Dateien.UseCompatibleStateImageBehavior = false;
            this.lV_Dateien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dateiname";
            this.columnHeader1.Width = 285;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dateityp";
            this.columnHeader2.Width = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(280, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "zu ändernde Dateien:";
            // 
            // btt_del
            // 
            this.btt_del.Location = new System.Drawing.Point(283, 421);
            this.btt_del.Name = "btt_del";
            this.btt_del.Size = new System.Drawing.Size(44, 23);
            this.btt_del.TabIndex = 12;
            this.btt_del.Text = "del";
            this.btt_del.UseVisualStyleBackColor = true;
            this.btt_del.Click += new System.EventHandler(this.Btt_del_Click);
            // 
            // btt_delAll
            // 
            this.btt_delAll.Location = new System.Drawing.Point(333, 421);
            this.btt_delAll.Name = "btt_delAll";
            this.btt_delAll.Size = new System.Drawing.Size(109, 23);
            this.btt_delAll.TabIndex = 13;
            this.btt_delAll.Text = "delete all";
            this.btt_delAll.UseVisualStyleBackColor = true;
            this.btt_delAll.Click += new System.EventHandler(this.Btt_delAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(80, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "© Thomas Hisgen // 2020";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anwendungToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anwendungToolStripMenuItem
            // 
            this.anwendungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expertenmodusToolStripMenuItem,
            this.informationToolStripMenuItem1,
            this.beendenToolStripMenuItem});
            this.anwendungToolStripMenuItem.Name = "anwendungToolStripMenuItem";
            this.anwendungToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.anwendungToolStripMenuItem.Text = "Anwendung";
            // 
            // expertenmodusToolStripMenuItem
            // 
            this.expertenmodusToolStripMenuItem.Name = "expertenmodusToolStripMenuItem";
            this.expertenmodusToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.expertenmodusToolStripMenuItem.Text = "Expertenmodus";
            this.expertenmodusToolStripMenuItem.Click += new System.EventHandler(this.ExpertenmodusToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem1
            // 
            this.informationToolStripMenuItem1.Name = "informationToolStripMenuItem1";
            this.informationToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.informationToolStripMenuItem1.Text = "Information";
            this.informationToolStripMenuItem1.Click += new System.EventHandler(this.InformationToolStripMenuItem1_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replacementStringsToolStripMenuItem,
            this.eigeneReplacementArgumentsToolStripMenuItem,
            this.bearbeitungsseinstellungenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // replacementStringsToolStripMenuItem
            // 
            this.replacementStringsToolStripMenuItem.Name = "replacementStringsToolStripMenuItem";
            this.replacementStringsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.replacementStringsToolStripMenuItem.Text = "ReplacementArguments";
            this.replacementStringsToolStripMenuItem.Click += new System.EventHandler(this.ReplacementStringsToolStripMenuItem_Click);
            // 
            // eigeneReplacementArgumentsToolStripMenuItem
            // 
            this.eigeneReplacementArgumentsToolStripMenuItem.Name = "eigeneReplacementArgumentsToolStripMenuItem";
            this.eigeneReplacementArgumentsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.eigeneReplacementArgumentsToolStripMenuItem.Text = "Eigene ReplacementArguments";
            this.eigeneReplacementArgumentsToolStripMenuItem.Click += new System.EventHandler(this.EigeneReplacementArgumentsToolStripMenuItem_Click);
            // 
            // bearbeitungsseinstellungenToolStripMenuItem
            // 
            this.bearbeitungsseinstellungenToolStripMenuItem.Name = "bearbeitungsseinstellungenToolStripMenuItem";
            this.bearbeitungsseinstellungenToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.bearbeitungsseinstellungenToolStripMenuItem.Text = "Bearbeitungsseinstellungen";
            this.bearbeitungsseinstellungenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitungsseinstellungenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.HilfeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btt_delAll);
            this.Controls.Add(this.btt_del);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lV_Dateien);
            this.Controls.Add(this.btt_Begin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Album);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Interpret);
            this.Controls.Add(this.btt_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pfad);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(842, 495);
            this.MinimumSize = new System.Drawing.Size(842, 495);
            this.Name = "Main";
            this.Text = "MP3TagEditor - Mainwindow";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pfad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Interpret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Album;
        private System.Windows.Forms.Button btt_Begin;
        private System.Windows.Forms.ListView lV_Dateien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btt_del;
        private System.Windows.Forms.Button btt_delAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anwendungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replacementStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitungsseinstellungenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem eigeneReplacementArgumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertenmodusToolStripMenuItem;
    }
}

