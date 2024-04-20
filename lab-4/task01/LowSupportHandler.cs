using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class LowSupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 2)
            {
                Console.WriteLine("The issue was resolved at a low level of support.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Error: The problem could not be resolved.");
                Console.WriteLine("Try entering the problem level again:");
                level = Convert.ToInt32(Console.ReadLine());
                HandleRequest(level);
            }
        }
    }
}
