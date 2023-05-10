using System;
using System.Text;

namespace laba2_5_task2
{
    internal class Program
    {
        static List<Student> ReadData(string fileName)
        {
            FileStream fs = File.Open(@"input.txt", FileMode.Open);
            List<Student> st = new List<Student>();
            using (var reader = new StreamReader(fs))
            {
                while (reader.Peek() >= 0)
                {
                    string str = reader.ReadLine() ?? string.Empty;
                    Student student = new Student(str);
                    st.Add(student);
                }
            }
        }

        static void runMenu(List<Student> studs)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in studs)
            {
                if ()
                result.Add(student);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}