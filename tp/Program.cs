using System;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

namespace tp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Class_test()
            {
                id = 1,
                is_look = true,
                number = 7887,
                title = "Название"
            };
            var f = new XmlSerializer(typeof(Class_test));
            using(var fs = new FileStream($"{test.title}.xml", FileMode.OpenOrCreate))
            {
                f.Serialize(fs, test);
            }

            using (var fs = new FileStream($"{test.title}.xml", FileMode.OpenOrCreate))
            {
                var test_des = (Class_test)f.Deserialize(fs);
                Console.WriteLine(test);
                Console.WriteLine(test_des);
            }
            
            // var docLoad = new System.Xml.Linq.XDocument.Load("Названиею.xml");
            List<Class_test> list_test = new List<Class_test>();
            for (int i = 0; i < 100; i++)
            {
                list_test.Add(new Class_test()
                {
                    id = i,
                    is_look = (i % 2 == 0),
                    number = i + 23,
                    title = $"Название {i}"
                });
            }

            var st = list_test
                .Where(x => x.is_look && x.id > 20)
                .OrderByDescending(x => x.number)
                .Select(x => x.title);

            Console.WriteLine(st);

        }
    }
}
