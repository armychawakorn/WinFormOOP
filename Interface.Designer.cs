namespace WinFormOOP
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_BirthDay = new System.Windows.Forms.Label();
            this.input_BirthYear = new System.Windows.Forms.TextBox();
            this.label_GPA = new System.Windows.Forms.Label();
            this.input_GPA = new System.Windows.Forms.TextBox();
            this.Info_Panel = new System.Windows.Forms.Panel();
            this.visible_gpa = new System.Windows.Forms.Label();
            this.visible_name = new System.Windows.Forms.Label();
            this.Course_List = new System.Windows.Forms.ListBox();
            this.label_Course = new System.Windows.Forms.Label();
            this.textBox_NameGPAMIN = new System.Windows.Forms.TextBox();
            this.label_Name2 = new System.Windows.Forms.Label();
            this.textBox_NameGPAMAX = new System.Windows.Forms.TextBox();
            this.label_Name1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SumAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Avg_GPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Min_GPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Max_GPA = new System.Windows.Forms.TextBox();
            this.label_max_gpa = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.Info_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_Name
            // 
            this.input_Name.Location = new System.Drawing.Point(68, 43);
            this.input_Name.Name = "input_Name";
            this.input_Name.Size = new System.Drawing.Size(164, 27);
            this.input_Name.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(36, 46);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(26, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "ชื่อ";
            // 
            // label_BirthDay
            // 
            this.label_BirthDay.AutoSize = true;
            this.label_BirthDay.Location = new System.Drawing.Point(22, 79);
            this.label_BirthDay.Name = "label_BirthDay";
            this.label_BirthDay.Size = new System.Drawing.Size(40, 20);
            this.label_BirthDay.TabIndex = 3;
            this.label_BirthDay.Text = "ปีเกิด";
            // 
            // input_BirthYear
            // 
            this.input_BirthYear.Location = new System.Drawing.Point(68, 76);
            this.input_BirthYear.Name = "input_BirthYear";
            this.input_BirthYear.Size = new System.Drawing.Size(164, 27);
            this.input_BirthYear.TabIndex = 2;
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Location = new System.Drawing.Point(25, 112);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Size = new System.Drawing.Size(37, 20);
            this.label_GPA.TabIndex = 5;
            this.label_GPA.Text = "เกรด";
            // 
            // input_GPA
            // 
            this.input_GPA.Location = new System.Drawing.Point(68, 109);
            this.input_GPA.Name = "input_GPA";
            this.input_GPA.Size = new System.Drawing.Size(164, 27);
            this.input_GPA.TabIndex = 4;
            // 
            // Info_Panel
            // 
            this.Info_Panel.AutoSize = true;
            this.Info_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info_Panel.Controls.Add(this.visible_gpa);
            this.Info_Panel.Controls.Add(this.visible_name);
            this.Info_Panel.Controls.Add(this.Course_List);
            this.Info_Panel.Controls.Add(this.label_Course);
            this.Info_Panel.Controls.Add(this.textBox_NameGPAMIN);
            this.Info_Panel.Controls.Add(this.label_Name2);
            this.Info_Panel.Controls.Add(this.textBox_NameGPAMAX);
            this.Info_Panel.Controls.Add(this.label_Name1);
            this.Info_Panel.Controls.Add(this.label4);
            this.Info_Panel.Controls.Add(this.textBox_SumAge);
            this.Info_Panel.Controls.Add(this.label3);
            this.Info_Panel.Controls.Add(this.textBox_Avg_GPA);
            this.Info_Panel.Controls.Add(this.label2);
            this.Info_Panel.Controls.Add(this.textBox_Min_GPA);
            this.Info_Panel.Controls.Add(this.label1);
            this.Info_Panel.Controls.Add(this.textBox_Max_GPA);
            this.Info_Panel.Controls.Add(this.label_max_gpa);
            this.Info_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Info_Panel.Location = new System.Drawing.Point(316, 0);
            this.Info_Panel.Name = "Info_Panel";
            this.Info_Panel.Size = new System.Drawing.Size(496, 383);
            this.Info_Panel.TabIndex = 6;
            // 
            // visible_gpa
            // 
            this.visible_gpa.AutoSize = true;
            this.visible_gpa.Location = new System.Drawing.Point(273, 202);
            this.visible_gpa.Name = "visible_gpa";
            this.visible_gpa.Size = new System.Drawing.Size(0, 20);
            this.visible_gpa.TabIndex = 16;
            // 
            // visible_name
            // 
            this.visible_name.AutoSize = true;
            this.visible_name.Location = new System.Drawing.Point(273, 182);
            this.visible_name.Name = "visible_name";
            this.visible_name.Size = new System.Drawing.Size(0, 20);
            this.visible_name.TabIndex = 15;
            // 
            // Course_List
            // 
            this.Course_List.FormattingEnabled = true;
            this.Course_List.ItemHeight = 20;
            this.Course_List.Location = new System.Drawing.Point(102, 182);
            this.Course_List.Name = "Course_List";
            this.Course_List.Size = new System.Drawing.Size(165, 184);
            this.Course_List.TabIndex = 14;
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(31, 8);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(86, 20);
            this.label_Course.TabIndex = 0;
            this.label_Course.Text = "ข้อมูลรายวิชา";
            // 
            // textBox_NameGPAMIN
            // 
            this.textBox_NameGPAMIN.Location = new System.Drawing.Point(326, 77);
            this.textBox_NameGPAMIN.Name = "textBox_NameGPAMIN";
            this.textBox_NameGPAMIN.ReadOnly = true;
            this.textBox_NameGPAMIN.Size = new System.Drawing.Size(165, 27);
            this.textBox_NameGPAMIN.TabIndex = 13;
            // 
            // label_Name2
            // 
            this.label_Name2.AutoSize = true;
            this.label_Name2.Location = new System.Drawing.Point(294, 81);
            this.label_Name2.Name = "label_Name2";
            this.label_Name2.Size = new System.Drawing.Size(26, 20);
            this.label_Name2.TabIndex = 12;
            this.label_Name2.Text = "ชื่อ";
            // 
            // textBox_NameGPAMAX
            // 
            this.textBox_NameGPAMAX.Location = new System.Drawing.Point(326, 44);
            this.textBox_NameGPAMAX.Name = "textBox_NameGPAMAX";
            this.textBox_NameGPAMAX.ReadOnly = true;
            this.textBox_NameGPAMAX.Size = new System.Drawing.Size(165, 27);
            this.textBox_NameGPAMAX.TabIndex = 11;
            // 
            // label_Name1
            // 
            this.label_Name1.AutoSize = true;
            this.label_Name1.Location = new System.Drawing.Point(294, 48);
            this.label_Name1.Name = "label_Name1";
            this.label_Name1.Size = new System.Drawing.Size(26, 20);
            this.label_Name1.TabIndex = 10;
            this.label_Name1.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "รายชื่อรวม";
            // 
            // textBox_SumAge
            // 
            this.textBox_SumAge.Location = new System.Drawing.Point(102, 140);
            this.textBox_SumAge.Name = "textBox_SumAge";
            this.textBox_SumAge.ReadOnly = true;
            this.textBox_SumAge.Size = new System.Drawing.Size(165, 27);
            this.textBox_SumAge.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "อายุรวม";
            // 
            // textBox_Avg_GPA
            // 
            this.textBox_Avg_GPA.Location = new System.Drawing.Point(102, 107);
            this.textBox_Avg_GPA.Name = "textBox_Avg_GPA";
            this.textBox_Avg_GPA.ReadOnly = true;
            this.textBox_Avg_GPA.Size = new System.Drawing.Size(165, 27);
            this.textBox_Avg_GPA.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPA Avg";
            // 
            // textBox_Min_GPA
            // 
            this.textBox_Min_GPA.Location = new System.Drawing.Point(102, 74);
            this.textBox_Min_GPA.Name = "textBox_Min_GPA";
            this.textBox_Min_GPA.ReadOnly = true;
            this.textBox_Min_GPA.Size = new System.Drawing.Size(165, 27);
            this.textBox_Min_GPA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA Min";
            // 
            // textBox_Max_GPA
            // 
            this.textBox_Max_GPA.Location = new System.Drawing.Point(102, 41);
            this.textBox_Max_GPA.Name = "textBox_Max_GPA";
            this.textBox_Max_GPA.ReadOnly = true;
            this.textBox_Max_GPA.Size = new System.Drawing.Size(165, 27);
            this.textBox_Max_GPA.TabIndex = 1;
            // 
            // label_max_gpa
            // 
            this.label_max_gpa.AutoSize = true;
            this.label_max_gpa.Location = new System.Drawing.Point(28, 44);
            this.label_max_gpa.Name = "label_max_gpa";
            this.label_max_gpa.Size = new System.Drawing.Size(68, 20);
            this.label_max_gpa.TabIndex = 0;
            this.label_max_gpa.Text = "GPA Max";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(87, 156);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(94, 29);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "button1";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 383);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.Info_Panel);
            this.Controls.Add(this.label_GPA);
            this.Controls.Add(this.input_GPA);
            this.Controls.Add(this.label_BirthDay);
            this.Controls.Add(this.input_BirthYear);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.input_Name);
            this.MaximumSize = new System.Drawing.Size(830, 430);
            this.MinimumSize = new System.Drawing.Size(830, 430);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Info_Panel.ResumeLayout(false);
            this.Info_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_Name;
        private Label label_Name;
        private Label label_BirthDay;
        private TextBox input_BirthYear;
        private Label label_GPA;
        private TextBox input_GPA;
        private Panel Info_Panel;
        private ListBox Course_List;
        private Label label_Course;
        private TextBox textBox_NameGPAMIN;
        private Label label_Name2;
        private TextBox textBox_NameGPAMAX;
        private Label label_Name1;
        private Label label4;
        private TextBox textBox_SumAge;
        private Label label3;
        private TextBox textBox_Avg_GPA;
        private Label label2;
        private TextBox textBox_Min_GPA;
        private Label label1;
        private TextBox textBox_Max_GPA;
        private Label label_max_gpa;
        private Button button_Add;
        private Label visible_gpa;
        private Label visible_name;
    }
}