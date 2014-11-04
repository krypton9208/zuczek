namespace ZuczekV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.OtwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.WyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Location = new System.Drawing.Point(-238, 278);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(1390, 20);
            this.TextBox1.TabIndex = 4;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(914, 25);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtwórzToolStripMenuItem,
            this.ZapiszToolStripMenuItem,
            this.ZapiszJakoToolStripMenuItem,
            this.ToolStripSeparator1,
            this.WyjdźToolStripMenuItem});
            this.ToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButton1.Image")));
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(39, 22);
            this.ToolStripDropDownButton1.Text = "Plik";
            // 
            // OtwórzToolStripMenuItem
            // 
            this.OtwórzToolStripMenuItem.Name = "OtwórzToolStripMenuItem";
            this.OtwórzToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.OtwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // ZapiszToolStripMenuItem
            // 
            this.ZapiszToolStripMenuItem.Name = "ZapiszToolStripMenuItem";
            this.ZapiszToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ZapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // ZapiszJakoToolStripMenuItem
            // 
            this.ZapiszJakoToolStripMenuItem.Name = "ZapiszJakoToolStripMenuItem";
            this.ZapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ZapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // WyjdźToolStripMenuItem
            // 
            this.WyjdźToolStripMenuItem.Name = "WyjdźToolStripMenuItem";
            this.WyjdźToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.WyjdźToolStripMenuItem.Text = "Wyjdź";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.Location = new System.Drawing.Point(0, 146);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(914, 107);
            this.RichTextBox1.TabIndex = 5;
            this.RichTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(0, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(914, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 275);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.RichTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Żuczek Chodziasz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem OtwórzToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ZapiszToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ZapiszJakoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem WyjdźToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.TextBox textBox2;
    }
}

