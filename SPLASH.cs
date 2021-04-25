using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altered
{
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void SPLASH_Shown(object sender, EventArgs e)
        {
            timer1 = new Timer
            {
                //Set time interval to 3 sec
                Interval = 3000
            };
            //Start the timer
            timer1.Start();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //After 3 sec stop the timer
            timer1.Stop();
            //Hide the splash screen
            Hide();
            //Display the mainform
            Form1 mf = new Form1();
            mf.FormClosed += (s, args) => Close();
            mf.Show();
        }

        private void SPLASH_Load(object sender, EventArgs e)
        {
            string year = DateTime.Today.ToString("yyyy");
            LblCopyright.Text = "Copyright \u00a9 Altered " + year + "\nVersion: " + Application.ProductVersion;
        }
    }
}
