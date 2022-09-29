
using Newtonsoft.Json;

namespace DevBlog
{
    public class Blogger
    {
        
        private string _filePath = "student.json";

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
