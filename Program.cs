namespace Class_0602_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student(60, 75);
            Student p2 = new Student(78, 68);

            Student savg = p1 + p2;
            Console.WriteLine(savg.Mid);
            Console.WriteLine(savg.Final);
        }
    }
}