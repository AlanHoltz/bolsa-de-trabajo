using System;
using System.Collections.Generic;

namespace Bolsa.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entities.User> users = Business.User.GetAll();

            foreach(Entities.User user in users)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user);
            }
        }
    }
}
