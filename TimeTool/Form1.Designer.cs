namespace TimeTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.txtZeitpunkt = new System.Windows.Forms.TextBox();
            this.txtZeitAusgabe = new System.Windows.Forms.RichTextBox();
            this.BtnAusgabe = new System.Windows.Forms.Button();
            this.BtnLaden = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtKw = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(265, 31);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(500, 47);
            this.dTP1.TabIndex = 0;
            this.dTP1.ValueChanged += new System.EventHandler(this.dTP1_ValueChanged);
            // 
            // dTP2
            // 
            this.dTP2.CustomFormat = "HH:mm";
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(60, 114);
            this.dTP2.Name = "dTP2";
            this.dTP2.ShowUpDown = true;
            this.dTP2.Size = new System.Drawing.Size(170, 47);
            this.dTP2.TabIndex = 1;
            // 
            // txtZeitpunkt
            // 
            this.txtZeitpunkt.Location = new System.Drawing.Point(265, 114);
            this.txtZeitpunkt.Name = "txtZeitpunkt";
            this.txtZeitpunkt.Size = new System.Drawing.Size(500, 47);
            this.txtZeitpunkt.TabIndex = 2;
            this.txtZeitpunkt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZeitpunkt_KeyDown);
            // 
            // txtZeitAusgabe
            // 
            this.txtZeitAusgabe.Location = new System.Drawing.Point(62, 197);
            this.txtZeitAusgabe.Name = "txtZeitAusgabe";
            this.txtZeitAusgabe.Size = new System.Drawing.Size(703, 738);
            this.txtZeitAusgabe.TabIndex = 3;
            this.txtZeitAusgabe.Text = "";
            this.txtZeitAusgabe.TextChanged += new System.EventHandler(this.txtZeitAusgabe_TextChanged);
            // 
            // BtnAusgabe
            // 
            this.BtnAusgabe.Location = new System.Drawing.Point(69, 990);
            this.BtnAusgabe.Name = "BtnAusgabe";
            this.BtnAusgabe.Size = new System.Drawing.Size(188, 58);
            this.BtnAusgabe.TabIndex = 4;
            this.BtnAusgabe.Text = "Ausgabe";
            this.BtnAusgabe.UseVisualStyleBackColor = true;
            this.BtnAusgabe.Click += new System.EventHandler(this.BtnAusgabe_Click);
            // 
            // BtnLaden
            // 
            this.BtnLaden.Location = new System.Drawing.Point(335, 994);
            this.BtnLaden.Name = "BtnLaden";
            this.BtnLaden.Size = new System.Drawing.Size(188, 58);
            this.BtnLaden.TabIndex = 5;
            this.BtnLaden.Text = "Laden";
            this.BtnLaden.UseVisualStyleBackColor = true;
            this.BtnLaden.Click += new System.EventHandler(this.BtnLaden_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(580, 1005);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(188, 58);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Löschen";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualisierenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(266, 52);
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(265, 48);
            this.aktualisierenToolStripMenuItem.Text = "Aktualisieren";
            this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
            // 
            // txtKw
            // 
            this.txtKw.Location = new System.Drawing.Point(47, 33);
            this.txtKw.Name = "txtKw";
            this.txtKw.Size = new System.Drawing.Size(210, 47);
            this.txtKw.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 1181);
            this.Controls.Add(this.txtKw);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnLaden);
            this.Controls.Add(this.BtnAusgabe);
            this.Controls.Add(this.txtZeitAusgabe);
            this.Controls.Add(this.txtZeitpunkt);
            this.Controls.Add(this.dTP2);
            this.Controls.Add(this.dTP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dTP1;
        private DateTimePicker dTP2;
        private TextBox txtZeitpunkt;
        private RichTextBox txtZeitAusgabe;
        private Button BtnAusgabe;
        private Button BtnLaden;
        private Button BtnClear;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aktualisierenToolStripMenuItem;
        private TextBox txtKw;
    }
}