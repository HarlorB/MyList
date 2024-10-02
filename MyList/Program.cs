namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<Father>();
            list.Add(new Son());
            list.Add(new Daughter());
            for (int i = 0; i < list.Length; i++)
            {
                list[i].Foo();
            }
            
        }
    }

    public abstract class Father
    {
        public abstract void Foo();
    }

    class Son : Father
    {
        public override void Foo() => Console.WriteLine("Son's Foo");
    }

    class Daughter : Father
    {
        public override void Foo() => Console.WriteLine("Daughter's Foo");
    }
}


