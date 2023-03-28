namespace Lab4_Encapsulatiom
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbBirthYear = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            tbListofPerson = new TextBox();
            label4 = new Label();
            tbTotal = new TextBox();
            tbGrade = new TextBox();
            label5 = new Label();
            tbAvg = new TextBox();
            tbMin = new TextBox();
            tbMax = new TextBox();
            tbNameMax = new TextBox();
            tbNameMin = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 73);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "ปีเกิด";
            // 
            // tbName
            // 
            tbName.Location = new Point(86, 41);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 2;
            // 
            // tbBirthYear
            // 
            tbBirthYear.Location = new Point(86, 70);
            tbBirthYear.Name = "tbBirthYear";
            tbBirthYear.Size = new Size(100, 23);
            tbBirthYear.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 180);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "รายชื่อ";
            // 
            // tbListofPerson
            // 
            tbListofPerson.Location = new Point(266, 177);
            tbListofPerson.Multiline = true;
            tbListofPerson.Name = "tbListofPerson";
            tbListofPerson.Size = new Size(100, 72);
            tbListofPerson.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 151);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "อายุรวม";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(266, 148);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 8;
            tbTotal.Text = "0";
            // 
            // tbGrade
            // 
            tbGrade.Location = new Point(86, 99);
            tbGrade.Name = "tbGrade";
            tbGrade.Size = new Size(100, 23);
            tbGrade.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 102);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "GPA";
            // 
            // tbAvg
            // 
            tbAvg.Location = new Point(266, 119);
            tbAvg.Name = "tbAvg";
            tbAvg.Size = new Size(100, 23);
            tbAvg.TabIndex = 11;
            // 
            // tbMin
            // 
            tbMin.Location = new Point(266, 90);
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(100, 23);
            tbMin.TabIndex = 12;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(266, 61);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(100, 23);
            tbMax.TabIndex = 13;
            // 
            // tbNameMax
            // 
            tbNameMax.Location = new Point(201, 44);
            tbNameMax.Name = "tbNameMax";
            tbNameMax.Size = new Size(108, 23);
            tbNameMax.TabIndex = 14;
            // 
            // tbNameMin
            // 
            tbNameMin.Location = new Point(201, 102);
            tbNameMin.Name = "tbNameMin";
            tbNameMin.Size = new Size(107, 23);
            tbNameMin.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 122);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 16;
            label6.Text = "GPA Avg";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 93);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 17;
            label8.Text = "GPA MIN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 64);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 18;
            label9.Text = "GPA MAX";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(201, 78);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 19;
            label11.Text = "ชื่อคนที่ได้ GPA MIN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(393, 64);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 20;
            label12.Text = "ชื่อคนที่ได้ GPA MAX";
            label12.Click += label12_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNameMin);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbNameMax);
            groupBox1.Location = new Point(192, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 224);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 307);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(tbMax);
            Controls.Add(tbMin);
            Controls.Add(tbAvg);
            Controls.Add(label5);
            Controls.Add(tbGrade);
            Controls.Add(tbTotal);
            Controls.Add(label4);
            Controls.Add(tbListofPerson);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(tbBirthYear);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbBirthYear;
        private Button btnAdd;
        private Label label3;
        private TextBox tbListofPerson;
        private Label label4;
        private TextBox tbTotal;
        private TextBox tbGrade;
        private Label label5;
        private TextBox tbAvg;
        private TextBox tbMin;
        private TextBox tbMax;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox tbNameMax;
        private TextBox tbNameMin;
    }
}