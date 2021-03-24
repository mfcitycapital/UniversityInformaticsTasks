using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
            SeventhTask();
            EighthTask();
            NinthTask();
            
        }

        public static void FirstTask()
        {
            List<Book> books = new List<Book>{new Book("1"), new Book("2")};
            Print(books);
            books.Add(new Book("abc"));
            Print(books); 
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void SecondTask()
        {
            List<int> numbers_first = new List<int>{5,4,3,2,1};
            List<int> numbers_second = new List<int>{10,9,8,7,6};

            List<int> new_numbers = new List<int>();
            new_numbers.AddRange(numbers_first);
            new_numbers.AddRange(numbers_second);

            new_numbers.Sort();
            new_numbers.Reverse();
            
            Print(new_numbers);
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void ThirdTask()
        {
            List<int> numbers = new List<int>{10, 8, 3, 1, -1, 5, 10, 2, 8, 4, -5, -20, 3};
            List<int> positive_numbers = new List<int>();
            List<int> numbers_index2 = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > 0)
                {
                    positive_numbers.Add(numbers[i]);
                }
            }
            positive_numbers.Sort();
            int a = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    numbers[i] = positive_numbers[a];
                    a++;
                }
            }
            
            Print(numbers); // a task
            Console.WriteLine("--");
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if(i % 2 == 0)
                {
                    numbers_index2.Add(numbers[i]);
                }
            }
            numbers_index2.Sort();
            a = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    numbers[i] = numbers_index2[a];
                    a++;
                }
            }
            
            Print(numbers); // b task
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void FourthTask()
        {
            List<int> numbers_first = new List<int> {5, 4, 3, 2, 1};
            List<int> numbers_second = new List<int> {1, 2, 3, 4, 5};

            bool a = true;

            foreach (int number_first in numbers_first)
            {
                if (!(numbers_second.Contains(number_first)) && a != false)
                {
                    a = false;
                }
            }
            
            foreach (int number_second in numbers_second)
            {
                if (!(numbers_first.Contains(number_second)) && a != false)
                {
                    a = false;
                }
            }

            if (a == true)
            {
                Console.WriteLine("Множества совпадают");
            }
            else Console.WriteLine("Множества не совпадают");
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void FifthTask()
        {
            List<int> numbers = new List<int> {1, 2, 3, 4, 5};
            List<int> previous_part = new List<int>();
            List<int> new_numbers = new List<int>();
            
            new_numbers.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                previous_part.Add(numbers[i-1]);
                new_numbers.Add(numbers[i]);
                new_numbers.AddRange(previous_part);
            }
            
            Print(new_numbers);
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void SixthTask()
        {
            List<char> text = new List<char>{'i','t','m','a','t','h','r','e','p','e','t','i','t','o','r','t','h','r','e','p','e','t','i','t','o','r'};
            StringBuilder text_string = new StringBuilder();
            for (int i = 0; i < text.Count; i++)
            {
                text_string.Append(text[i]);
            }

            while (text_string.ToString().Contains("itmathrepetitor"))
            {
                text_string.Replace("itmathrepetitor", "silence");
            }

            text.Clear();
            for (int i = 0; i < text_string.Length; i++)
            {
                text.Add(text_string[i]);
            }
            
            Console.WriteLine(text_string);
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void SeventhTask()
        {
            LinkedList<int> symbols_count = new LinkedList<int>();
            
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"/Users/arslanrashidov/RiderProjects/Solution/Collections/text.txt");  
            while((line = file.ReadLine()) != null)
            {
                symbols_count.AddLast(line.Length);
                
            } 
            file.Close();

            foreach (int i in symbols_count)
            {
                Console.WriteLine(i);
            }
        }

        public static void EighthTask()
        {
            List<string> students_group1 = new List<string>{"A", "B", "C"};
            List<string> students_group2 = new List<string>{"D", "E", "F"};
            List<string> students_group3 = new List<string>{"G", "H", "X"};
            
            LinkedList<List<string>> student_groups = new LinkedList<List<string>>();
            student_groups.AddLast(students_group1);
            student_groups.AddLast(students_group2);
            student_groups.AddLast(students_group3);

            foreach (List<string> group in student_groups)
            {
                foreach (string student in group)
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void NinthTask()
        {
            Student student1 = new Student("Q", "Maga", "Agiga", 2002, 1, new int[] {1, 1, 1, 1, 1}, 5);
            Student student2 = new Student("A", "Maga", "Agiga", 2001, 2, new int[] {1, 2, 1, 3, 4}, 5);
            Student student3 = new Student("B", "Maga", "Agiga", 2000, 4, new int[] {5, 3, 1, 2, 1}, 6);
            Student student4 = new Student("C", "Maga", "Agiga", 2002, 2, new int[] {1, 2, 4, 5, 1}, 7);
            Student student5 = new Student("D", "Maga", "Agiga", 2003, 1, new int[] {4, 1, 3, 2, 1}, 6);
            Student student6 = new Student("V", "Maga", "Agiga", 2001, 3, new int[] {3, 1, 4, 1, 4}, 7);
            Student student7 = new Student("L", "Maga", "Agiga", 2003, 4, new int[] {1, 5, 3, 1, 5}, 5);
            Student student8 = new Student("M", "Maga", "Agiga", 2000, 1, new int[] {1, 2, 1, 1, 1}, 6);
            Student student9 = new Student("Z", "Maga", "Agiga", 2002, 3, new int[] {5, 5, 5, 5, 4}, 7);



            List<Student> students = new List<Student>
                {student1, student2, student3, student4, student5, student6, student7, student8, student9};
            

            var sortedStudents = students.OrderBy(a => a.course).ThenBy(b => b.surname).ToList();
            Print(sortedStudents);
            
            double[] average_appraisal = FindAverage(sortedStudents);
            int n = 5;
            Console.WriteLine("Средние баллы по группам:");
            foreach (double average_in_course in average_appraisal)
            {
                Console.WriteLine($"{n}: {average_in_course}");
                n += 1;
            }
    
            
            string[] youngAndOld = FindOldAndYoung(sortedStudents);
            Console.WriteLine($"Самый молодой студент: {youngAndOld[0]}");
            Console.WriteLine($"Самый старший студент: {youngAndOld[1]}");

            string[] theBest = FindTheBest(sortedStudents);
            n = 5;
            Console.WriteLine("Лучшие ученики по группам:");
            foreach (string student in theBest)
            {
                Console.WriteLine($"{n}: {student}");
                n += 1;
            }
        }

        public static double[] FindAverage(List<Student> students)
        {
            double[] averages = new double[3];

            int first_course = 0;
            int first_all = 0;
            int second_course = 0;
            int second_all = 0;
            int third_course = 0;
            int third_all = 0;


            foreach (var student in students)
            {
                if (student.group == 5)
                {
                    first_course += 1;
                    foreach (var appraisal in student.appraisals)
                    {
                        first_all += appraisal;
                    }
                }
                if (student.group == 6)
                {
                    second_course += 1;
                    foreach (var appraisal in student.appraisals)
                    {
                        second_all += appraisal;
                    }
                }
                if (student.group == 7)
                {
                    third_course += 1;
                    foreach (var appraisal in student.appraisals)
                    {
                        third_all += appraisal;
                    }
                }
            }
            averages[0] = (first_all * 1.0) / (first_course*5.0);
            averages[1] = (second_all * 1.0) / (second_course*5.0);
            averages[2] = (third_all * 1.0) / (third_course*5.0);
            
            
            return averages;
        }

        public static string[] FindOldAndYoung(List<Student> students)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            string mini = "";
            string maxi = "";
            
            foreach (Student student in students)
            {
                if (student.year_of_birth < min)
                {
                    string fio = student.surname + " " + student.name + " " + student.fathername;
                    mini = fio;
                    min = student.year_of_birth;
                }
                if (student.year_of_birth > max)
                {
                    string fio = student.surname + " " + student.name + " " + student.fathername;
                    maxi = fio;
                    max = student.year_of_birth;
                }
            }

            return new string[] {mini, maxi};
        }

        public static string[] FindTheBest(List<Student> students)
        {
            double max5 = Double.MinValue;
            
            double max6 = Double.MinValue;
            
            double max7 = Double.MinValue;
            
            string maxi5 = "";
            
            string maxi6 = "";
            
            string maxi7 = "";
            
            foreach (Student student in students)
            {
                if (student.group == 5)
                {
                    int sum = 0;
                    foreach (int value in student.appraisals)
                    {
                        sum += value;
                    }
                    double average = (sum * 1.0) / 5.0;
                    
                    if (average > max5)
                    {
                        string fio = student.surname + " " + student.name + " " + student.fathername;
                        maxi5 = fio;
                        max5 = average;
                    }
                }
                if (student.group == 6)
                {
                    int sum = 0;
                    foreach (int value in student.appraisals)
                    {
                        sum += value;
                    }
                    double average = (sum * 1.0) / 5.0;

                    if (average > max6)
                    {
                        string fio = student.surname + " " + student.name + " " + student.fathername;
                        maxi6 = fio;
                        max6 = average;
                    }
                }
                if (student.group == 7)
                {
                    int sum = 0;
                    foreach (int value in student.appraisals)
                    {
                        sum += value;
                    }
                    double average = (sum * 1.0) / 5.0;

                    if (average > max7)
                    {
                        string fio = student.surname + " " + student.name + " " + student.fathername;
                        maxi7 = fio;
                        max7 = average;
                    }
                }
            }
            return new string[]{maxi5, maxi6, maxi7};
        }
   
        public static void Print(List<Book> Books)
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.name);
            }
        }

        public static void Print(List<int> Numbers)
        {
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
        
        public static void Print(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.Write($"{student.surname} {student.name} {student.fathername} {student.course} {student.year_of_birth}");
                int[] appraisals = student.appraisals;
                Console.Write($" {student.group}\n");
                foreach (int appraisal in appraisals)
                {
                    Console.Write($"{appraisal} ");
                }
                Console.WriteLine();
            }
        }
        
    }

    class Book
    {
        public string name { get; }

        public Book(string Name)
        {
            name = Name;
        }
    }

    class Student
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public int year_of_birth { get; set; }
        public int course { get; set; }
        public int[] appraisals { get; set; }
        public int group { get; set; }
        public Student(string Surname, string Name, string Fathername, int YearOfBirth, int Course, int[] Appraisals, int Group)
        {
            surname = Surname;
            name = Name;
            fathername = Fathername;
            year_of_birth = YearOfBirth;
            course = Course;
            appraisals = Appraisals;
            group = Group;
        }
    }
}
