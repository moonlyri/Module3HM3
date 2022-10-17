using Module3HM3;

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        var class1 = new Multiplication();
        var class2 = new Calculation();
        class1.Operation = program.Show;
        class2.Calculate(class1.Multiply, 3, 2);
        class1.Operation(class2.Result(5));
    }

    public void Show(bool result)
    {
        Console.WriteLine(result);
    }
}