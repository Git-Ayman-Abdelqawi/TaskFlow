using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Threading;

namespace TaskFlow
{
    public partial class frmSwttings : Form

    {
        private LogTask Task;
        private Image _selectedImage1;
        private bool N = true;
        public frmSwttings(LogTask Task)
        {
            InitializeComponent();
            this.Task = Task;

        }
        public frmSwttings()
        {
            InitializeComponent();
            Task = new LogTask();

        }


        private void frmSwttings_Paint(object sender, PaintEventArgs e)
        {

            ///////// Gradient Background  //////////////////////

            clsAnimation.DrawBackground(e, this.ClientRectangle);

            ///////// Add Method Example  //////////////////////

            clsAnimation.DrawRoundedRectangle(e, this.ClientRectangle);


        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedImage1 == null)
            {
                MessageBox.Show("اختر صورة أولاً");

                return;
            }

            LogTask.stTask newTask = new LogTask.stTask
            {
                _Name = txName.Text,
                _Password = txBassword.Text,
                _ImTask = _selectedImage1,
                _Date1 = dateTimePicker1.Value.ToString("dddd - MMMM - yyyy",
    new System.Globalization.CultureInfo("ar-EG")),
                _Email = txEmail.Text,


            };

            Task.AddTask(newTask);

            Task.StartProgressBar(progressBar1, lblPro);

            Task.LogOut(txName, txBassword, newTask, txEmail);
            this.Close();


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;
            if (clickedPicture != null && clickedPicture.Image != null)
            {
                _selectedImage1 = clickedPicture.Image;
                MessageBox.Show("تم اختيار الصورة");
            }
        }
       
        private void pictureBox21_Click(object sender, EventArgs e)
        {


            if (N == true)
            {
                txBassword.PasswordChar = '*';
                N = false;
            }
            else
            {
                txBassword.PasswordChar = '\0';

                N = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txName.Text = "";
            txBassword.Text = "";
            txEmail.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = clsAnimation.GetClockText();
        }

       
    }
}
