using DevBlog;

List<Blogger> Blg = new List<Blogger>();
menu:
    System.Console.WriteLine("Blogger Management");
    System.Console.WriteLine("Please Choose:");
    System.Console.WriteLine("1. Add Blog");
    System.Console.WriteLine("2. Edit Blog");
    System.Console.WriteLine("3. Delete Blog");
    System.Console.WriteLine("4. Display Info");
    string key = Console.ReadLine();
    switch (key)
    {
        case "1":
        {
            Blogger tmp = new Blogger();
            tmp.AddBlog(tmp);
            Blg.Add(tmp);
            break;
        }
        // case "2":
        // {
        //     Blogger tmp = new Blogger();
        //     tmp.AddBlog(tmp);
        //     Blg.Add(tmp);
        //     break;
        // }
        // case "3":
        // {
        //     Blogger tmp = new Blogger();
        //     tmp.AddBlog(tmp);
        //     Blg.Add(tmp);
        //     break;
        // }
        case "4":
        {
            for (var i = 0; i < Blg.Count; i++)
            {
                Blg[i].Display();
            }
            break;
        }
        default:
            break;
    }
    System.Console.WriteLine("wanna out ?");
    System.Console.WriteLine("1. Yes");
    System.Console.WriteLine("2. No");
    key = Console.ReadLine();
    switch (key)
    {
        case "1":
            break;
        default:
            goto menu;
    }
