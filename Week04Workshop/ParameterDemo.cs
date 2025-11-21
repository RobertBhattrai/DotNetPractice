//Task 3: Parameter Type
public class ParameterDemo
{
    // Method with ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // Method with out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Safal Bhattarai";
    }

    // Method with params parameter
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}