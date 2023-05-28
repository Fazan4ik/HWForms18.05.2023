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
    public partial class Form3 : Form
    {
        private Color[] colors = { Color.Black, Color.Red, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Pink, Color.White };
        private int currentIndex = 0;

        public Form3()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1000 миллисекунд = 1 секунда
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = colors[currentIndex];
            currentIndex++;
            if (currentIndex >= colors.Length)
            {
                currentIndex = 0;
            }
        }
    }
}
