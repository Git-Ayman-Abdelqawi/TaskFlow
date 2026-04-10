using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskFlow
{
    public partial class frmAddTask: Form
    {
        

       
        private clsTags _Manage;
        private Image _selectedImage;
        clsTags.stTaskData newTask = new clsTags.stTaskData();
        private String Tesx;
        String ResultDate;
        public frmAddTask(clsTags manage)
        {
            InitializeComponent();
            _Manage = manage;
        }
      

        private void label1_Paint(object sender, PaintEventArgs e)
        {
          //  clsAnimation.DrawBackground(e, this.ClientRectangle);
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {

            pictureBox1.Click += pictureBox_Click;
            pictureBox2.Click += pictureBox_Click;
            pictureBox3.Click += pictureBox_Click;
            pictureBox4.Click += pictureBox_Click;
            pictureBox5.Click += pictureBox_Click;
            pictureBox6.Click += pictureBox_Click;
            pictureBox7.Click += pictureBox_Click;
            pictureBox8.Click += pictureBox_Click;
            pictureBox9.Click += pictureBox_Click;
            pictureBox10.Click += pictureBox_Click;
            pictureBox11.Click += pictureBox_Click;
            pictureBox12.Click += pictureBox_Click;
            pictureBox23.Click += pictureBox_Click;
            pictureBox24.Click += pictureBox_Click;
            pictureBox25.Click += pictureBox_Click;
            pictureBox26.Click += pictureBox_Click;
            pictureBox27.Click += pictureBox_Click;
            pictureBox28.Click += pictureBox_Click;

            rbCustom.Checked = true;
            _date.Enabled = true;
            rbToday.Click += rbToday_Click;
            rbTomorrow.Click += rbToday_Click;
            rbCustom.Click += rbToday_Click;

            // نخلي Custom هو الافتراضي
          


        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;
            if (clickedPicture != null && clickedPicture.Image != null)
            {
                _selectedImage = clickedPicture.Image;
                MessageBox.Show("تم اختيار الصورة");
            }
        }
        private void frmAddTask_Paint(object sender, PaintEventArgs e)
        {
            clsAnimation.DrawBackground(e, this.ClientRectangle);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (_selectedImage == null)
            {
                MessageBox.Show("اختر صورة أولاً");
              
                return;
            }

            clsTags.stTaskData newTask = new clsTags.stTaskData
            {
                _IdTask = (short)(_Manage.Tasks.Count + 1),
                _TaskEntry = _txtName.Text,
                _Date = _date.Value.ToString("dddd - MMMM - yyyy",
    new System.Globalization.CultureInfo("ar-EG")),
                _TaskImage = _selectedImage,
                _TaskType = ResultDate,
                _TaskTgpe = _cbTask.Text
            };

            _Manage.AddTask(newTask);
            MessageBox.Show("تم إضافة المهمة!");
            this.Close();

        }
        private void _comTask_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbTdpe.Text= _cbTask.Text;
        }
        private void rbToday_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                if (rb.Name == "rbCustom")
                {
                    _date.Enabled = true;
                    ResultDate = "Custom";
                }
                else
                {
                    DateTime selectedDate = clsTags.GetDateByChoice(rb.Name);

                    // تأكد أن التاريخ داخل النطاق
                    if (selectedDate >= _date.MinDate && selectedDate <= _date.MaxDate)
                    {
                        _date.Value = selectedDate;
                    }
                    else
                    {
                        _date.Value = _date.MinDate;
                    }

                    _date.Enabled = false;
                    ResultDate = rb.Name;
                }
            }
        }

        private void _txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(_txtName.Text.Length >= 70 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Maximum length is 60 characters!", "Limit Exceeded", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      
    }
}
