namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(1);
            list.Insert(1,111);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Length);
        }
    }
}


