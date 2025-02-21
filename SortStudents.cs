using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByGradeAndThenStudentID
{
    public class Student : IComparable<Student>
    {
        private string id;
        private string grade;

        public Student(string id, string grade)
        {
            this.id = id;
            this.grade = grade;
        }

        public string GetId()
        {
            return this.id;
        }

        public string GetGrade()
        {
            return this.grade;
        }

        public int CompareTo(Student other)
        {
            if (this.GetGrade().CompareTo(other.GetGrade()) == 0)
            {
                return this.id.CompareTo(other.GetId());
            }
            return this.GetGrade().CompareTo(other.GetGrade());
        }
    }
}
namespace SortByGradeAndThenStudentID
{
    public class SortByGradeAndThenStudentID
    {
        public Student[] SortStudentsByGradeAndId(Student[] s)
        {
            Array.Sort(s);
            return s;
        }
    }
    public class MainClass{
        public static void Main(){
            Student[] students = new Student[]{
                new Student("3", "B"),
                new Student("1", "A"),
                new Student("2", "B"),
                new Student("4", "A"),
            };
            new SortByGradeAndThenStudentID().SortStudentsByGradeAndId(students);
            foreach(Student s in students){
                Console.WriteLine(s.GetId()+" "+s.GetGrade());
            }

        }
    }
}
