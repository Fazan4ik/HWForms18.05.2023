using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWForms18._05._2023
{
    public partial class Form2 : Form
    {
        private DateTime startTime;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            startTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            double totalMilliseconds = elapsedTime.TotalMilliseconds;
            int milliseconds = (int)Math.Floor(totalMilliseconds);
            this.Text = milliseconds + " ms";
        }
    }
}
