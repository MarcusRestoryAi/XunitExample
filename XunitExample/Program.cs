namespace XunitExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int tal1 = 10, tal2 = 21;

            //Init Math class
            MyMath myMath = new MyMath();

            Console.WriteLine($"Tal {tal1} är {(myMath.EvenOrOdd(tal1) ? "Jämnt" : "Ojämnt")}");
            Console.WriteLine($"Tal {tal2} är {(myMath.EvenOrOdd(tal2) ? "Jämnt" : "Ojämnt")}");

            Console.WriteLine($"Summan av {tal1} och {tal2} är {myMath.Add(tal1, tal2)}");
        }

        
    }
}