namespace GenericScale
{
    public class StrtUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> scale = new(5, 5);
            //EqualityScale<int> scale = new EqualityScale<int>(5,5);

            Console.WriteLine(scale.AreEqual());
        }
    }
}