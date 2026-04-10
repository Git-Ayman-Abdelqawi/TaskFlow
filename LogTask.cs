using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskFlow
{
   public class LogTask
    {
        public List<stTask> _Task2 = new List<stTask>();
        public struct stTask
        {
            public String _Name { get; set; }
            public String _Password { get; set; }
            public Image _ImTask { get; set; }
            public String _Date1 { get; set; }
            public String _Email { get; set; }
        }


        public void AddTask(stTask task1)
        {
            _Task2.Add(task1);
        }
        public void LogOut(TextBox txName, TextBox txBassword, LogTask.stTask Users, TextBox Email)
        {
            if (txName.Text == txName.Tag.ToString() && txBassword.Text == txBassword.Tag.ToString() &&
                Email.Text== Email.Tag.ToString())
            {
                Form fr = new Form1(Users);
                fr.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Worning", "Erroor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

         public void StartProgressBar(ProgressBar prog,Label LblPro)
        {
            prog.Value = 0;
            prog.Maximum = 100;
            prog.Minimum = 00;

            prog.Visible = true;
            for (int i=0;i<10;i++)
            {
                Thread.Sleep(500);
                if(prog.Value < prog.Maximum)
                {
                    prog.Value += 10;
                    LblPro.Text = (((float)prog.Value / prog.Maximum) * 100) + "%";
                    prog.Refresh();
                    LblPro.Refresh();
                }
            }
        }
    }
}
