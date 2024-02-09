using System;
using Xunit;

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
            double result = InchConverter.InchToMillimeters(3);
            double expected = 76.2;
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
            double result = InchConverter.InchToMeters(56);
            double expected = 1.4224;
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



