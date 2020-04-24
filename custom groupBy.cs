using System;
using System.Collections.Generic;
using System.Linq;

namespace group
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Perison>() { };
            list.Add(new Perison { age = 1, id = 1, name = "jhon", brithday = DateTime.Now });
            list.Add(new Perison { age = 2, id = 1, name = "jhon2", brithday = DateTime.Now });
            list.Add(new Perison { age = 2, id = 1, name = "jhon2", brithday = DateTime.Now });
            list.Add(new Perison { age = 2, id = 2, name = "jhon2", brithday = DateTime.Now });

            var dic = new Dictionary<int, List<Perison>>();
            foreach (var item in list)
            {
                var newList = new List<Perison>();
                if (!dic.ContainsKey(item.age))
                {
                    newList.Add(item);
                    dic.Add(item.age, newList);
                }
                else
                {
                    var result = dic.FirstOrDefault(_=>_.Key==item.age);
                    result.Value.Add(item);
                }
            }

            Console.WriteLine("Hello World!");
            foreach (var item in dic)
            {
                System.Console.WriteLine(item.Key);
                foreach (var val in item.Value)
                {
                    System.Console.Write("  "+ val.id);
                    System.Console.Write("  "+ val.age);
                    System.Console.Write("  "+ val.name);
                    System.Console.WriteLine("  "+ val.brithday);
                }
            }

        }
    }
    class Perison
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public DateTime brithday { get; set; }
    }
}
