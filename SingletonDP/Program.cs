namespace SingletonDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Card c1=Card.Instance;
            //c1.Data = 20;
            //Card c2 = Card.Instance;
            //c2.Data = 10;
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());
            //Console.WriteLine("/////////////////////////////");
            //Console.WriteLine("C1"+c1.Data);
            //Console.WriteLine("C2" + c2.Data);

            Card c1 = Card.GetInstance();
            Card c2 = Card.GetInstance();
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());

        }
    }
}
