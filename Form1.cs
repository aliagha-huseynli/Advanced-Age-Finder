using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yasimi_bul
{
    public partial class AgeFinder : Form
    {
        public AgeFinder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtBirth = dtBirthDate.Value;
            DateTime dtNow = DateTime.Now;
            int age = dtNow.Year - dtBirth.Year;
            txtAge.Text = age.ToString();
            txtTopDays.Text = (dtNow - dtBirth).TotalDays.ToString();
            txtTopHours.Text = (dtNow - dtBirth).TotalHours.ToString();
            txtTopMins.Text = (dtNow - dtBirth).TotalMinutes.ToString();
            txtTopSecs.Text = (dtNow - dtBirth).TotalSeconds.ToString();
            timeLife.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtBirth = dtBirthDate.Value;
            DateTime dtNow = DateTime.Now;
            int age = dtNow.Year - dtBirth.Year;
            txtAge.Text = age.ToString();
            txtTopDays.Text = (dtNow - dtBirth).TotalDays.ToString("#,###");
            txtTopHours.Text = (dtNow - dtBirth).TotalHours.ToString("#,###");
            txtTopMins.Text = (dtNow - dtBirth).TotalMinutes.ToString("#,###");
            txtTopSecs.Text = (dtNow - dtBirth).TotalSeconds.ToString("#,###");
        }
    }
}
