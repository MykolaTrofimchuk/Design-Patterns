using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_singleton
{
    public class Authenticator
    {
        private static Authenticator instance;
        private static readonly object lockObject = new object();

        private Authenticator() { }

        public static Authenticator GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Authenticator();
                }
                return instance;
            }
        }
    }
}
