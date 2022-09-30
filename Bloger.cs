using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement
{
    public class Blogger : IBlogger
    {

        public static string _filePath = "D:\\visualWorkspace\\BlogManagement\\BlogManagement\\BlogRecord.txt";

        public int ID { set; get; }

        public string? Name { set; get; }

        public string? Phone { set; get; }

        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string? Gender { get; set; }

        public string? Address { set; get; }

        public Blogger()
        { }
        public Blogger(int _id, string _name, string _phone, DateTime _BirthDate, string _email,
                        DateTime _registrationDate, string _gender, string _address)
        {
            Blogger blg = new Blogger();
            int _ID = Convert.ToInt32(_id);
            ID = _ID;
            Name = _name;
            Phone = _phone;
            BirthDate = _BirthDate;
            Email = _email;
            RegistrationDate = _registrationDate;
            Gender = _gender;
            Address = _address;
        }
        public void AddBlog(Blogger blg)
        {
            Random r = new Random();
            blg.ID = r.Next(10000, 100000);

            System.Console.WriteLine($"Enter Name: ");
            blg.Name = Console.ReadLine();

            System.Console.WriteLine($"Enter Phone: ");
            blg.Phone = Console.ReadLine();

            System.Console.WriteLine($"Enter BirthDate: ");
            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            blg.BirthDate = new DateTime(year, month, day);

            System.Console.WriteLine($"Enter Email: ");
            blg.Email = Console.ReadLine();

            System.Console.WriteLine($"Enter Registration Date: ");
            Console.Write("Enter a month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());
            blg.RegistrationDate = new DateTime(year, month, day);

            System.Console.Write($"Enter Gender: ");
            blg.Gender = Console.ReadLine();

            System.Console.Write($"Enter Address: ");
            blg.Address = Console.ReadLine();

            Utility.WriteToTextFile(_filePath, blg);
        }

        public List<Blogger> Sort(List<Blogger> listBloggers, string sortType)
        {
            if (sortType == "Name")
            {
                List<Blogger> list = new List<Blogger>(listBloggers);
                for (var i = 0; i < listBloggers.Count; i++)
                {
                    list.Add(listBloggers[i]);
                }
                for (int i = list.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (list[j].Equals(list[j + 1]))
                        {
                            var tmp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = tmp;

                            Blogger nameLists = listBloggers[j];
                            listBloggers[j] = listBloggers[j + 1];
                            listBloggers[j + 1] = nameLists;
                        }
                    }
                }
            }
            else
            {
                DateTime[] list = new DateTime[listBloggers.Count];

                //Adding registration dates of the bloggers to the list
                for (var i = 0; i < listBloggers.Count; i++)
                {
                    list[i] = listBloggers[i].RegistrationDate;
                }

                //implementing bubble sort algorithm
                for (int i = list.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        //comparing the registration dates of bloggers from the list with each other
                        if (list[j].CompareTo(list[j + 1]) > 0)
                        {
                            //swapping if current element is greater than next element
                            DateTime registerDate = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = registerDate;

                            //swapping the whole list of blogger in ascending order according to the blogger registration date
                            Blogger regDateList = listBloggers[j];
                            listBloggers[j] = listBloggers[j + 1];
                            listBloggers[j + 1] = regDateList;
                        }
                    }
                }
            }
            // returns the sorted list
            return listBloggers;
        }
        public static void Display(Blogger blg)
        {
            System.Console.WriteLine($"ID: {blg.ID}");
            System.Console.WriteLine($"Name: {blg.Name}");
            System.Console.WriteLine($"Birthday: {blg.BirthDate.ToString("MM/dd/yyyy")}");
            System.Console.WriteLine($"Phone: {blg.Phone}");
            System.Console.WriteLine($"Registration Date: {blg.RegistrationDate.ToString("MM/dd/yyyy")}");
            System.Console.WriteLine($"Email: {blg.Email}");
            System.Console.WriteLine($"Gender: {blg.Gender}");
            System.Console.WriteLine($"Address: {blg.Address}");
        }
    }
}
