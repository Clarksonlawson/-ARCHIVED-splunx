using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Loading : Form
    {
        private Timer timer;
        private string fullText = "Splunx";
        private int currentIndex = 0;

        public Loading()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 800; // Update text every 200 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Assuming the existing label is named splunxLabel
            if (label1 != null)
            {
                if (currentIndex < fullText.Length)
                {
                    
                    label1.Text += fullText[currentIndex];
                    
                    currentIndex++;
                }
                else
                {
                    label1.ForeColor = Color.Lime;
                    timer.Stop(); // Stop the timer when the full text has been displayed
                }
            }
        }
    }
}
