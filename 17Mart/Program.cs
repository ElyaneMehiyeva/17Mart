using System;

namespace _17Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzunluq daxil edin :");
            string numStr = Console.ReadLine();
            int num;
            while (!int.TryParse(numStr, out num))
            {
                Console.WriteLine("Uzunluq daxil edin (Eded):");
                numStr = Console.ReadLine();
            }
            Group[] GroupArray = new Group[num];
            
            for (int i = 0; i < num; i++)
            {
                string groupNo;
                int studentLimit;
                string studentLimitStr;
                Console.WriteLine($"{i+1}. Group No :");
                groupNo = Console.ReadLine();
                while (!CheckCondition(groupNo)) 
                {
                    Console.WriteLine($"{i + 1}. Group No Dogru Formatda Daxil Edin!");
                    groupNo = Console.ReadLine();
                }
                Console.WriteLine($"{i+1}. Student Limit :");
                studentLimitStr = Console.ReadLine();
                int.TryParse(studentLimitStr, out studentLimit);
                while (!int.TryParse(studentLimitStr, out studentLimit))
                {
                    Console.WriteLine($"{i + 1}. Student Limit + Eded Olmalidir :");
                    studentLimitStr = Console.ReadLine();
                    int.TryParse(studentLimitStr, out studentLimit);
                }
                Group group = new Group();
                group.GroupNo = groupNo;
                group.StudentLimit = studentLimit;
                GroupArray[i] = group;
            }
            Console.WriteLine("Group Yaratma Isi Bitdi !");
            foreach (Group item in GroupArray)
            {
                Console.WriteLine("Group No : {0} -*- Student Limit : {1}", item.GroupNo, item.StudentLimit);
            }
            Console.WriteLine("The End");
        }
        static bool CheckCondition(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && text.Length == 5 && char.IsUpper(text[0]) && char.IsUpper(text[1]) && char.IsDigit(text[2]) && char.IsDigit(text[3]) && char.IsDigit(text[4]))
            {
                return true;
            }
            return false;
        }
    }
}
