namespace Atsnote
{
    partial class Form1  //põhivormi fail
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopeeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lõikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleebiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valiKõikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tagasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(940, 478);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.redigeeriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusToolStripMenuItem,
            this.avaToolStripMenuItem,
            this.salvestaToolStripMenuItem,
            this.suleToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "Fail";
            // 
            // uusToolStripMenuItem
            // 
            this.uusToolStripMenuItem.Name = "uusToolStripMenuItem";
            this.uusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uusToolStripMenuItem.Text = "Uus";
            this.uusToolStripMenuItem.Click += new System.EventHandler(this.uusToolStripMenuItem_Click);
            // 
            // avaToolStripMenuItem
            // 
            this.avaToolStripMenuItem.Name = "avaToolStripMenuItem";
            this.avaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avaToolStripMenuItem.Text = "Ava";
            this.avaToolStripMenuItem.Click += new System.EventHandler(this.avaToolStripMenuItem_Click);
            // 
            // salvestaToolStripMenuItem
            // 
            this.salvestaToolStripMenuItem.Name = "salvestaToolStripMenuItem";
            this.salvestaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvestaToolStripMenuItem.Text = "Salvesta";
            this.salvestaToolStripMenuItem.Click += new System.EventHandler(this.salvestaToolStripMenuItem_Click);
            // 
            // suleToolStripMenuItem
            // 
            this.suleToolStripMenuItem.Name = "suleToolStripMenuItem";
            this.suleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.suleToolStripMenuItem.Text = "Sule";
            this.suleToolStripMenuItem.Click += new System.EventHandler(this.suleToolStripMenuItem_Click);
            // 
            // redigeeriToolStripMenuItem
            // 
            this.redigeeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopeeriToolStripMenuItem,
            this.lõikaToolStripMenuItem,
            this.kleebiToolStripMenuItem,
            this.valiKõikToolStripMenuItem,
            this.toolStripSeparator1,
            this.tagasiToolStripMenuItem,
            this.edasiToolStripMenuItem});
            this.redigeeriToolStripMenuItem.Name = "redigeeriToolStripMenuItem";
            this.redigeeriToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.redigeeriToolStripMenuItem.Text = "Redigeeri";
            // 
            // kopeeriToolStripMenuItem
            // 
            this.kopeeriToolStripMenuItem.Name = "kopeeriToolStripMenuItem";
            this.kopeeriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kopeeriToolStripMenuItem.Text = "Kopeeri";
            this.kopeeriToolStripMenuItem.Click += new System.EventHandler(this.kopeeriToolStripMenuItem_Click);
            // 
            // lõikaToolStripMenuItem
            // 
            this.lõikaToolStripMenuItem.Name = "lõikaToolStripMenuItem";
            this.lõikaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lõikaToolStripMenuItem.Text = "Lõika";
            this.lõikaToolStripMenuItem.Click += new System.EventHandler(this.lõikaToolStripMenuItem_Click);
            // 
            // kleebiToolStripMenuItem
            // 
            this.kleebiToolStripMenuItem.Name = "kleebiToolStripMenuItem";
            this.kleebiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kleebiToolStripMenuItem.Text = "Kleebi";
            this.kleebiToolStripMenuItem.Click += new System.EventHandler(this.kleebiToolStripMenuItem_Click);
            // 
            // valiKõikToolStripMenuItem
            // 
            this.valiKõikToolStripMenuItem.Name = "valiKõikToolStripMenuItem";
            this.valiKõikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.valiKõikToolStripMenuItem.Text = "Vali kõik";
            this.valiKõikToolStripMenuItem.Click += new System.EventHandler(this.valiKõikToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tagasiToolStripMenuItem
            // 
            this.tagasiToolStripMenuItem.Name = "tagasiToolStripMenuItem";
            this.tagasiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tagasiToolStripMenuItem.Text = "Võta tagasi";
            this.tagasiToolStripMenuItem.Click += new System.EventHandler(this.tagasiToolStripMenuItem_Click);
            // 
            // edasiToolStripMenuItem
            // 
            this.edasiToolStripMenuItem.Name = "edasiToolStripMenuItem";
            this.edasiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edasiToolStripMenuItem.Text = "Uuesti";
            this.edasiToolStripMenuItem.Click += new System.EventHandler(this.edasiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 517);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "AtsNote";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //vormid akna, tekstiakna, menüüriba ja nuppude kuvamiseks
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopeeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lõikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kleebiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valiKõikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tagasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edasiToolStripMenuItem;
    }
}

