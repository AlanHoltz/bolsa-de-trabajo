using System;
using System.Collections.Generic;

namespace Bolsa.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            /* String resp = "";
            int opcion = 0;
            do
            {
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Menu2("Personas");
                        opcion = Int32.Parse(Console.ReadLine());

                        String mail;
                        String password;
                        DateTime signupDate;
                        String name;
                        String surname;
                        DateTime birthDate;
                        Entities.Person person;
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Alta");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese mail");
                                mail = Console.ReadLine();
                                Console.WriteLine("Ingrese password");
                                password = Console.ReadLine();
                                signupDate = DateTime.Now;
                                Console.WriteLine("Ingrese nombre");
                                name = Console.ReadLine();
                                Console.WriteLine("Ingrese apellido");
                                surname = Console.ReadLine();
                                birthDate = new DateTime(2020, 06, 01);
                                person = new Entities.Person(mail, password, signupDate, name, surname, "", "", false, birthDate);
                                
                                Business.Person.Insert(person);
                                break;
                            case 2:
                                Console.WriteLine("Baja");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese id");
                                int id = Int32.Parse(Console.ReadLine());
                                person = new Entities.Person();
                                person.Id = id;
                                
                                Business.Person.Delete(person);
                                break;
                            case 3:
                                Console.WriteLine("Modificacion");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese id");
                                id = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese mail");
                                mail = Console.ReadLine();
                                Console.WriteLine("Ingrese password");
                                password = Console.ReadLine();
                                signupDate = DateTime.Now;
                                Console.WriteLine("Ingrese nombre");
                                name = Console.ReadLine();
                                Console.WriteLine("Ingrese apellido");
                                surname = Console.ReadLine();
                                birthDate = new DateTime(2020, 06, 01);
                                person = new Entities.Person(mail, password, signupDate, name, surname, "", "", false, birthDate);
                                
                                Business.Person.Update(person);
                                break;
                            case 4:
                                Console.WriteLine("Consulta");
                                Console.WriteLine();
                                List<Entities.Person> persons = Business.Person.GetAll();

                                foreach(Entities.Person personFor in persons)
                                {
                                    Console.WriteLine(personFor.Id);
                                    Console.WriteLine(personFor.Mail);
                                    Console.WriteLine(personFor.Password);
                                    Console.WriteLine(personFor.Date);
                                    Console.WriteLine(personFor.Name);
                                    Console.WriteLine(personFor.Surname);
                                    Console.WriteLine(personFor.Photo);
                                    Console.WriteLine(personFor.Cv);
                                    Console.WriteLine(personFor.BirthDate);
                                }

                                break;
                        }
                        break;
                }
                resp = Console.ReadLine();
            } while (resp != "N"); */
        }
        
        static void Menu2(String name)
        {
            Console.WriteLine("--------------");
            Console.WriteLine(name);
            Console.WriteLine("--------------");
            Console.WriteLine("1: Alta");
            Console.WriteLine("2: Baja");
            Console.WriteLine("3: Modificacion");
            Console.WriteLine("4: Consulta");
            Console.WriteLine("--------------");
        }
    }
}
