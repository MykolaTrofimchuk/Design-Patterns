using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class ExpertSupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 10)
            {
                Console.WriteLine("The issue was resolved at an expert level of support.");
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
