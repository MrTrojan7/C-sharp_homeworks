using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class Group //: IEnumerable
    {
        private List <Student> students;
        private int count_of_students;
        private string name_of_group;
        private string specialization;
        private int course;

        // c-tors
        public Group(int count, string name_of_group, string specialization, int course) // main c-tor
        {
            this.count_of_students = count;
            students = new List<Student>(count_of_students) { };
            for (int i = 0; i < count_of_students; i++)
            {
                students.Add(new Student());
            }
            this.name_of_group = name_of_group;
            this.specialization = specialization;
            this.course = course;
        }
        public Group(Student[] array) : this(array.Length, "SPU-121", "Programming", 5) // create new group (default) and add array of students
        {
            for (int i = 0; i < count_of_students; i++)
            {
                students[i] = array[i];
            }
        }
        public Group(Group a, string name_of_group, string specialization, int course) 
            // create new group based on other group (with custom params) and add array of students on other group
            // copy c-tor
            : this(a.Count_of_students, name_of_group, specialization, course)
        {
            for (int i = 0; i < count_of_students; i++)
            {
                this.students[i] = a.students[i];
            }
        }
        public Group() : this(10, "SPU-121", "Programming", 3) { } // default c-tor
        public Group(int count) : this(count, "SPU-121", "Programming", 3) { } // create new group (default) with count of students

        // get/set
        public string Name_of_group
        {
            get { return name_of_group; }
            set { name_of_group = value; }
        }
        public int Count_of_students
        {
            get { return count_of_students; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        // indexer
        public Student this[int index]
        {
            get
            {
                return IsVAlidIndexOfStudents(index);
            }
            set
            {
                IsVAlidIndexOfStudents(index);
                students[index] = value;
            }
        }
        // check index in array of students
        private Student IsVAlidIndexOfStudents(int index)
        {
            try
            {
                return students[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();

            }
        }

        // ShowGroup for()
        public void ShowGroup()
        {
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("Group name: " + Name_of_group);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Count of students: " + Count_of_students);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("List of Students: ");
            Console.WriteLine();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("Student # " + (i + 1));
                students[i].ShowStudent();
            }
        }

        // PrintGroup (foreach)
        public void PrintGroup()
        {
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("Group name: " + Name_of_group);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Count of students: " + Count_of_students);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("List of Students: ");
            foreach (var item in students)
            {
                item.ShowStudent();
            }
        }
        public void SortByAverage()
        {
            students.Sort();
        }

        public void SortByLastName()
        {
            students.Sort(new SortBySurname());
        }

        public void SortByDateOfBirth()
        {
            students.Sort(new SortByAge());
        }
    }
}
