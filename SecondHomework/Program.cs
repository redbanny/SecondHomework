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
                    Console.WriteLine("\t\tПоиск 496753-го элемента в List<int>");
                    SearchItems(ProgramHelpers.Lisik, ProgramHelpers.Lisik.GetType());
                    NoResidue(ProgramHelpers.Lisik, ProgramHelpers.Lisik.GetType(), 777);
                    break;
                case 2:
                    Console.WriteLine("Заполняем ArrayList значениями");
                    AddValueInArrList();
                    Console.WriteLine("\t\tПоиск 496753-го элемента в ArrayList");
                    SearchItems(ProgramHelpers.ArrayList, ProgramHelpers.ArrayList.GetType());
                    NoResidue(ProgramHelpers.ArrayList, ProgramHelpers.ArrayList.GetType(), 777);
                    break;
                case 3:
                    Console.WriteLine("Заполняем LinkList значениями");
                    AddValueInLinkList();
                    Console.WriteLine("\t\tПоиск 496753-го элемента в LinkList");
                    SearchItems(ProgramHelpers.LinkList, ProgramHelpers.LinkList.GetType());
                    NoResidue(ProgramHelpers.LinkList, ProgramHelpers.LinkList.GetType(), 777);
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                ProgramHelpers.ArrayList.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"\tВремя заполнения ArrayList: {stopwatch.Elapsed}");
        }
        static void AddValueInLinkList()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                ProgramHelpers.LinkList.AddLast(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"\tВремя заполнения LinkList<int>: {stopwatch.Elapsed}");
        }
        static void SearchItems(object list, Type listType)
        {
            Stopwatch stopwatch = new Stopwatch();
            var type = listType.ToString();
            switch (type)
            {
                case "System.Collections.Generic.List`1[System.Int32]":
                    stopwatch.Start();
                    var forListCycle = list as List<int>;
                    for (int i = 0; i < forListCycle.Count; i++)
                    {
                        if (Math.Abs(i) == 496753)
                        {
                            stopwatch.Stop();
                            Console.WriteLine($"\t\t\tВремя поиска 496753-го элемента в List<int>: {stopwatch.Elapsed}");
                            break;
                        }
                    }                    
                    break;
                case "System.Collections.Generic.LinkedList`1[System.Int32]":
                    stopwatch.Start();
                    var forLinkedListcycle = list as LinkedList<int>;
                    var item = forLinkedListcycle.First;
                    for (int i = 0; i < forLinkedListcycle.Count; i++)
                    {
                        if (Math.Abs(i) == 496753)
                        {
                            stopwatch.Stop();
                            Console.WriteLine($"\t\t\tВремя поиска 496753-го элемента в LinkList: {stopwatch.Elapsed}");
                            break;
                        }
                        item = item.Next;
                    }
                    break;
                case "System.Collections.ArrayList":
                    stopwatch.Start();
                    var forArrayListCycle = list as ArrayList;
                    for (int i = 0; i < forArrayListCycle.Count; i++)
                    {
                        if (Math.Abs(i) == 496753)
                        {
                            stopwatch.Stop();
                            Console.WriteLine($"\t\t\tВремя поиска 496753-го элемента в List<int>: {stopwatch.Elapsed}");
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        static void NoResidue(object list, Type listType, int divisor)
        {
            Stopwatch stopwatch = new Stopwatch();
            var type = listType.ToString();
            switch (type)
            {
                case "System.Collections.Generic.List`1[System.Int32]":
                    var forListCycle = list as List<int>;
                    stopwatch.Start();
                    for (int i = 0; i < forListCycle.Count; i++)
                    {
                        if (forListCycle[i]%divisor == 0)
                            Console.WriteLine(forListCycle[i]);
                    }                    
                    break;
                case "System.Collections.Generic.LinkedList`1[System.Int32]":
                    stopwatch.Start();
                    var forLinkedListcycle = list as LinkedList<int>;
                    var item = forLinkedListcycle.First;
                    for (int i = 0; i < forLinkedListcycle.Count; i++)
                    {
                        if(item.Value%divisor==0)
                            Console.WriteLine(item.Value);
                        item = item.Next;
                    }
                    break;
                case "System.Collections.ArrayList":
                    stopwatch.Start();
                    var forArrayListCycle = list as ArrayList;
                    for (int i = 0; i < forArrayListCycle.Count; i++)
                    {
                        if((int)forArrayListCycle[i]%divisor == 0)
                            Console.WriteLine(forArrayListCycle[i]);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Время поиска чисел еоторые деляться без остатка на 777 {stopwatch.Elapsed}");
            stopwatch.Stop();
        }
    }
}
