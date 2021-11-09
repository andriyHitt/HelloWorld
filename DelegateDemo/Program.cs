using System;
using System.Linq;

namespace DelegateDemo
{
    class Program
    {
        delegate void Message();
        
        static Message MessaeEvent;

        static void ShowMessage()
        {
            Console.WriteLine("Hello World!");

        }

        delegate bool Compare(object a, object b);
        static object[] Sort(object[] source, Compare compare)
        {
            object[] result = source.ToArray();

            if (compare == null) throw new Exception();
            //object tmp;
            for(int i = 0; i < result.Length - 1; i++)
            {
                for(int j = i + 1; j < result.Length; j++)
                {
                    if (compare(result[i], result[j]))
                    {
                        object tmp = result[i];
                        result[i] = result[j];
                        result[j] = tmp;
                    }
                }
            }
            return result;
        }

        static bool CompareInt(object a, object b)
        {
            if (a == null || b == null) throw new ArgumentNullException();
            if((int)a > (int)b)
            {
                return true;
            }
            else
            return false;
        }

        static void Main(string[] args)
        {
            //Compare compare = delegate (object a, object b)
            //{
            //    if (a == null || b == null) throw new ArgumentNullException();
            //    if ((int)a > (int)b)
            //    {
            //        return true;
            //    }
            //    else
            //        return false;

            //};

            var sortedarray = Sort(new object[] { 5, 2, 4, 9, 8, 0 }, CompareInt);
            var sortedarray1 = Sort(new object[] { 6, 1, 0, 5, 7, 2 }, (a, b) => ((int)a > (int)b));
            var sortedarray2 = Sort(new object[] { 6.1, 1.2, 0.3, 5.5, 7.6, 2.1 }, (a, b) => ((double)a > (double)b));


            //Message message = ShowMessage;
            //message();

            foreach (var sort1 in sortedarray)
            {
                Console.Write($"{sort1} ");
            }
            Console.WriteLine();
            foreach (var sort2 in sortedarray1)
            {
                Console.Write($"{sort2} ");
            }
            Console.WriteLine();
            foreach (var sort3 in sortedarray2)
            {
                Console.Write($"{sort3} ");
            }

        }
    }
}
