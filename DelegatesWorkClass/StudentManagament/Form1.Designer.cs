
namespace StudentManagament
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.GradeCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FullnameCheck = new System.Windows.Forms.Button();
            this.Paid = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalPayText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CostLeftText = new System.Windows.Forms.TextBox();
            this.AgeAvrText = new System.Windows.Forms.TextBox();
            this.AvrGradeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "שאלה 5";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(97, 58);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(125, 27);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(97, 228);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(125, 27);
            this.Grade.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(97, 104);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(125, 27);
            this.Name.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(355, 85);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(125, 29);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(355, 129);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(125, 29);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // GradeCheck
            // 
            this.GradeCheck.Location = new System.Drawing.Point(355, 246);
            this.GradeCheck.Name = "GradeCheck";
            this.GradeCheck.Size = new System.Drawing.Size(125, 29);
            this.GradeCheck.TabIndex = 6;
            this.GradeCheck.Text = "Grade Check";
            this.GradeCheck.UseVisualStyleBackColor = true;
            this.GradeCheck.Click += new System.EventHandler(this.GradeCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grade";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(530, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 204);
            this.listBox1.TabIndex = 10;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(97, 147);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(125, 27);
            this.LastName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name";
            // 
            // FullnameCheck
            // 
            this.FullnameCheck.Location = new System.Drawing.Point(355, 184);
            this.FullnameCheck.Name = "FullnameCheck";
            this.FullnameCheck.Size = new System.Drawing.Size(125, 29);
            this.FullnameCheck.TabIndex = 13;
            this.FullnameCheck.Text = "Fullname check";
            this.FullnameCheck.UseVisualStyleBackColor = true;
            this.FullnameCheck.Click += new System.EventHandler(this.FullnameCheck_Click);
            // 
            // Paid
            // 
            this.Paid.Location = new System.Drawing.Point(97, 314);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(125, 27);
            this.Paid.TabIndex = 14;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(97, 270);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(125, 27);
            this.Cost.TabIndex = 15;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(97, 186);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(125, 27);
            this.Age.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paid";
            // 
            // TotalPayText
            // 
            this.TotalPayText.Location = new System.Drawing.Point(574, 301);
            this.TotalPayText.Name = "TotalPayText";
            this.TotalPayText.Size = new System.Drawing.Size(180, 27);
            this.TotalPayText.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Avrage Age";
            // 
            // CostLeftText
            // 
            this.CostLeftText.Location = new System.Drawing.Point(574, 334);
            this.CostLeftText.Name = "CostLeftText";
            this.CostLeftText.Size = new System.Drawing.Size(180, 27);
            this.CostLeftText.TabIndex = 22;
            this.CostLeftText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AgeAvrText
            // 
            this.AgeAvrText.Location = new System.Drawing.Point(574, 367);
            this.AgeAvrText.Name = "AgeAvrText";
            this.AgeAvrText.Size = new System.Drawing.Size(180, 27);
            this.AgeAvrText.TabIndex = 23;
            // 
            // AvrGradeText
            // 
            this.AvrGradeText.Location = new System.Drawing.Point(574, 400);
            this.AvrGradeText.Name = "AvrGradeText";
            this.AvrGradeText.Size = new System.Drawing.Size(180, 27);
            this.AvrGradeText.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Payment Left";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Paid In Total";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Avrage Grade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AvrGradeText);
            this.Controls.Add(this.AgeAvrText);
            this.Controls.Add(this.CostLeftText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalPayText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Paid);
            this.Controls.Add(this.FullnameCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradeCheck);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button GradeCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FullnameCheck;
        private System.Windows.Forms.TextBox Paid;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalPayText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CostLeftText;
        private System.Windows.Forms.TextBox AgeAvrText;
        private System.Windows.Forms.TextBox AvrGradeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

