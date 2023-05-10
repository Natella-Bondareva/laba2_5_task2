using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba2_5_task2
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] student = lineWithAllData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            surName = student[0];
            firstName = student[1];
            patronymic = student[2];
            sex = Convert.ToChar(student[3]);
            dateOfBirth = student[4];
            mathematicsMark = Convert.ToChar(student[5]);
            physicsMark = Convert.ToChar(student[6]);
            informaticsMark = Convert.ToChar(student[7]);
            scholarship = Convert.ToInt32(student[8]);
        }
    }
}
