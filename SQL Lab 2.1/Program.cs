using System;

namespace SQL_Lab_2._1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var a = new DepartmentDbContext();
            var allow = true;
           
            while (allow)
            {
                Console.WriteLine("type '1' '2' '3' or '4' to enter database ");

                var input = Console.ReadLine().ToCharArray()[0];

                if (input == '1')
                {
                    foreach (var c in a.Developers)
                    {
                        Console.WriteLine($"{c.Name}, {c.Email}, {c.StartDate}");
                    }
                }
                Console.WriteLine();
                    if (input == '2')
                    {
                        foreach (var d in a.Clients)
                        {
                            Console.WriteLine($"Client Info {d.Id},{d.Name}");
                        }
                    }
                    Console.WriteLine();

                if (input == '3')
                {
                    foreach (var x in a.Projects)
                    {
                        Console.WriteLine($"Project: {x.Id},{x.Name}, Client {x.Client.Name}");
                    }
                    
                }

                if (input == '4')
                {
                    var billHours = 0f;
                    foreach (var x in a.Projects)
                    {
                        foreach (var k in a.TimeEntries)
                        {
                            if (k.Projects == x)
                            {
                                billHours += k.TimeSpent;
                            }
                            Console.WriteLine($"Client Name : { x.Name}, Billing Hours {billHours} ");
                            billHours = 0;
                        }
                    }
                }

                if (input >= 5)
                {
                    allow = false;
                }
                
            Console.ReadLine();



        }
            
        }
    }
}