using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class Group : IEnumerable
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
        public Group(ref Student[] array) : this(array.Length, "SPU-121", "Programming", 5) // create new group (default) and add array of students
        {
            for (int i = 0; i < count_of_students; i++)
            {
                students[i] = array[i];
            }
        }
        public Group(ref Group a, string name_of_group, string specialization, int course) 
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
        // add new student
        public void AddStudent(string surname, string name, string patronymic)
        {
            students.Add(new Student(surname, name, patronymic));
        }
        // add student (ref)
        public void AddStudent(ref Student a)
        {
            students.Add(a);
        }
        public void Remove()  // отчисление неуспевающего студента 
        {
            double min = students[0].Average();
            int index = 0;
            for (int i = 1; i < students.Count; i++)
            {
                if (min > students[i].Average())
                {
                    min = students[i].Average();
                    index = i;
                }
            }
            students.RemoveAt(index);
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
        public void SearchByName(string name)
        {
            int count = 0;
            Console.Write("Students with name " + name);
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Name == name)
                {
                    Console.WriteLine();
                    this.students[i].ShowStudent();
                    count++;
                }
            }
            if (count == 0) Console.WriteLine(" not found");
        }

        public void SearchBySurname(string surname)
        {
            int count = 0;
            Console.Write("Students with surname " + surname);
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Surname == surname)
                {
                    Console.WriteLine();
                    this.students[i].ShowStudent();
                    count++;
                }
            }
            if (count == 0) Console.WriteLine(" not found");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return /*(IEnumerator)*/GetEnumerator();
        }

        public GroupEnum GetEnumerator()
        {
            return new GroupEnum(students);
        }
    }


    public class GroupEnum : IEnumerator
    {
        public List <Student> students;
        int position = -1;

        public GroupEnum(List <Student> list)
        {
            students = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < students.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return students[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
