using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string txt = File.ReadAllText("zavd.txt");

            var result = txt.Where(s => s >= 65 && s <= 90 || s >= 97 && s <= 122).ToArray().GroupBy(s => s).Select(c => new { symb = c.Key, count = c.Count() });

            foreach (var res in result)
            {
                Console.WriteLine(res);
                txt += $"\n{res}";
            }

            File.WriteAllText("ZavdSymbCountInText.txt", txt);


        }
        /*1. Підрахувати кількість символів кожгого виду за виключенням 
            розділових знаків.Вивести в файл результат в виглядs вхідного 
            тексту та результату підрахунку "буква" - кількість*/
    }
}
