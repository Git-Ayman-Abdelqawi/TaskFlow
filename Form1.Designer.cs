namespace TaskFlow
{
    partial class Form1
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
            this.MyTaskTagsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.txUser = new System.Windows.Forms.Label();
            this.pbImageUser = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbTask = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAddTask = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyTaskTagsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTaskTagsPanel
            // 
            this.MyTaskTagsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MyTaskTagsPanel.AutoScroll = true;
            this.MyTaskTagsPanel.BackColor = System.Drawing.Color.Transparent;
            this.MyTaskTagsPanel.Controls.Add(this.pictureBox3);
            this.MyTaskTagsPanel.Controls.Add(this.label2);
            this.MyTaskTagsPanel.Controls.Add(this.label3);
            this.MyTaskTagsPanel.Controls.Add(this.label5);
            this.MyTaskTagsPanel.Controls.Add(this.comboBox1);
            this.MyTaskTagsPanel.Controls.Add(this.groupBox2);
            this.MyTaskTagsPanel.Location = new System.Drawing.Point(-12, 1);
            this.MyTaskTagsPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MyTaskTagsPanel.Name = "MyTaskTagsPanel";
            this.MyTaskTagsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MyTaskTagsPanel.Size = new System.Drawing.Size(386, 592);
            this.MyTaskTagsPanel.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TaskFlow.Properties.Resources.TaskFlowIcon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(13, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Flow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simplifying Productivity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "You are searching by {choice}";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Task Category",
            "Task Name",
            "Task Type"});
            this.comboBox1.Location = new System.Drawing.Point(13, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch);
            this.groupBox2.Location = new System.Drawing.Point(13, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 369);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.Location = new System.Drawing.Point(-1, 73);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(158, 42);
            this.button10.TabIndex = 19;
            this.button10.Text = "Vacation";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txUser
            // 
            this.txUser.AutoSize = true;
            this.txUser.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUser.Location = new System.Drawing.Point(213, 0);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(195, 48);
            this.txUser.TabIndex = 19;
            this.txUser.Text = "Parsonal";
            // 
            // pbImageUser
            // 
            this.pbImageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImageUser.Location = new System.Drawing.Point(221, 41);
            this.pbImageUser.Name = "pbImageUser";
            this.pbImageUser.Size = new System.Drawing.Size(117, 64);
            this.pbImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageUser.TabIndex = 18;
            this.pbImageUser.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(384, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(234, 115);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 30);
            this.txtSearch.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(367, 252);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 328);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txUser);
            this.groupBox1.Controls.Add(this._cbTask);
            this.groupBox1.Controls.Add(this.pbImageUser);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.labelAddTask);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(367, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 259);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "This is the user account";
            // 
            // _cbTask
            // 
            this._cbTask.FormattingEnabled = true;
            this._cbTask.Items.AddRange(new object[] {
            " Home",
            "Work",
            "Study",
            "Health",
            "Finace",
            "Shopping",
            "Personal",
            "Projects",
            "Other"});
            this._cbTask.Location = new System.Drawing.Point(220, -34);
            this._cbTask.Name = "_cbTask";
            this._cbTask.Size = new System.Drawing.Size(121, 30);
            this._cbTask.TabIndex = 15;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::TaskFlow.Properties.Resources.SearchIcon;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(610, 106);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 49);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(512, 69);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(92, 22);
            this.txEmail.TabIndex = 14;
            this.txEmail.Text = "Today Is :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Today Is :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(538, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::TaskFlow.Properties.Resources.SettingBtn;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(295, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(83, 66);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAddTask
            // 
            this.labelAddTask.AutoSize = true;
            this.labelAddTask.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTask.Location = new System.Drawing.Point(6, 171);
            this.labelAddTask.Name = "labelAddTask";
            this.labelAddTask.Size = new System.Drawing.Size(263, 40);
            this.labelAddTask.TabIndex = 9;
            this.labelAddTask.Text = "Add  New Task";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TaskFlow.Properties.Resources.TaskBackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1121, 592);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MyTaskTagsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = " TaskFlow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MyTaskTagsPanel.ResumeLayout(false);
            this.MyTaskTagsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel MyTaskTagsPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAddTask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbTask;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txUser;
        private System.Windows.Forms.PictureBox pbImageUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

