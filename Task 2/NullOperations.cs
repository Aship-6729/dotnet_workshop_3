using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperations
    {
        public static void PerformNullCheck()
        {

            string username = null;
            string value1 = (username == null ? "Username is not available" : $"Username is {username}");
            Console.WriteLine(value1);
        
            
            string value2 = username ?? "Username is not available"; // if username is null it will return the message only.
            //Console.WriteLine($"Null-coalescing Operators Username {value2}");

            username ??= "DefaultUser"; // if user is null it will assign as a defauluser.
            Console.WriteLine($"After Null-coalescing assignment operator Username is {username}");
        }
    }
}
