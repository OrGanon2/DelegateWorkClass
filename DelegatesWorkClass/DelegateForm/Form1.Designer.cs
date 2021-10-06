
namespace DelegateForm
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
            this.Text = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(438, 90);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(175, 27);
            this.Text.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(150, 123);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(164, 29);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(438, 123);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(175, 29);
            this.Sub.TabIndex = 2;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text);
            this.Name = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

