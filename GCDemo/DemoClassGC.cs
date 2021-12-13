using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class DemoClassGC : IDisposable
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int GroupID { get; set; }
        private bool _disposed = false;

        ~DemoClassGC() 
        { 
            Console.WriteLine($"{GroupID}");
            Dispose();
        }

        public void Dispose()
        {
           if(!_disposed)
            {
                // disposed resurse
                _disposed = true;
            }
        }
    }
}
