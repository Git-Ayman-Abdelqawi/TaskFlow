using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static TaskFlow.clsTags;

namespace TaskFlow
{
    public partial class Form1: Form
    {
        public Form1(LogTask.stTask task)
        {
            InitializeComponent();
           
            txUser.Text = task._Name;
            pbImageUser.Image = task._ImTask;
            label1.Text = task._Date1;
            txEmail.Text = task._Email;


        }


        private void Form1_Load(object sender, EventArgs e)
        {

          
            button10.BackColor = Color.DodgerBlue;
            comboBox1.SelectedIndex = 0;
          
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            using (var brush = new LinearGradientBrush(
       ClientRectangle,
       Color.MidnightBlue,
       Color.Black,     
       LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmSwttings();
            frm.Show();
        }

     

        private clsTags _Manage = new clsTags();
        private void btnAllTask_Click(object sender, EventArgs e)
        {
            _Manage.DisplayTasks(flowLayoutPanel1);
            flowLayoutPanel1.BackColor = Color.Black;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label6.Text= "ID : ";
                    break;
                case 1:
                    label6.Text = "Task Category : ";
                    break;
                case 2:
                    label6.Text = "Task Name : ";
                    break;
                case 3:
                    label6.Text = "Task Type : ";
                    break;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String Keyte = txtSearch.Text;

            _Manage.Search(Keyte, flowLayoutPanel1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form fr = new frmVacation();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtSearch.Text, out id))
            {
              
                _Manage.DeleteTask(id, flowLayoutPanel1);
            }
            else
            {
                MessageBox.Show("أدخل رقم صحيح");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frmAddTask addForm = new frmAddTask(_Manage); 
            addForm.ShowDialog();

            _Manage.DisplayTasks(flowLayoutPanel1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
