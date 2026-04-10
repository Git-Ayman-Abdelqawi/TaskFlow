using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public partial class frmVacation: Form
    {
        public frmVacation()
        {
            InitializeComponent();
        
        }

     

        private void frmVacation_Paint(object sender, PaintEventArgs e)
        {
            clsAnimation.DrawBackground(e, this.ClientRectangle);

        }

        DateTime startDate;
        DateTime endDate;
        bool Num = false;
        private int days = 0;
       private int remainingDays;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
            if(Num == false)
            {
                 startDate = e.Start;
                Num = true;
            }
            else
            {
                 endDate = e.End;
                Num = false;
            }

            lblStart.Text = $"Start date: {startDate.ToString("dd/MM/yyyy")}";
            lblEnd.Text = $"End date: {endDate.ToString("dd/MM/yyyy")}";

            TimeSpan diff = endDate - startDate;
             days = diff.Days + 1;

            lblResult.Text = $"Number of days: {days}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (remainingDays > 0)
            {
                remainingDays--;
                lblResult.Text = $"Remaining days: {remainingDays}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("الإجازة انتهت!");
            }
        }

        private void btnRemaining_Click(object sender, EventArgs e)
        {
            TimeSpan diff = endDate - startDate;
            remainingDays = diff.Days + 1;
            lblResult.Text = $"Remaining days : {remainingDays}";
            timer1.Interval = 1000;
            timer1.Start();
           
        }

        private void frmVacation_Load(object sender, EventArgs e)
        {

        }
    }
}
