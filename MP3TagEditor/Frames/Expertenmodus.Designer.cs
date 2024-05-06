namespace MP3TagEditor.Frames
{
    partial class Expertenmodus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expertenmodus));
            this.lV_Dateien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.txt_Album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btt_Browse = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_check = new System.Windows.Forms.Button();
            this.btt_start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lV_Dateien
            // 
            this.lV_Dateien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lV_Dateien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV_Dateien.FullRowSelect = true;
            this.lV_Dateien.HideSelection = false;
            this.lV_Dateien.Location = new System.Drawing.Point(12, 195);
            this.lV_Dateien.Name = "lV_Dateien";
            this.lV_Dateien.Size = new System.Drawing.Size(1324, 393);
            this.lV_Dateien.TabIndex = 0;
            this.lV_Dateien.UseCompatibleStateImageBehavior = false;
            this.lV_Dateien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dateityp";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datei";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pfad";
            this.columnHeader4.Width = 451;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Interpret";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Album";
            this.columnHeader6.Width = 277;
            // 
            // txt_Artist
            // 
            this.txt_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Artist.Location = new System.Drawing.Point(884, 109);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(223, 22);
            this.txt_Artist.TabIndex = 1;
            // 
            // txt_Album
            // 
            this.txt_Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Album.Location = new System.Drawing.Point(1113, 109);
            this.txt_Album.Name = "txt_Album";
            this.txt_Album.Size = new System.Drawing.Size(223, 22);
            this.txt_Album.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(881, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artist / Interpret:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1110, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(881, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordnerpfad:";
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(884, 56);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(416, 22);
            this.txt_path.TabIndex = 5;
            // 
            // btt_Browse
            // 
            this.btt_Browse.Location = new System.Drawing.Point(1306, 55);
            this.btt_Browse.Name = "btt_Browse";
            this.btt_Browse.Size = new System.Drawing.Size(30, 23);
            this.btt_Browse.TabIndex = 8;
            this.btt_Browse.Text = "...";
            this.btt_Browse.UseVisualStyleBackColor = true;
            this.btt_Browse.Click += new System.EventHandler(this.Btt_Browse_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_delete.BackgroundImage")));
            this.btt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_delete.Location = new System.Drawing.Point(1270, 159);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(30, 30);
            this.btt_delete.TabIndex = 9;
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.Btt_delete_Click);
            // 
            // btt_check
            // 
            this.btt_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_check.BackgroundImage")));
            this.btt_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btt_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_check.Location = new System.Drawing.Point(1306, 159);
            this.btt_check.Name = "btt_check";
            this.btt_check.Size = new System.Drawing.Size(30, 30);
            this.btt_check.TabIndex = 10;
            this.btt_check.UseCompatibleTextRendering = true;
            this.btt_check.UseVisualStyleBackColor = true;
            this.btt_check.Click += new System.EventHandler(this.Btt_check_Click);
            // 
            // btt_start
            // 
            this.btt_start.Location = new System.Drawing.Point(1263, 594);
            this.btt_start.Name = "btt_start";
            this.btt_start.Size = new System.Drawing.Size(73, 23);
            this.btt_start.TabIndex = 11;
            this.btt_start.Text = "starten";
            this.btt_start.UseVisualStyleBackColor = true;
            this.btt_start.Click += new System.EventHandler(this.Btt_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Expertenmodus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btt_start);
            this.Controls.Add(this.btt_check);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_Browse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Album);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.lV_Dateien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1364, 668);
            this.MinimumSize = new System.Drawing.Size(1364, 668);
            this.Name = "Expertenmodus";
            this.Text = "Expertenmodus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lV_Dateien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.TextBox txt_Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btt_Browse;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_check;
        private System.Windows.Forms.Button btt_start;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}