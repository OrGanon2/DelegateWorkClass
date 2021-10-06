using DelegatesWorkClass;
using System.Collections.Generic;

namespace DelegatesWorkClass
{
    public delegate int Dele(int a, int b);
    //public delegate bool DeleStudent(student studentlist);

//    public class student
//    {
//        public int Id { get; set; }
//        public string Fullname { get; set; }
//        public int Grade { get; set; }

//    }
//    public class StudentManage
//    {
//        public static List<student> StudentList { get; set; }

//        public void AddStudent(string fullname, int Id)
//        {
//            StudentList.Add(new student());
//        }
//        public bool RemoveStudent(string fullname)
//        {
//            foreach (var student in StudentList)
//            {
//                if (student.Fullname == fullname)
//                {
//                    StudentList.Remove(student);
//                    return true;
//                }
//            }
//            return false;


//        }
//        public List<student> filter(DeleStudent filter)
//        {
//            List<student> studentList = new List<student>();
//            for (int i = 0; i < StudentList.Count; i++)
//            {
//                if (filter(studentList[i]))
//                {
//                    studentList.Add(StudentList[i]);
//                }
//            }
//            return studentList;
//        }
//        public bool contain(DeleStudent filter)
//        {
//            for (int i = 0; i < StudentList.Count; i++)
//            {
//                if (filter(StudentList[i]))
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }

}