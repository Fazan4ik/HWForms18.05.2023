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
    public partial class Form4 : Form
    {
        private int clickCount = 0;
        private int maxClickCount = 0;
        private bool gameStarted = false;
        private System.Windows.Forms.Timer timer;

        public Form4()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000; 
            timer.Tick += Timer_Tick;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                clickCount++;
                labelCount.Text = $"Кількість кликів: {clickCount}";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            gameStarted = true; 
            buttonStart.Enabled = false; 
            button.Enabled = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show($"Час вичерпано!: {clickCount}. Максимальний рекорд: {maxClickCount}");
            if (clickCount > maxClickCount)
            {
                maxClickCount = clickCount;
            }
            clickCount = 0;
            labelCount.Text = $"Кількість кликів: {clickCount}";
            buttonStart.Enabled = true; 
            button.Enabled = false;
        }
    }
}
