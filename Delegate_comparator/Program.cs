using System;

class Program
{
    public delegate bool Comparer(object obj1, object obj2);

    static class Sorter
    {
        static public void BubbleSort(object[] array, Comparer del)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (del(array[j], array[i]))
                    {
                        object temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }
        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthday;

        public Person(string FirstName, string LastName, DateTime Birthday)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }

        public override string ToString()
        {
            return string.Format(
                "Iм'я: {0, -10} Прiзвище: {1, -12} Дата народження: {2:dd.MM.yyyy}.",
                FirstName, LastName, Birthday);
        }
    }

    static public bool PersonFirstnameComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o1).FirstName.CompareTo(((Person)o2).FirstName) < 0;
    }
    static public bool PersonReverseFirstnameComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o2).FirstName.CompareTo(((Person)o1).FirstName) < 0;
    }

    static public bool PersonBirthdayComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o1).Birthday.CompareTo(((Person)o2).Birthday) < 0;
    }

    static public bool PersonReverseBirthdayComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o2).Birthday.CompareTo(((Person)o1).Birthday) < 0;
    }

    static public bool PersonSurnameComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o1).LastName.CompareTo(((Person)o2).LastName) < 0;
    }

    static public bool PersonReverseSurnameComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o2).LastName.CompareTo(((Person)o1).LastName) < 0;
    }

    static public bool PersonLengthSurnameComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                + o1.GetType() + " та " + o2.GetType());

        return ((Person)o1).LastName.Length.CompareTo(((Person)o2).LastName.Length) < 0;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default; // підключення Української мови
        object[] persons = {
             new Person("Юрiй", "Каратаєв", new DateTime(1996, 1, 1)),
             new Person("Володимир", "Коч", new DateTime(1992, 11, 6)),
             new Person("Станiслав", "Петровський", new DateTime(1991, 5, 11)),
             new Person("Ігор", "Плахотнюк", new DateTime(1990, 10, 8)),
             new Person("Вiктор", "Пiвторак", new DateTime(1989, 6, 14)),
             new Person("Олександр", "Ванновський", new DateTime(1984, 10, 8)),
             new Person("Дмитро", "Грищук", new DateTime(1995, 6, 14)),
             new Person("Олександр", "Гурнiк", new DateTime(1993, 7, 1)),
             new Person("Свiтлана", "Сироткiна", new DateTime(1988, 7, 1)),
             new Person("Олег", "Смолiнський", new DateTime(1987, 1, 1)),
             new Person("Юрiй", "Соломон", new DateTime(1986, 11, 6)),
             new Person("Сергiй", "Яцишин", new DateTime(1985, 5, 11))
        };

        Console.WriteLine("Несортований список:\n");
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за iменами (А-Я) список:\n");
        Sorter.BubbleSort(persons, PersonFirstnameComparer); // імена (А-Я)
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за днем народження (від старших до молодших) список:\n");
        Sorter.BubbleSort(persons, PersonBirthdayComparer); // від старших до молодших
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за днем народження (від молодших до старших) список:\n");
        Sorter.BubbleSort(persons, PersonReverseBirthdayComparer); // від молодших до старших
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за прізвищами (А-Я) список:\n");
        Sorter.BubbleSort(persons, PersonSurnameComparer); // прізвища (А-Я)
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за прізвищами (Я-А) список:\n");
        Sorter.BubbleSort(persons, PersonReverseSurnameComparer); // прізвища (Я-А)
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за iменами (Я-А) список:\n");
        Sorter.BubbleSort(persons, PersonReverseFirstnameComparer); // імена (Я-А)
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nВiдсортований за iменами (Я-А) список:\n");
        Sorter.BubbleSort(persons, PersonLengthSurnameComparer); // довжина прізвища (від короткого до довгого)
        foreach (object person in persons) Console.WriteLine(person);

        Console.WriteLine("\n");
    }
}