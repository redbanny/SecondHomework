using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            for(int i = 1; i < 4; i++)
            {
                AddValue(i);
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }

        static void AddValue(int i)
        {
            Stopwatch stopwatch = new Stopwatch();
            switch (i)
            {
                case 1:
                    Console.WriteLine("Заполняем List<int> значениями");
                    AddValueInList();
                    Console.WriteLine("\t\tПоиск числа 496753 в List<int>");                    
                    stopwatch.Start();                    
                    for (int j = 0; j < ProgramHelpers.Lisik.Count; j++)
                    {
                        if(ProgramHelpers.Lisik[j] == 496753)
                        {
                            stopwatch.Stop();
                            break;
                        }
                        if(ProgramHelpers.Lisik[j]%777 == 0)
                        {
                            Console.WriteLine($"\t\t\tЧисло: {ProgramHelpers.Lisik[j]} делиться без отстатка на 777 => {stopwatch.Elapsed}");
                        }
                    }
                    Console.WriteLine($"\t\t\tВремя поиска числа 496753 в List<int>: {stopwatch.Elapsed}");
                    break;
                case 2:
                    Console.WriteLine("Заполняем ArrayList значениями");
                    AddValueInArrList();
                    Console.WriteLine("\t\tПоиск числа 496753 в ArrayList");
                    stopwatch.Start();
                    for (int j = 0; j < ProgramHelpers.ArrayList.Count; j++)
                    {
                        if ((int)ProgramHelpers.ArrayList[j] == 496753)
                        {
                            stopwatch.Stop();
                            break;
                        }
                        if ((int)ProgramHelpers.ArrayList[j] % 777 == 0)
                        {
                            Console.WriteLine($"\t\t\tЧисло: {ProgramHelpers.ArrayList[j]} делиться без отстатка на 777 => {stopwatch.Elapsed}");
                        }
                    }
                    Console.WriteLine($"\t\t\tВремя поиска числа 496753 в ArrayList: {stopwatch.Elapsed}");
                    break;
                case 3:
                    Console.WriteLine("Заполняем LinkList значениями");
                    AddValueInLinkList();
                    Console.WriteLine("\t\tПоиск числа 496753 в LinkList");
                    stopwatch.Start();
                    var item = ProgramHelpers.LinkList.First;
                    for (int j = 0; j < ProgramHelpers.LinkList.Count; j++)
                    {                        
                        if (item.Value == 496753)
                        {
                            stopwatch.Stop();
                            break;
                        }
                        if (item.Value % 777 == 0)
                        {
                            Console.WriteLine($"\t\t\tЧисло: {item.Value} делиться без отстатка на 777 => {stopwatch.Elapsed}");
                        }
                        item = item.Next;
                    }
                    Console.WriteLine($"\t\t\tВремя поиска числа 496753 в LinkList: {stopwatch.Elapsed}");
                    break;
                default:
                    break;
            }
        }
        static void AddValueInList()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                ProgramHelpers.Lisik.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"\tВремя заполнения List<int>: {stopwatch.Elapsed}");
        }
        static void AddValueInArrList()
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                ProgramHelpers.ArrayList.Add(i);
            }
            stopwatch1.Stop();
            Console.WriteLine($"\tВремя заполнения ArrayList: {stopwatch1.Elapsed}");
        }
        static void AddValueInLinkList()
        {
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                ProgramHelpers.LinkList.AddLast(i);
            }
            stopwatch2.Stop();
            Console.WriteLine($"\tВремя заполнения LinkList<int>: {stopwatch2.Elapsed}");
        }


    }
}
