namespace TaskFlow
{
    partial class frmVacation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRemaining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaction Days Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date          :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "End date            :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of date :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(249, 53);
            this.monthCalendar1.MaxDate = new System.DateTime(2026, 12, 25, 23, 59, 59, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(319, 280);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(0, 44);
            this.lblStart.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(319, 396);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 44);
            this.lblResult.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(319, 338);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 44);
            this.lblEnd.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRemaining
            // 
            this.btnRemaining.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnRemaining.Location = new System.Drawing.Point(600, 173);
            this.btnRemaining.Name = "btnRemaining";
            this.btnRemaining.Size = new System.Drawing.Size(170, 56);
            this.btnRemaining.TabIndex = 11;
            this.btnRemaining.Text = "Remaining days";
            this.btnRemaining.UseVisualStyleBackColor = true;
            this.btnRemaining.Click += new System.EventHandler(this.btnRemaining_Click);
            // 
            // frmVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemaining);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVacation";
            this.Text = "frmVacation";
            this.Load += new System.EventHandler(this.frmVacation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmVacation_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRemaining;
    }
}