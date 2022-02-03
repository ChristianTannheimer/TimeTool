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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.txtZeitpunkt = new System.Windows.Forms.TextBox();
            this.txtZeitAusgabe = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ausgabeÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAusgabe = new System.Windows.Forms.Button();
            this.BtnLaden = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtKw = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTP1
            // 
            this.dTP1.ContextMenuStrip = this.contextMenuStrip1;
            this.dTP1.Location = new System.Drawing.Point(189, 12);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(576, 47);
            this.dTP1.TabIndex = 0;
            this.dTP1.ValueChanged += new System.EventHandler(this.dTP1_ValueChanged);
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
            // dTP2
            // 
            this.dTP2.ContextMenuStrip = this.contextMenuStrip1;
            this.dTP2.CustomFormat = "HH:mm";
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(12, 76);
            this.dTP2.Name = "dTP2";
            this.dTP2.ShowUpDown = true;
            this.dTP2.Size = new System.Drawing.Size(171, 47);
            this.dTP2.TabIndex = 1;
            // 
            // txtZeitpunkt
            // 
            this.txtZeitpunkt.Location = new System.Drawing.Point(189, 76);
            this.txtZeitpunkt.Name = "txtZeitpunkt";
            this.txtZeitpunkt.Size = new System.Drawing.Size(576, 47);
            this.txtZeitpunkt.TabIndex = 2;
            this.txtZeitpunkt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZeitpunkt_KeyDown);
            // 
            // txtZeitAusgabe
            // 
            this.txtZeitAusgabe.ContextMenuStrip = this.contextMenuStrip2;
            this.txtZeitAusgabe.Location = new System.Drawing.Point(12, 131);
            this.txtZeitAusgabe.Name = "txtZeitAusgabe";
            this.txtZeitAusgabe.Size = new System.Drawing.Size(753, 738);
            this.txtZeitAusgabe.TabIndex = 3;
            this.txtZeitAusgabe.Text = "";
            this.txtZeitAusgabe.TextChanged += new System.EventHandler(this.txtZeitAusgabe_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausgabeÖffnenToolStripMenuItem,
            this.backupÖffnenToolStripMenuItem,
            this.ordnerÖffnenToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(307, 148);
            // 
            // ausgabeÖffnenToolStripMenuItem
            // 
            this.ausgabeÖffnenToolStripMenuItem.Name = "ausgabeÖffnenToolStripMenuItem";
            this.ausgabeÖffnenToolStripMenuItem.Size = new System.Drawing.Size(306, 48);
            this.ausgabeÖffnenToolStripMenuItem.Text = "Ausgabe öffnen";
            this.ausgabeÖffnenToolStripMenuItem.Click += new System.EventHandler(this.ausgabeÖffnenToolStripMenuItem_Click);
            // 
            // backupÖffnenToolStripMenuItem
            // 
            this.backupÖffnenToolStripMenuItem.Name = "backupÖffnenToolStripMenuItem";
            this.backupÖffnenToolStripMenuItem.Size = new System.Drawing.Size(306, 48);
            this.backupÖffnenToolStripMenuItem.Text = "Backup öffnen";
            this.backupÖffnenToolStripMenuItem.Click += new System.EventHandler(this.backupÖffnenToolStripMenuItem_Click);
            // 
            // ordnerÖffnenToolStripMenuItem
            // 
            this.ordnerÖffnenToolStripMenuItem.Name = "ordnerÖffnenToolStripMenuItem";
            this.ordnerÖffnenToolStripMenuItem.Size = new System.Drawing.Size(306, 48);
            this.ordnerÖffnenToolStripMenuItem.Text = "Ordner öffnen";
            this.ordnerÖffnenToolStripMenuItem.Click += new System.EventHandler(this.ordnerÖffnenToolStripMenuItem_Click);
            // 
            // BtnAusgabe
            // 
            this.BtnAusgabe.Location = new System.Drawing.Point(12, 875);
            this.BtnAusgabe.Name = "BtnAusgabe";
            this.BtnAusgabe.Size = new System.Drawing.Size(246, 58);
            this.BtnAusgabe.TabIndex = 4;
            this.BtnAusgabe.Text = "Speichern";
            this.BtnAusgabe.UseVisualStyleBackColor = true;
            this.BtnAusgabe.Click += new System.EventHandler(this.BtnAusgabe_Click);
            // 
            // BtnLaden
            // 
            this.BtnLaden.Location = new System.Drawing.Point(264, 875);
            this.BtnLaden.Name = "BtnLaden";
            this.BtnLaden.Size = new System.Drawing.Size(243, 58);
            this.BtnLaden.TabIndex = 5;
            this.BtnLaden.Text = "Laden";
            this.BtnLaden.UseVisualStyleBackColor = true;
            this.BtnLaden.Click += new System.EventHandler(this.BtnLaden_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(513, 875);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(250, 58);
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
            // txtKw
            // 
            this.txtKw.ContextMenuStrip = this.contextMenuStrip1;
            this.txtKw.Location = new System.Drawing.Point(12, 12);
            this.txtKw.Name = "txtKw";
            this.txtKw.ReadOnly = true;
            this.txtKw.Size = new System.Drawing.Size(171, 47);
            this.txtKw.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 940);
            this.Controls.Add(this.txtKw);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnLaden);
            this.Controls.Add(this.BtnAusgabe);
            this.Controls.Add(this.txtZeitAusgabe);
            this.Controls.Add(this.txtZeitpunkt);
            this.Controls.Add(this.dTP2);
            this.Controls.Add(this.dTP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TimeTool";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem ausgabeÖffnenToolStripMenuItem;
        private ToolStripMenuItem backupÖffnenToolStripMenuItem;
        private ToolStripMenuItem ordnerÖffnenToolStripMenuItem;
    }
}