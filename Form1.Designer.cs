namespace laptop_sarj_yuzdesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ram_kullanimi = new System.Diagnostics.PerformanceCounter();
            this.label_ram = new System.Windows.Forms.Label();
            this.label_islemci = new System.Windows.Forms.Label();
            this.islemci_kullanimi = new System.Diagnostics.PerformanceCounter();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ram_kullanimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemci_kullanimi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "sarj";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Charge Info";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programıGösterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.programıKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // programıGösterToolStripMenuItem
            // 
            this.programıGösterToolStripMenuItem.Name = "programıGösterToolStripMenuItem";
            this.programıGösterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.programıGösterToolStripMenuItem.Text = "Programı Göster";
            this.programıGösterToolStripMenuItem.Click += new System.EventHandler(this.programıGösterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Hakkımızda";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // ram_kullanimi
            // 
            this.ram_kullanimi.CategoryName = "Bellek";
            this.ram_kullanimi.CounterName = "Kullanılan Kaydedilmiş Bayt Yüzdesi";
            // 
            // label_ram
            // 
            this.label_ram.AutoSize = true;
            this.label_ram.BackColor = System.Drawing.Color.Transparent;
            this.label_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ram.Location = new System.Drawing.Point(2, 22);
            this.label_ram.Name = "label_ram";
            this.label_ram.Size = new System.Drawing.Size(37, 18);
            this.label_ram.TabIndex = 21;
            this.label_ram.Text = "ram";
            // 
            // label_islemci
            // 
            this.label_islemci.AutoSize = true;
            this.label_islemci.BackColor = System.Drawing.Color.Transparent;
            this.label_islemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_islemci.Location = new System.Drawing.Point(2, 40);
            this.label_islemci.Name = "label_islemci";
            this.label_islemci.Size = new System.Drawing.Size(105, 18);
            this.label_islemci.TabIndex = 22;
            this.label_islemci.Text = "label_islemci";
            // 
            // islemci_kullanimi
            // 
            this.islemci_kullanimi.CategoryName = "İşlemci";
            this.islemci_kullanimi.CounterName = "% İşlemci Zamanı";
            this.islemci_kullanimi.InstanceName = "_Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(130, 65);
            this.Controls.Add(this.label_islemci);
            this.Controls.Add(this.label_ram);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ram_kullanimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemci_kullanimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Diagnostics.PerformanceCounter ram_kullanimi;
        private System.Windows.Forms.Label label_ram;
        private System.Windows.Forms.Label label_islemci;
        private System.Diagnostics.PerformanceCounter islemci_kullanimi;

    }
}

