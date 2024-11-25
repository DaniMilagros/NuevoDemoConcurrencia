using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcurrencia
{
    internal class Singleton
    {
        private static Singleton instance = null;
        private static readonly object bloqueo = new object();
        public Singleton()
        {
            
        }
        public static Singleton Instance
        {
            get
            {
                lock (bloqueo)
                {
                    if (instance == null)
                    { 
                        instance = new Singleton();
                    }
                    return instance;

                }
            }
        }
    }
}
