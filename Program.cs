using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Сколько студентов создаем?");
                    int kol = int.Parse(Console.ReadLine());

                    Student[] students = new Student[kol];

                    for (int i = 0; i < kol; i++)
                    {
                        Console.WriteLine("Введите имя студента " + (i + 1));
                        string Name = Console.ReadLine();
                        Console.WriteLine("Введите возраст студента " + (i + 1));
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите средний балл студента " + (i + 1));
                        double Gpa = double.Parse(Console.ReadLine());

                        students[i] = new Student(Name, Age, Gpa);
                    }

                    StudentAgeComparer studentAgeComparer = new StudentAgeComparer();

                    Console.WriteLine("Сортируем по возрасту:");
                    Student[] studentsAge = new Student[students.Length];
                    Array.Copy(students, studentsAge, students.Length);
                    Array.Sort(studentsAge);
                    foreach (Student student in studentsAge)
                    {
                        Console.Write(student.Name + " " + student.Age + " лет" + " Средний балл = " + student.Gpa + "\n");
                    }

                    Console.WriteLine("\nСортируем по среднему баллу:");
                    Array.Sort(students, studentAgeComparer);
                    foreach (Student student in studentsAge)
                    {
                        Console.Write(student.Name + " " + student.Age + " лет" + " Средний балл = " + student.Gpa + "\n");
                    }

                }
                catch (Exception e) { Console.WriteLine(e.Message + "\nПерезапуск..."); }
                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
