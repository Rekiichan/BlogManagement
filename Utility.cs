using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement
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

        public static List<Blogger> ProcessString(string str)
        {
            List<Blogger> blg = new List<Blogger>();
            string[] BlogList = str.Split('\n');
            for (int i = 0; i < BlogList.Length; i++)
            {
                if (BlogList[i].Length > 5)
                {
                    var Blog = BlogList[i].Split(", ");
                    int id = Convert.ToInt32(Blog[0].ToString());
                    string name = Blog[1].ToString();
                    string phone = Blog[2];
                    var tmp = Blog[3].ToString().Split("/");
                    DateTime birth =
                        new DateTime(Convert.ToInt32(tmp[2]),
                            Convert.ToInt32(tmp[0]),
                            Convert.ToInt32(tmp[1]));
                    string email = Blog[4].ToString();
                    tmp = Blog[5].ToString().Split("/");
                    DateTime registDate =
                        new DateTime(Convert.ToInt32(tmp[2]),
                            Convert.ToInt32(tmp[0]),
                            Convert.ToInt32(tmp[1]));
                    string gender = Blog[6].ToString();
                    string address = Blog[7].ToString();
                    blg.Add(new Blogger(id, name, phone, birth, email, registDate, gender, address));
                }
            }
            return blg;
        }

        public static List<Blogger> ReadToTextFile(string path)
        {
            List<Blogger> Blg = new List<Blogger>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(path))
                {
                    var data = sr.ReadToEnd();
                    Blg = ProcessString(data);
                    return Blg;
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return Blg;
            }
        }
    }
}
