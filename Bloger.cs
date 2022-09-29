
using Newtonsoft.Json;

namespace DevBlog
{
    public class Blogger
    {
        
        private string _filePath = "BlogRecord.json";

        private int ID { set; get; }

        private string? Name { set; get; }

        private string? Phone { set; get; }

        private DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string? Gender { get; set; }

        private string? Address { set; get; }

        public void Add(Blogger std)
        {
            Random r = new Random();
            std.ID = r.Next(10000, 100000);

            System.Console.WriteLine($"Enter Phone: ");
            Phone = Console.ReadLine();

            System.Console.WriteLine($"Enter BirthDate: ");
            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            BirthDate = new DateTime(year, month, day);

            System.Console.WriteLine($"Enter Email: ");
            Email = Console.ReadLine();

            System.Console.WriteLine($"Enter Registration Date: ");
            Console.Write("Enter a month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());
            RegistrationDate = new DateTime(year, month, day);

            System.Console.WriteLine($"Enter Gender: ");
            Gender = Console.ReadLine();

            System.Console.WriteLine($"Enter Address: ");
            Address = Console.ReadLine();
        }
        public List<Blogger> Sort(List<Blogger> listBloggers, string sortType)
        {
            if (sortType == "First Name")
            {
                string[] list = new string[listBloggers.Count];

                //Adding names of the bloggers to the list
                for (var i = 0; i < listBloggers.Count; i++)
                {
                    list[i] = listBloggers[i].Name;
                }

                //implementing bubble sort algorithm
                for (int i = list.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        //comparing the names from the list with each other
                        if (list[j].CompareTo(list[j + 1]) > 0) 
                        {
                            //swapping names if current element is greater than next element
                            string name = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = name;

                            //swapping the whole list of bloggers in ascending order according to the name 
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

        public List<Blogger> List()
        {
            string objList = Utility.ReadFromTextFile(_filePath);
            if (objList != null)
            {
                List<Blogger> lst = JsonConvert.DeserializeObject<List<Blogger>>(objList);
                return lst;
            }
            else
            {
                return null;
            }
        }

        public void Display()
        {
            System.Console.WriteLine($"ID: {ID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine(BirthDate.ToString("MM/dd/yyyy"));
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine(RegistrationDate.ToString("MM/dd/yyyy"));
            System.Console.WriteLine($"Email: {Email}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Address: {Address}");
            System.Console.WriteLine($"Address: {Address}");
        }
    }
}
