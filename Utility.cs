using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace DevBlog
{
    public class Utility
    {
        public static void WriteToTextFile(string path, Blogger data)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(data.ID);
                writer.Write(",");
                writer.Write(data.Name);
                writer.Write(",");
                writer.Write(data.Phone);
                writer.Write(",");
                writer.Write(data.BirthDate.ToString("MM/dd/yyyy"));
                writer.Write(",");
                writer.Write(data.Email);
                writer.Write(",");
                writer.Write(data.RegistrationDate.ToString("MM/dd/yyyy"));
                writer.Write(",");
                writer.Write(data.Gender);
                writer.Write(",");
                writer.Write(data.Address);
                writer.Write("\n");
            }
        }
        public static void ProcessString(string str)
        {
            List<Blogger> blg = new List<Blogger>();
            string[] BlogList = str.Split('\n');
            for (int i = 0; i < BlogList.Length; i++)
            {
                if (BlogList[i].Length > 1)
                {
                    var Blog = BlogList[i].Split(',');
                    System.Console.WriteLine(BlogList[i]);
                }
            }
                System.Console.WriteLine(BlogList.Length);
        }
        public static string ReadToTextFile(string path)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(path))
                {
                    var data = sr.ReadToEnd();
                    List<Blogger> Blg = new List<Blogger>();
                    // while (data.Length > 0)
                    // {
                    ProcessString(data);
                    // int ID = Convert.ToInt32()
                    // Blg.Add()
                    // Blg[0].Display();
                    // }

                    return data;
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
