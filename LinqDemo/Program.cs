using System;
using System.IO;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = File.ReadAllText("task.txt");
            string[] txt1 = txt.Split(' ',',','(',')','-','.',';',':','/','=','\n','\r');
            string[] txt2 = txt1.Where(s => s.Length > 1 && !Char.IsDigit(s.First())).Distinct().ToArray();
            var ui = txt2.Count();
            var uu = txt2.GroupBy(s => s).Select(w => new { word = w.Key, count = w.Count() }).ToArray();
            Console.WriteLine(ui);

            foreach(var uuu in uu)
            {
                Console.WriteLine(uuu);
            }
            FIOI[] peoples2 = new FIOI[]
            {
                new  FIOI("Ivan", "Ivanovich","Ivanov"),
                new  FIOI("Petro", "Petrovich","Ivanov"),
                new  FIOI("Semen", "Semenovich","Ivanov"),
                new  FIOI("Ivan", "Ivanovich","Petrenko"),
                new  FIOI("Petro", "Petrovich","Petrenko"),
                new  FIOI("Semen", "Semenovich","Petrenko"),
                new  FIOI("Ivan", "Ivanovich","Semenenko"),
                new  FIOI("Petro", "Petrovich","Semenenko"),
                new  FIOI("Semen", "Semenovich","Semenenko"),
                new  FIOI("Ivan", "Ivanovich","Nazarenko"),
                new  FIOI("Petro", "Petrovich","Nazarenko"),
                new  FIOI("Semen", "Semenovich","Nazarenko"),
            };


            CarsFIOI[] cars = new CarsFIOI[]
            {
                new CarsFIOI("Abdulov", 5),
                new CarsFIOI("Geyts", 150),
                new CarsFIOI("Putin", 70),
                new CarsFIOI("Ivanov", 5),
                new CarsFIOI("Nazarenko", 15)
            };

            
            var c = cars.Count();
            var max = cars.Max(s => s.Count);
            var min = cars.Min(s => s.Count);
            var sum = cars.Sum(s => s.Count);
            var exist = cars.Contains(new CarsFIOI("Abdulov", 5));
            var all = cars.All(item => item.Count == 15);
            var any = cars.Any(item => item.Count == 15);

            //var rc = peoples2.Skip(1).Take(2);
            //var cc = peoples2.GroupBy(s => s.Surname);
            //var rc = peoples2.First(s => s.Name == "Semen");
            //var rc = peoples2.FirstOrDefault(s => s.Name == "Semen");
            //var rc = peoples2.SingleOrDefault(s => s.Name == "Ivan"); // exept becouse more "Ivan"
            string[] st = new string[] { "Ivan", "Petro", "Semen", "Guliana", "Mariana", "Pavlo", "Petro", "Guliana", "Danilo" };
            
            string[] st2 = new string[] { "Ivan", "Petro", "Semen", "Guliana", "Mariana", "Pavlo", "Petro", "Guliana" };

            //var rc = st.Distinct();
            //var rc = cars.DistinctBy(s => s.Count); // for 6 .Net
            //var rc = st.Except(st2); // унікальне з 2-х
            //var rc = st.Intersect(st2); // присуттні у 2-х колекціях
            var rc = st.Union(st2); // вибере і обєднає


            //foreach (var ii in rc)
            //{
            //    Console.WriteLine(ii);
            //}
            //var rc = cars.Zip(peoples2);
            //var rc = peoples2.Zip(cars);

            //var rc = from person in peoples2
            //         join carFio in cars on person.Surname equals carFio.Surname
            //         select new { person.Name, person.SecondName, person.Surname, carFio.Count };

            //foreach (var peoples in rc)
            //{
            //    Console.WriteLine(peoples);
            //}

            //foreach (var peoples in cc)
            //{
            //    Console.WriteLine(peoples);
            //}

            //foreach((FIOI fio, CarsFIOI car) in rc)
            //{
            //    Console.WriteLine($"{fio} {car}");
            //}

            //FIO[] peoples = new FIO[]
            //{
            //    new FIO("Петренко","Іван","Іванович"),
            //    new FIO("Кравчук","Микола","Миколайович"),
            //    new FIO("Петренко","Микола","Степанович"),
            //    new FIO("Шевчук","Валентин","Миколайович"),
            //    new FIO("Марчук","Микола","Степанович"),
            //    new FIO("Петренко","Ігор","Валентинович"),
            //    new FIO("Козлюк","Микола","Валерійович"),
            //    new FIO("Пінчук","Микола","Миколайович"),
            //    new FIO("Самчук","Микола","Миколайович"),
            //    new FIO("Вознюк","Микола","Миколайович")
            //};

            //var fio = peoples.Where(s => s.Surname.StartsWith("Петренко")).OrderBy(s => (s.Name, s.SecondName));

            //foreach(var ff in fio)
            //{
            //    Console.WriteLine(ff);
            //}

            //Console.WriteLine();

            //var fio_1 = from s in peoples where s.Surname == "Петренко" orderby s.Name, s.SecondName select s;
            //foreach (var ff_1 in fio_1)
            //{
            //    Console.WriteLine(ff_1);
            //}

            //Console.WriteLine();

            //foreach (var ff_1 in fio_1)
            //{
            //    Console.WriteLine($"{ff_1.Surname} {ff_1.Name} {ff_1.SecondName}");
            //}

            //var fio_2 = from s in peoples where s.Surname == "Петренко" orderby s.Name select new { s.Surname, s.Name };

            //Console.WriteLine();

            //foreach (var ff_2 in fio_2)
            //{
            //    Console.WriteLine($"{ff_2.Surname} {ff_2.Name}");
            //}

            //const string WrongSymbols = ";,<,>";
            //string[] st_1 = new string[] { "Ivan;", "Petro<", "Semen", "Guliana", "Mar>ian","Pavlo" };
            ////var wrSymb = from s in st_1 where s.Where   select s;
            //var wrSymb_1 = st_1.Where(s => s.Where(ss => WrongSymbols.Contains(ss)).Count() != 0).ToArray();

            //Console.WriteLine();

            //foreach (var wr in wrSymb_1)
            //{
            //    Console.WriteLine(wr);
            //}


            //string[] st = new string[] { "Ivan", "Petro", "Semen", "Gulia", "Maria","Pavlo" };

            //var l = from s in st where s.StartsWith('P') select s;
            //var lL = from s in st where s.StartsWith('P') || s.StartsWith('p') select s;

            //var ls = from s in st orderby s select s;
            //var lsd = from s in st orderby s descending select s;
            //var lsL = from s in st orderby s.Length descending select s;

            //var sortL = from s in st where s.EndsWith('n') orderby s.Length select s;
            //var sortLS = st.Where(s => s.EndsWith('n')).OrderBy(s => s.Length);

            //var lS = st.OrderByDescending(s => s.Length);

            //var m1 = l.ToArray();

            //var m2 = st.Where(s => s.StartsWith('P')).ToArray();

            //var m3 = st.Where(s => s.EndsWith('n')).ToArray();

            //var an = new { Name = "Semen", FirstName = "Semenchenko" };

            //foreach(var l1 in l)
            //{
            //    Console.WriteLine(l1);
            //}

            //Console.WriteLine();

            //foreach(var m in m3)
            //{
            //    Console.WriteLine(m);
            //}

            //Console.WriteLine();

            //foreach (var lss in ls)
            //{
            //    Console.WriteLine(lss);
            //}

            //Console.WriteLine();

            //foreach (var SL in sortL)
            //{
            //    Console.WriteLine(SL);
            //}

            //Console.WriteLine();

            //foreach (var SLS in sortLS)
            //{
            //    Console.WriteLine(SLS);
            //}
        }
        //record FIO(string Surname, string Name, string SecondName);
        record FIOI(string Name, string Surname, string SecondName);
        record CarsFIOI(string Surname, int Count);
    }
}
