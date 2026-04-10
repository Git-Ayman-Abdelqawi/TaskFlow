using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public class clsTags
    {
        // قائمة المهام
        public List<stTaskData> Tasks = new List<stTaskData>();

        // أنواع المهام
        public enum enTaskType
        {
            Today,
            Tomorrow,
            Custom
        }
        private Timer _Timer;
        private Label _Lable2;
       
        public struct stTaskData
        {
            public short _IdTask { get; set; }
            public string _TaskEntry { get; set; }
            public string _Date { get; set; }
            public string _TaskType { get; set; }
            public Image _TaskImage { get; set; }
            public string _TaskTgpe { get; set; }
        }

     
        public void AddTask(stTaskData task)
        {
            Tasks.Add(task);
        }

    
        public void DisplayTasks(FlowLayoutPanel flowLayoutPanel1)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var task in Tasks)
            {
                Panel taskPanel = CreateTaskPanel(flowLayoutPanel1.Width, task);
                flowLayoutPanel1.Controls.Add(taskPanel);
            }
        }

        private Panel CreateTaskPanel(int panelWidth, stTaskData task)
        {
            Panel taskPanel = new Panel
            {
                Width = panelWidth - 25,
                Height = 70,
                BackColor = Color.White,
                Margin = new Padding(5)
            };

            // صورة المهمة
            PictureBox pic = new PictureBox
            {
                Width = 40,
                Height = 40,
                Left = 5,
                Top = 5,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = task._TaskImage == null ? Color.DimGray : Color.DimGray,
                Image = task._TaskImage
            };

            // اسم المهمة
            Label lblEntry = CreateLabel(task._TaskEntry, 75, 5, true);

            // رقم المهمة
            Label lblId = CreateLabel("ID: " + task._IdTask, 75, 25);

            // التاريخ
            Label lblDate = CreateLabel(task._Date, 200, 25);

            // نوع المهمة (اليوم/غدًا/مخصص)
            Label lblType = CreateLabel(task._TaskType, 400, 25);

            // التصنيف (عمل/شخصي/منزلي...)
            Label lblType2 = CreateLabel(task._TaskTgpe, 500, 25);

            // إضافة العناصر للـ Panel
            taskPanel.Controls.Add(pic);
            taskPanel.Controls.Add(lblEntry);
            taskPanel.Controls.Add(lblId);
            taskPanel.Controls.Add(lblDate);
            taskPanel.Controls.Add(lblType);
            taskPanel.Controls.Add(lblType2);

            return taskPanel;
        }

        // دالة مساعدة لإنشاء Label
        private Label CreateLabel(string text, int left, int top, bool bold = false)
        {
            return new Label
            {
                Text = text,
                Left = left,
                Top = top,
                AutoSize = true,
                Font = bold ? new Font("Tahoma", 10, FontStyle.Bold) : new Font("Tahoma", 9, FontStyle.Regular)
            };
        }
      
        private void DisplayFilteredTasks(List<stTaskData> filteredTasks, FlowLayoutPanel flowLayoutPanel1)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (stTaskData st in filteredTasks)
            {
                Panel taskPanel = CreateTaskPanel(flowLayoutPanel1.Width, st);
                flowLayoutPanel1.Controls.Add(taskPanel);

            }
            if(filteredTasks.Count==0)
            {
                MessageBox.Show("مافيش مهمة بهذا الشرط");
            }
        }

      

        public List<stTaskData> GetFilteredTasks(string keyword)
        {
            keyword = keyword.Trim().ToLower();
            List<stTaskData> filteredTasks = new List<stTaskData>();

            foreach (stTaskData task in Tasks)
            {
                // البحث بالرقم
                if (int.TryParse(keyword, out int id) && task._IdTask == id)
                {
                    filteredTasks.Add(task);
                }
                // البحث بالاسم
                else if (!string.IsNullOrEmpty(task._TaskEntry) &&
                         task._TaskEntry.ToLower().Contains(keyword))
                {
                    filteredTasks.Add(task);
                }
                // البحث بالتصنيف (Work, Study, Home...)
                else if (!string.IsNullOrEmpty(task._TaskTgpe) &&
                         task._TaskTgpe.ToLower().Contains(keyword))
                {
                    filteredTasks.Add(task);
                }
                // البحث بالنوع (Today, Tomorrow, Custom)
                else if (!string.IsNullOrEmpty(task._TaskType) &&
                         task._TaskType.ToLower().Contains(keyword))
                {
                    filteredTasks.Add(task);
                }
            }

            return filteredTasks;
        }


        public void Search(string tx, FlowLayoutPanel flowLayoutPanel1)
        {
            List<stTaskData> filtered = GetFilteredTasks(tx);
            DisplayFilteredTasks(filtered, flowLayoutPanel1);
        }

        public void DeleteTask(int NumberId, FlowLayoutPanel flowLayoutPanel1)
        {
            var taskToRemove = Tasks.FirstOrDefault(t => t._IdTask == NumberId);

            // لو لقيتها
            if (!taskToRemove.Equals(default(stTaskData)))
            {
                Tasks.Remove(taskToRemove);

                // إعادة عرض المهام بعد الحذف
                DisplayTasks(flowLayoutPanel1);

                MessageBox.Show("تم حذف المهمة بنجاح");
            }
            else
            {
                MessageBox.Show("مافيش مهمة بهذا الرقم");
            }
        }
        public static string CalculateTopping(object sender)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                if (rb.Name == "rbTomorrow")
                    return "Tomorrow";
                else if (rb.Name == "rbToday")
                    return "Today";
                else if (rb.Name == "rbCustom")
                    return "Custom";
            }

            return string.Empty;
        }

        // إرجاع التاريخ حسب الاختيار
        public static DateTime GetDateByChoice(string choice)
        {
            if (choice == "Today")
                return DateTime.Today;

            if (choice == "Tomorrow")
                return DateTime.Today.AddDays(1);

            // لو Custom، نخلي المستخدم يختار بنفسه
            return DateTime.Today;
        }

       
    }
}
