namespace Module3HM3;

public class Calculation
{
    public int _operation { get; set; }

    public  Predicate<int> Calculate(Func<int,int,int> operation, int a, int b)
    {
        _operation = operation(a, b);
        return new Predicate<int>(Result);
    }
    

    public bool Result(int multiply)
    {
        if (multiply % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}