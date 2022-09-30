using DevBlog;

List<Blogger> Blg = new List<Blogger>();
menu:
    System.Console.WriteLine("Blogger Management");
    System.Console.WriteLine("Please Choose:");
    System.Console.WriteLine("1. Add Blog");
    System.Console.WriteLine("2. Edit Blog");
    System.Console.WriteLine("3. Delete Blog");
    System.Console.WriteLine("4. Display Info");
    System.Console.WriteLine("5. Read file");
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
        // case 2:
        // {
        //     Blogger tmp = new Blogger();
        //     tmp.AddBlog(tmp);
        //     Blg.Add(tmp);
        //     break;
        // }
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
    key = Convert.ToInt32(Console.ReadLine());
    switch (key)
    {
        case 1:
            break;
        case 2:
            goto menu;
    }
