class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        bool isFinished = false;
        do
        {
            Console.Clear();
            isFinished = calc.Run();
            if(!isFinished) {
                // stay on invalid
                Console.ReadLine();
            }
        } while (!isFinished);
    }
}
