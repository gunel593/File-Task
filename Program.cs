namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manati daxil ed");

            double dollar = Convert.ToDouble(Console.ReadLine());
   
            double manat = dollar * 1.7 ;
            double euro = manat * 2;
            File.AppendAllText(@"Text",$"\ndollar {dollar}   -  manat {manat}");
        }

    }

}