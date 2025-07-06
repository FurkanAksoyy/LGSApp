using System;
using System.Drawing;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class SplashForm : Form
    {
        private Timer timer;
        private int progress = 0;

        public SplashForm()
        {
            InitializeComponent();
            InitializeSplash();
        }

        private void InitializeSplash()
        {
            // Set up timer for progress
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Apply theme
            this.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress += 2;
            progressBar.Value = progress;

            // Update status text based on progress
            if (progress < 30)
                lblStatus.Text = "Initializing...";
            else if (progress < 60)
                lblStatus.Text = "Loading database...";
            else if (progress < 90)
                lblStatus.Text = "Preparing interface...";
            else
                lblStatus.Text = "Ready!";

            if (progress >= 100)
            {
                timer.Stop();
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Center the form (optional, since designer sets CenterScreen)
            this.CenterToScreen();
        }
    }
}