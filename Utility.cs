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
                writer.WriteLine();
            }
        }
    }
}
