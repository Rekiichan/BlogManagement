namespace BlogManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Blogger> Blg = new List<Blogger>();
            Blg = Utility.ReadToTextFile(Blogger._filePath);
        menu:
            Console.WriteLine("\n----------------------------------");
            System.Console.WriteLine("Blogger Management");
            System.Console.WriteLine("Please Choose:");
            System.Console.WriteLine("1. Add Blog");
            System.Console.WriteLine("2. Edit Blog");
            System.Console.WriteLine("3. Delete Blog");
            System.Console.WriteLine("4. Display Info");
            System.Console.WriteLine("5. Read file");
            Console.WriteLine("----------------------------------");
            Console.Write("Please Choose: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    {
                        Blogger tmp = new Blogger();
                        tmp.AddBlog(tmp);
                        Blg.Add(tmp);
                        break;
                    }
                case 2:
                    {
                        Console.Write($"\nPlease enter the ID of blogger that you want to edit: ");
                        Console.Write($"\nID      Name\n");
                        for (int i = 0; i < Blg.Count; i++)
                        {
                            Console.WriteLine($"{Blg[i].ID}   {Blg[i].Name}");
                        }
                        Console.Write("Your Choose: ");
                        int KeyID = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < Blg.Count; i++)
                        {
                            if (Blg[i].ID == KeyID)
                            {
                                string? EditKey;
                                Console.WriteLine("Edit ID? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new ID: ");
                                    Blg[i].ID = Convert.ToInt32(Console.ReadLine());

                                }
                                Console.WriteLine("Edit Name? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Name: ");
                                    Blg[i].Name = Console.ReadLine();

                                }
                                Console.WriteLine("Edit Phone? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Phone: ");
                                    Blg[i].Phone = Console.ReadLine();

                                }
                                Console.WriteLine("Edit Birthdate? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.WriteLine("Press new Birthday: ");
                                    Console.Write("Month: ");
                                    int month = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Day: ");
                                    int day   = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Year: ");
                                    int year  = Convert.ToInt32(Console.ReadLine());
                                    Blg[i].BirthDate.AddYears(year);
                                    Blg[i].BirthDate.AddMonths(month);
                                    Blg[i].BirthDate.AddDays(day);

                                }
                                Console.WriteLine("Edit Email? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Email: ");
                                    Blg[i].Email = Console.ReadLine();
                                }
                                Console.WriteLine("Edit Registration Date? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Registration Date: ");
                                    Console.Write("Month: ");
                                    int month = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Day: ");
                                    int day = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Year: ");
                                    int year = Convert.ToInt32(Console.ReadLine());
                                    Blg[i].RegistrationDate.AddYears(year);
                                    Blg[i].RegistrationDate.AddMonths(month);
                                    Blg[i].RegistrationDate.AddDays(day);
                                }
                                Console.WriteLine("Edit Gender? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Gender: ");
                                    Blg[i].Gender = Console.ReadLine();
                                }
                                Console.WriteLine("Edit Address? (Press (Enter) to pass or Press (Y) for edit)");
                                EditKey = Console.ReadLine();
                                if (EditKey == "Y")
                                {
                                    Console.Write("Press new Address: ");
                                    Blg[i].Address = Console.ReadLine();
                                }
                            }
                        }
                        Utility.UpdateToTextFile(Blogger._filePath, ref Blg);
                        break;
                    }
                // case 3:
                // {
                //     Blogger tmp = new Blogger();
                //     tmp.AddBlog(tmp);
                //     Blg.Add(tmp);
                //     break;
                // }
                case 4:
                    {
                        Blg = Utility.ReadToTextFile(Blogger._filePath);
                        for (var i = 0; i < Blg.Count; i++)
                        {
                            Blogger.Display(Blg[i]);
                        }
                        break;
                    }
                case 5:
                    {
                        var data = Utility.ReadToTextFile(Blogger._filePath);
                        // System.Console.WriteLine(data);
                        break;
                    }
                default:
                    break;
            }
            System.Console.WriteLine("wanna out ?");
            System.Console.WriteLine("1. Yes");
            System.Console.WriteLine("2. No");
            Console.Write("Please Choose: ");
            key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    break;
                case 2:
                    goto menu;
            }
        }
    }
}