using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        const int N=100;
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("是否输入学生成绩，Y是，N不是");
            char command;
            command = char.Parse(Console.ReadLine());
            Student user = new Student();
            double[] alltest = new double[N];
            while (command == 'Y')
            { 
                Console.WriteLine("输入第{0}名同学的数学和英语成绩", i + 1);
                Console.Write("数学：");
                user.Math = double .Parse(Console.ReadLine());
                Console.Write("英语：");
                user.English  = double .Parse(Console.ReadLine());
                alltest[i] = user.English + user.Math;
                i++;
                Console.WriteLine("是否输入学生成绩，Y是，N不是");
                command = char.Parse(Console.ReadLine());
            }
            double  temp;
            for (int s = 0; s < i-1; s++)
            {
                for (int t = s; t < i-s-1; t++)
                {
                    if (alltest[t+1] >= alltest[t])
                    {
                        temp = alltest[t+1] ;
                        alltest[t+1] = alltest[t];
                        alltest[t] = temp;
                    }
                }
            }
            Console.WriteLine("总成绩排完续只后的情况为：");
            for (int j=0;j<i;j++)
            {
                Console.WriteLine(alltest [j]);
            }
            Console.Read();
        }
    }
}
