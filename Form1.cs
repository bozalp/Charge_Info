using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace laptop_sarj_yuzdesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dragging;
        Point offset;
        float ramYuzde, cpuYuzde;
        
        /*class PilDurumu
        {

            private float BataryaDurum;

            public float BATARYADURUM
            {

                get { return BataryaDurum; }

                set { BataryaDurum = value; }

            }

            /*private int BataryaSaati;

            public int BATARYASAATI
            {

                get { return BataryaSaati; }

                set { BataryaSaati = value; }

            }

        }*/
         class BatteryState
        {
            public float Percent { get; set; }
            public float Remaining { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
           /* this.TransparencyKey = Color.Red;
            this.BackColor = Color.Red;*/
            Timer timer = new Timer();
            timer.Interval = (10 * 100); // 1 secs
            //timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            this.ShowInTaskbar = false;

            BatteryState batarya = new BatteryState();
            batarya.Percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            label1.Text = "Charge : % " + batarya.Percent.ToString();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            //this.Size = new Size(60, 20);
            this.Size = new Size(130, 65);
            //int pil = Convert.ToInt32((label1.Text));
            if (batarya.Percent < 25) 
            {
                this.BackColor = Color.FromArgb(200, 0, 0);
            }
            else if (batarya.Percent < 50)
            {
                this.BackColor = Color.FromArgb(230, 130, 0);
            }
            else if (batarya.Percent < 75)
            {
                this.BackColor = Color.FromArgb(75, 150, 0);
            }
            else if (batarya.Percent <= 100)
            {
                //this.BackColor = Color.FromArgb(0, 255, 0);
            }
            this.BackColor = Color.Gray;
            TransparencyKey = Color.Gray;


            ramYuzde = ram_kullanimi.NextValue();

            label_ram.Text = "Ram : % " + ramYuzde.ToString("N2");

            cpuYuzde = islemci_kullanimi.NextValue();

            label_islemci.Text = "CPU : % " + cpuYuzde.ToString("N2");
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BatteryState batarya = new BatteryState();
            batarya.Percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            label1.Text = "Charge : % " + batarya.Percent.ToString();
            if (batarya.Percent < 25)
            {
                this.BackColor = Color.FromArgb(200, 0, 0);
            }
            else if (batarya.Percent < 50)
            {
                this.BackColor = Color.FromArgb(230, 130, 0);
            }
            else if (batarya.Percent < 75)
            {
                this.BackColor = Color.FromArgb(75, 150, 0);
            }
            else if (batarya.Percent < 100)
            {
                this.BackColor = Color.FromArgb(0, 255, 0);
            }
            ramYuzde = ram_kullanimi.NextValue();

            label_ram.Text = "Ram : % " + ramYuzde.ToString("N2");

            cpuYuzde = islemci_kullanimi.NextValue();

            label_islemci.Text = "CPU : % " + cpuYuzde.ToString("N2");

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           /* if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.Show();
            }*/
        }

        private void programıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(130, 65);
            this.Show();
            //notifyIcon1.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hakkimizda h = new hakkimizda();
            h.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kapatmak istediğinize emin misin?","Program Kapatılacak",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(secenek==DialogResult.No)
            {

            }
        }
    }
}
