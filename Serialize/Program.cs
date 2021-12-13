using SerializeDemo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new ClassA
            //{
            //    Age = 21,
            //    FirstName = "Alise",
            //    LastName = "Dunli",
            //    IsAlive = false,
            //    Address = new Address()
            //    {
            //        City = "Uzhgorod",
            //        State = "Transcarpatia",
            //        PostalCode = "88015",
            //        StreetAddress = "Lenina 60"
            //    },

            //};

            //var json = System.Text.Json.JsonSerializer.Serialize(test);
            ////Console.WriteLine(json);
            //File.WriteAllText("test.json", json);

            //var rjs = File.ReadAllText("test.json");
            //var newtest = System.Text.Json.JsonSerializer.Deserialize<ClassA>(rjs);

            //var nrjs = File.ReadAllText("testB.json");

            //var testB = new ClassB();


            //if (File.Exists("testB.json"))
            //{
            //    var nrjs = File.ReadAllText("testB.json");
            //    Console.WriteLine("It's previous value was input is:");
            //    var newTestB = System.Text.Json.JsonSerializer.Deserialize<ClassB>(nrjs);
            //    Console.WriteLine(newTestB);
            //}

            //Console.Write("Enter First name:");
            //testB.FirstName = Console.ReadLine();

            //Console.Write("Enter Last name:");
            //testB.LastName = Console.ReadLine();

            //testB.SaveDate = DateTime.Now;

            //var jsonB = System.Text.Json.JsonSerializer.Serialize(testB);
            //File.WriteAllText("testB.json", jsonB);

            var testC = new List<ClassB>();

            if (File.Exists("testC.json"))
            {
                var nrjsC = File.ReadAllText("testC.json");
                Console.WriteLine("It's previous values was input is:");
                testC = System.Text.Json.JsonSerializer.Deserialize<List<ClassB>>(nrjsC);
                foreach(var test in testC)
                {
                    Console.WriteLine(test);
                }
            }

            var res = new ClassB();
            Console.Write("Enter First name:");
            res.FirstName = Console.ReadLine();

            Console.Write("Enter Last name:");
            res.LastName = Console.ReadLine();

            res.SaveDate = DateTime.Now;
            testC.Add(res);

            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonC = System.Text.Json.JsonSerializer.Serialize(testC, options);
            File.WriteAllText("testC.json", jsonC);

        }
    }
}
