namespace SingletonDP
{
    public class Card
    {

        // Singleton Design Pattern

        /// 1- Using Private Constructor
        private static Card instance;
        //public int Data { get; set; }
        //public static Card Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Card();
        //        }
        //        return instance;
        //    }
        //}
        private Card() { }

        /// 2- Using Static Constructor (static constructor only runs once)

        static Card() {
            instance = new Card();
        }
        public static Card GetInstance()
            => Instant;

        /// 3- Using Static Readonly Property
            public  readonly static Card Instant =new Card();

    }
}