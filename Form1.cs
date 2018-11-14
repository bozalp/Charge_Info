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
         class BatteryState
        {
            public float Percent { get; set; }
            public float Remaining { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            this.ShowInTaskbar = false;

            BatteryState batarya = new BatteryState();
            batarya.Percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            label1.Text = "% "+batarya.Percent.ToString();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(60, 20);
            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            BatteryState batarya = new BatteryState();
            batarya.Percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            label1.Text = "% " + batarya.Percent.ToString();
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
        }

        private void programıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(60, 20);
            this.Show();
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
