using list;

public delegate void Record(int value);
public class Program
{

    private static void Main(string[] args)
    {
        Collection collection = new Collection()
        {
            Id = 65,
            Name = "Ade",
            Description = "Professional",
            Type = "TechSavy",

        };
        Collection collection1 = new Collection()
        {
            Id = 65,
            Name = "Ade",
            Description = "Professional",
            Type = "TechSavy",
        };



        //List<string> list = new List<string>();
        //list.Add("Adunni");
        //list.Add("Babalola");
        //list.Add("Comfort");
        //list.Add("Damilola");
        //list.Add("Emmanuel");

        //collections(list);
        //ilists(list);
        //listdisplay(list);

    }
    //    public static void collections(ICollection<string> collection)
    //    {
    //        collection.Add("Femi");
    //        foreach (string item in collection)
    //        {
    //            Console.WriteLine("The icollection element are :" +  item);
    //            Console.WriteLine("/////");
    //        }
    //    }
    //    public static void ilists(IList<string> list)
    //    {
    //        list.RemoveAt(0);
    //        foreach (string item in list)
    //        {
    //            Console.WriteLine("The ilist element are :" + item);
    //            Console.WriteLine("/////");
    //        }
    //    }
    //    public static void listdisplay(List<string> mylist)
    //    {
    //        //list consist of all the method, inheriting from oth ilist and icollection
    //        mylist.Sort();
    //        foreach (string item in mylist)
    //        {
    //            Console.WriteLine("The list element are :" + item);
    //        }
    //    }
}
