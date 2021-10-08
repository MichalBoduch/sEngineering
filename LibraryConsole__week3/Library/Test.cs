using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole__week3.Library
{
    // Szymon to Software Engineer
    public class Test
    {
        static void Main(string[] args)
        { User user = new User();
            user.UserID = 123456;
            user.Name = "AdMiNiStRaToE";
            user.CreateTime = DateTime.Now;

            Console.WriteLine(user.ViewUserAccount());
            Console.ReadLine();

        }
    }
}
