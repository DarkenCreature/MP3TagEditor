namespace MP3TagEditor.Frames
{
    partial class CustomReplArguments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomReplArguments));
            this.btt_save = new System.Windows.Forms.Button();
            this.btt_remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_Arguments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_save
            // 
            this.btt_save.Location = new System.Drawing.Point(367, 406);
            this.btt_save.Name = "btt_save";
            this.btt_save.Size = new System.Drawing.Size(75, 23);
            this.btt_save.TabIndex = 31;
            this.btt_save.Text = "speichern";
            this.btt_save.UseVisualStyleBackColor = true;
            this.btt_save.Click += new System.EventHandler(this.Btt_save_Click);
            // 
            // btt_remove
            // 
            this.btt_remove.Location = new System.Drawing.Point(312, 377);
            this.btt_remove.Name = "btt_remove";
            this.btt_remove.Size = new System.Drawing.Size(130, 23);
            this.btt_remove.TabIndex = 30;
            this.btt_remove.Text = "Argument entfernen";
            this.btt_remove.UseVisualStyleBackColor = true;
            this.btt_remove.Click += new System.EventHandler(this.Btt_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 48);
            this.label2.TabIndex = 28;
            this.label2.Text = "In der folgenden Liste kannst du eigene ReplacementArguments\r\nhinzufügen und verw" +
    "alten. Diese Argumente werden dann im \r\nRahmen der Umbenennung deiner Titel berü" +
    "cksichtigt.\r\n";
            // 
            // lv_Arguments
            // 
            this.lv_Arguments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_Arguments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Arguments.FullRowSelect = true;
            this.lv_Arguments.HideSelection = false;
            this.lv_Arguments.Location = new System.Drawing.Point(28, 119);
            this.lv_Arguments.Name = "lv_Arguments";
            this.lv_Arguments.Size = new System.Drawing.Size(414, 252);
            this.lv_Arguments.TabIndex = 26;
            this.lv_Arguments.UseCompatibleStateImageBehavior = false;
            this.lv_Arguments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Argument";
            this.columnHeader2.Width = 317;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Custom ReplacementArguments:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-76, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 467);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(176, 377);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(130, 23);
            this.btt_add.TabIndex = 32;
            this.btt_add.Text = "Argument hinzufügen";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.Btt_add_Click);
            // 
            // CustomReplArguments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.btt_save);
            this.Controls.Add(this.btt_remove);
            this.Controls.Add(this.lv_Arguments);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(484, 489);
            this.MinimumSize = new System.Drawing.Size(484, 489);
            this.Name = "CustomReplArguments";
            this.Text = "CustomReplArguments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomReplArguments_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btt_save;
        private System.Windows.Forms.Button btt_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_Arguments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btt_add;
    }
}