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
            Console.WriteLine("Blogger Management");
            Console.WriteLine("Please Choose:");
            Console.WriteLine("1. Add Blog");
            Console.WriteLine("2. Edit Blog");
            Console.WriteLine("3. Delete Blog");
            Console.WriteLine("4. Display Info");
            Console.WriteLine("----------------------------------");
            Console.Write("Please Choose: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    {
                        Menu.AddBlogger();
                        Utility.UpdateToTextFile(Blogger._filePath, ref Blg);
                        break;
                    }
                case 2:
                    {
                        Menu.EditBlogger(Blg);
                        break;
                    }
                case 3:
                    {
                        Menu.DeleteBlogger(Blg);
                        break;
                    }
                case 4:
                    {
                        Menu.DisplayBlogger(Blg);
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine("Wanna out ?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
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