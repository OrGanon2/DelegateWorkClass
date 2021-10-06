using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public double AvrageGrade(Student GradeAvrage)
        {
            return GradeAvrage.Grade;
        }
        public double AvrageAge(Student AgeAvrage)
        {
            return AgeAvrage.Age;
        }
        public int TotalLeft(Student studentCostLeft)
        {
            return studentCostLeft.Cost;
        }
        public int TotalPaid(Student studentTotal)
        {
            return studentTotal.Paid;
        }
        public bool Check(Student student)
        {
            if (student.Name[0] == student.LastName[0] )
            {
                return true;
            }
            return false;
        }
        public bool StudentGrade(Student student)
        {
            if (student.Grade < 50)
            {
                return true;
            }
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            StudentManage.AddStudent(ID.Text, Name.Text,LastName.Text ,int.Parse(Grade.Text),int.Parse(Age.Text),int.Parse(Cost.Text), int.Parse(Paid.Text));
            listBox1.Items.Clear();
            foreach (var item in StudentManage.StudentList)
            {
                listBox1.Items.Add(item);
            }
            TotalPayText.Text = StudentManage.Sum(TotalPaid).ToString();
            CostLeftText.Text = StudentManage.Sum(TotalLeft).ToString();
            AgeAvrText.Text = StudentManage.avrage(AvrageAge).ToString();
            AvrGradeText.Text = StudentManage.avrage(AvrageGrade).ToString();
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
            try
            {
             bool remove = StudentManage.RemoveStudent(Name.Text,LastName.Text);
                if (!remove)
                {
                    MessageBox.Show("student not found");
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (var item in StudentManage.StudentList)
                    {
                        listBox1.Items.Add(item);
                    }
                    TotalPayText.Text = StudentManage.Sum(TotalPaid).ToString();
                    CostLeftText.Text = StudentManage.Sum(TotalLeft).ToString();
                    AgeAvrText.Text = StudentManage.avrage(AvrageAge).ToString();
                    AvrGradeText.Text = StudentManage.avrage(AvrageGrade).ToString();
                    MessageBox.Show("Student has been removed Successfully");
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("please insert a name");
            }

        }

        private void GradeCheck_Click(object sender, EventArgs e)
        {
            if (StudentManage.contain(StudentGrade))
            {
                MessageBox.Show("Grades lower then 50");
            }
            else
            {
                MessageBox.Show("there are no Grades lower then 50");
            }
            
        }

        private void FullnameCheck_Click(object sender, EventArgs e)
        {
            if (StudentManage.contain(Check))
            {
                MessageBox.Show("there is a student with the same first name last name starting letter");
            }
            else
            {
                MessageBox.Show("no student with the same first name and last name starting letter");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
