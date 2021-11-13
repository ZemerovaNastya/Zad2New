using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("file.txt");
            List<People> people = new List<People>();
            try
            {
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] st = str.Split(' ');
                    people.Add(new People() { F = st[0], I = st[1], O = st[2], age = st[3], ves = st[4] });
                }
            }
            catch { Console.WriteLine("Файл содержит неправильный тип данных!"); }
            foreach (var item in people.Where(d => Convert.ToInt32(d.age) %3 == 0))
                Console.WriteLine($"{item.F} {item.I} {item.O} {item.age} {item.ves}");
        }
    }
}
