namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Company company = new Company()
            {
                CompanyName = "Backend Developers in Azerbaijan"
            };
            string input;
            do
            {
                Console.WriteLine("                          ===============================MENU===============================");
                Console.WriteLine("1. Register a user");
                Console.WriteLine("2.Login a user)");
                Console.WriteLine("3. See All users in a Company");
                Console.WriteLine("4. Get One User by Username");
                Console.WriteLine("5. Update User's data");
                Console.WriteLine("  a. Update Name");
                Console.WriteLine("  b. Update Surname");
                Console.WriteLine("  c. Update Username");
                Console.WriteLine("  d. Update Email");
                Console.WriteLine("6. Delete User from Company");
                Console.WriteLine("7. Exit");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Name Enter= ");
                        user.Name = Console.ReadLine();
                        Console.Write("Surname Enter= ");
                        user.SurName = Console.ReadLine();
                        Console.Write("Password Enter= ");
                        user.Password = Console.ReadLine();
                        company.Register(user);
                        break;
                    case "2":
                        USER:
                        Console.WriteLine("username enter= ");
                        user.UserName = Console.ReadLine();
                        if(user.UserName != null)
                        {
                            PASS:
                            Console.WriteLine("pass enter= ");
                            user.Password =  Console.ReadLine();
                            if (user.Password != null)
                            {
                                Console.WriteLine("daxiloldunuz");
                            }
                            else
                            {
                                Console.WriteLine("pass yanlisdir");
                                goto PASS;
                            }
                        }
                        else
                        {
                            Console.WriteLine("username duzgun daxilet");
                            goto USER;
                        }
                        break;
                }


            } while (true);
        }
    }
}