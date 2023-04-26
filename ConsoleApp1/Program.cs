namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maxaiette");
            list.Add("Cubero");
            list.Add("maxaiettec@gmail.com");
            string listinside = string.Format("{0},{1},{2}", list[0], list[1], list[2]);
            Console.WriteLine(listinside);

            DateTime date = DateTime.Now;

            Console.WriteLine("The date is " + date.ToString("M"));
        }
    }
}