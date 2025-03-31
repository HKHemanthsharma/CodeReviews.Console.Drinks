namespace HKHemanthsharma.Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "https://www.thecocktaildb.com/api/json/v1/1";
            Cocktails cocktails = new Cocktails(baseUrl);
            string result = cocktails.GetCategriesAsync().GetAwaiter().GetResult();
            Console.WriteLine(result);
        }
    }
}
