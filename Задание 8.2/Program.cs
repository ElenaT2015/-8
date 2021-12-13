using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mypath = "myfile.txt";
            Random random = new Random();
            const int c10 = 10;
            int sum = 0;
            StreamWriter saveNumber = new StreamWriter(mypath, false);
            int[] numberRand = new int[c10];
            int[] numbertoFile = new int[c10];
            if (!File.Exists(mypath))
            {
                File.Create(mypath);
            }
            for (int i = 0; i < c10; i++)
            {
                numberRand[i] = random.Next(1, 100);
                saveNumber.WriteLine(numberRand[i]);
                saveNumber.Flush();
            }
            saveNumber.Close();
            StreamReader readNumber = new StreamReader(mypath);
            for (int i = 0; i < c10; i++)
            {
                numbertoFile[i] = Convert.ToInt32(readNumber.ReadLine());
            }
            readNumber.Close();
            for (int i = 0; i < c10; i++)
            {
                sum += numbertoFile[i];
            }
            Console.WriteLine(" Сумма в файле {0} = {1}", mypath, sum);
            Console.ReadKey();
        }
    }
}