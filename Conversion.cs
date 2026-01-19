public class Conversion
{
    static double ConvertToCM(int feet)
    {
        double cm = feet*30.48;
        return Math.Round(cm,2);
    }

    public static void Run()
    {
        int feet = int.Parse(Console.ReadLine()!);
        double cm = ConvertToCM(feet);
        Console.WriteLine(cm);
    }
}