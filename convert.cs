using System;
using Xunit;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: convert <value> <unit>");
            return;
        }

        if (args[args.Length - 1] == "-t")
        {
            InchConverterTests.RunTests();
            return;
        }
        if (!double.TryParse(args[0], out double value))
        {
            Console.WriteLine("Invalid value provided.");
            return;
        }

        string unit = args[1].ToLower();

        switch (unit)
        {
            case "-mm":
                Console.WriteLine($"{InchConverter.InchToMillimeters(value)} mm");
                break;
            case "-cm":
                Console.WriteLine($"{InchConverter.InchToCentimeters(value)} cm");
                break;
            case "-m":
                Console.WriteLine($"{InchConverter.InchToMeters(value)} m");
                break;
            default:
                Console.WriteLine("Invalid unit provided.");
                break;
        }
    }

    public static void RunTests()
    {
        var assembly = typeof(Program).Assembly.Location;
        Program.Main(new[] { assembly });
    }
}
public class InchConverter
{
    public static double InchToMillimeters(double inches)
    {
        return inches * 25.4;
    }

    public static double InchToCentimeters(double inches)
    {
        return inches * 2.54;
    }

    public static double InchToMeters(double inches)
    {
        return inches * 0.0254;
    }
}
public class InchConverterTests
    {
        public static void RunTests()
        {
            Test_Mm_ConvertsInches_ReturnsCorrectValue();
            Test_Cm_ConvertsInches_ReturnsCorrectValue();
            Test_M_ConvertsInches_ReturnsCorrectValue();
            
        }

        public static void Test_Mm_ConvertsInches_ReturnsCorrectValue()
        {
            double result = InchConverter.InchToMillimeters(2);
            double expected = 50.8;
            if (result == expected)
            {
                Console.WriteLine("🟢Test_Mm_ConvertsInches_ReturnsCorrectValue passed");
            }
            else
            {
                Console.WriteLine("🔴Test_Mm_ConvertsInches_ReturnsCorrectValue failed");
            }
        }

        public static void Test_Cm_ConvertsInches_ReturnsCorrectValue()
        {
            double result = InchConverter.InchToCentimeters(3);
            double expected = 7.62;
            if (result == expected)
            {
                Console.WriteLine("🟢Test_Cm_ConvertsInches_ReturnsCorrectValue passed");
            }
            else
            {
                Console.WriteLine("🔴Test_Cm_ConvertsInches_ReturnsCorrectValue failed");
            }
        }

        public static void Test_M_ConvertsInches_ReturnsCorrectValue()
        {
            double result = InchConverter.InchToMeters(2);
            double expected = 0.0508;
            if (result == expected)
            {
                Console.WriteLine("🟢Test_M_ConvertsInches_ReturnsCorrectValue passed");
            }
            else
            {
                Console.WriteLine("🔴Test_M_ConvertsInches_ReturnsCorrectValue failed");
            }
        }
}   



