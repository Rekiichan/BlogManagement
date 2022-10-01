using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement
{
    internal class Menu : Blogger
    {
        public static void AddBlogger(List<Blogger> Blg)
        {
            Blogger blg = new Blogger();
            AddBlog(blg);
            Blg.Add(blg);
            Utility.UpdateToTextFile(_filePath, ref Blg);
        }
        public static void EditBlogger(List<Blogger> Blg)
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
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
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
            Utility.UpdateToTextFile(_filePath, ref Blg);
        }
        public static void DeleteBlogger(List<Blogger> Blg)
        {
            Console.Write("Choose the blog ID that you want to delete: ");
            Console.Write($"\nPlease enter the ID of blogger that you want to edit: ");
            Console.Write($"\nNumber      ID      Name\n");
            for (int i = 0; i < Blg.Count; i++)
            {
                Console.WriteLine($"{i + 1}           {Blg[i].ID}   {Blg[i].Name}");
            }
            Console.Write("Your Choose: ");
            int KeyID = Convert.ToInt32(Console.ReadLine());
            KeyID--;
            Blg.RemoveAt(KeyID);
            Utility.UpdateToTextFile(_filePath, ref Blg);
        }
        public static void DisplayBlogger(List<Blogger> Blg)
        {
            Blg = Utility.ReadToTextFile(Blogger._filePath);
            Console.WriteLine($"No.  ID      Name            Phone      Birthday   Email       RegistrationDate  Gender  Address");
            for (var i = 0; i < Blg.Count; i++)
            {
                Console.WriteLine($"{i + 1}    {Blg[i].ID}   {Blg[i].Name}            {Blg[i].Phone}           {Blg[i].BirthDate.ToString("MM/dd/yyyy")}   {Blg[i].Email}            {Blg[i].RegistrationDate.ToString("MM/dd/yyyy")}  {Blg[i].Gender}  {Blg[i].Address}");
            }

        }
    }
}
