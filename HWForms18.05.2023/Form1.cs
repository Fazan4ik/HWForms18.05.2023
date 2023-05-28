namespace HWForms18._05._2023
{
    public partial class Form1 : Form
    {
        private DateTime newYear;
        private DateTime endCourse;
        private DateTime birthday;


        public Form1()
        {
            InitializeComponent();
            int currentYear = DateTime.Today.Year;
            newYear = new DateTime(currentYear + 1, 1, 1);
            endCourse = new DateTime(currentYear, 6, 13);
            birthday = new DateTime(currentYear + 1, 3, 26);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTimeNY = newYear - DateTime.Now;
            TimeSpan remainingTimeDB = birthday - DateTime.Now;
            TimeSpan remainingTimeEndCourse = endCourse - DateTime.Now;
            label1.Text = string.Format("До нового року {0} днів, {1:D2}:{2:D2}:{3:D2}",
                remainingTimeNY.Days, remainingTimeNY.Hours, remainingTimeNY.Minutes, remainingTimeNY.Seconds);
            label2.Text = string.Format("До дня народження {0} днів, {1:D2}:{2:D2}:{3:D2}",
                remainingTimeDB.Days, remainingTimeDB.Hours, remainingTimeDB.Minutes, remainingTimeDB.Seconds);
            label3.Text = string.Format("До закінчення курсу {0} днів, {1:D2}:{2:D2}:{3:D2}",
                remainingTimeEndCourse.Days, remainingTimeEndCourse.Hours, remainingTimeEndCourse.Minutes, remainingTimeEndCourse.Seconds);
        }

    }
}