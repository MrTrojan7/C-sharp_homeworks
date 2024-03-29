﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class Student : IComparable<Student>
    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime date_of_birth;
        private uint age;
        private string address;
        private int telephone_number;
        private List <int> credits;
        private List <int> course_work;
        private List <int> exams;
        public static Random rnd = new Random();

        // c-tors
        public Student(string surname, string name, string patronymic, 
            DateTime date_time,
            string address, int teleph_num) // main c-tor
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Date_of_birth = date_time;
            this.Address = address;
            this.Age = SetAge(date_time);
            this.Telephone_number = teleph_num;
            credits = new List<int> { };
            AddRandomMarks(ref credits, 1);
            course_work = new List<int> { };
            AddRandomMarks(ref course_work, 1);
            exams = new List<int> { };
            AddRandomMarks(ref exams, 1);
        }
        // delegate c-tors
        public Student() : this(Surnames(), Names(), Patronymics(), 
            DateTime.Today, "Chernyahovskogo 1", TelephoneNumber())  // Default
        { }

        public Student(string surname, string name, string patronymic) : 
            this(surname, name, patronymic, DateTime.Today, 
                "Chernyahovskogo 1", TelephoneNumber()) // Surname, Name, Pathronymic
        { }

        public Student(string name, DateTime date_time, string address, int telephone) : 
            this(Surnames(), name, Patronymics(), date_time, address, telephone) // Name, Date, Address, Telephone
        { }

        public Student(string name) :
            this(Surnames(), name, Patronymics(), DateTime.Today, "Chernyahovskogo 1", TelephoneNumber()) // Name
        { }

        // show 
        public void ShowStudent()
        {
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Patronymic: " + Patronymic);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Telephone_number: " + Telephone_number);
            Console.WriteLine("date_of_bird: " + Date_of_birth.ToShortDateString()); // toFix this crutch (use DateOnly)
            Console.Write("credits: ");
            ShowMarks(credits);
            Console.Write("course works: ");
            ShowMarks(course_work);
            Console.Write("exams: ");
            ShowMarks(exams);
            Console.WriteLine("Average: " + Average());
            Console.WriteLine("--------------------------");
        }
        //// generation information for default c-tor
        private static string Surnames ()
        {
            string[] surnames = { "Danylenko", "Lypchuk", "Danyliuk",
                                "Petrych", "Danylov", "Kobzar", "Tkach",
                                "Sklyar", "Grabovets", "Kolomiets"};
            return surnames[rnd.Next(0, 10)];
        }
        private static string Names ()
        {
            string[] names = { "Stanislav", "Danylo", "Maksym",
                                "Leonid", "Vasyl", "Karpo", "Stepan",
                                "Valentyn", "Yurij", "Oleksandr"};
            return names[rnd.Next(0, 10)];
        }
        private static string Patronymics ()
        {
            string[] patronymics = { "Stanislavovych", "Danylovych", "Archypovych",
                                "Zacharovych", "Oleksandrovych", "Karpovych", "Stepanovych",
                                "Vadymovych", "Maksymovych", "Markovych"};
            return patronymics[rnd.Next(0, 10)];
        }
        private static int TelephoneNumber()
        {
            return rnd.Next(10000000, 99999999);
        }

        //// get/set 
        public DateTime Date_of_birth
        {
            get { return date_of_birth.Date; }
            set
            {
                if (value > DateTime.Today)
                {
                    date_of_birth = DateTime.Today;
                }
                else
                {
                    date_of_birth = value;
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { this.patronymic = value; }
        }
        public uint Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public int Telephone_number
        {
            get { return telephone_number; }
            set { this.telephone_number = value; }
        }
        private uint SetAge(DateTime dt)
        {
            TimeSpan timeSpan = (DateTime.Today - this.date_of_birth);
            return (uint)timeSpan.TotalDays / 365;
        }

        // average
        public double Average()
        {

            return ((double)course_work.Average() + (double)credits.Average() + (double)exams.Average()) / 3;
        }

        /// //// Marks

        private void ShowMarks (List <int> arr)
        {
            if (arr.Count == 0)
            {
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void AddCredits (int val)
        {
            if (CheckValueOfMark(ref val))
            {
                credits.Add(val);
            }
        }
        public void AddCourseWorks(int val)
        {
            if (CheckValueOfMark(ref val))
            {
                course_work.Add(val);
            }
        }
        public void AddExams(int val)
        {
            if (CheckValueOfMark(ref val))
            {
                exams.Add(val);
            }
        }

        private void AddRandomMarks(ref List<int> arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                arr.Add(rnd.Next(0,13));
            }
        }

        //// validation checks of marks
        private bool CheckIndexOfMark(ref List <int> arr, int index)
        {
            if (index < 0 || index > arr.Count)
                return false;
            else
                return true;
        }

        private bool CheckValueOfMark(ref int val)
        {
            if (val <= 0 || val > 12)
                return false;
            return true;
        }

        // CompareTo
        
        public int CompareTo(Student second)
        {
            if (this.Average() > second.Average())
            {
                return 1;
            }
            else if (this.Average() < second.Average())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}