using System;
using Xunit;
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
        Assert.Equal(76.2, result);
    }

    public static void Test_Cm_ConvertsInches_ReturnsCorrectValue()
    {
        double result = InchConverter.InchToCentimeters(3);
        Assert.Equal(7.62, result);
    }

    public static void Test_M_ConvertsInches_ReturnsCorrectValue()
    {
        double result = InchConverter.InchToMeters(56);
        Assert.Equal(1.4224, result);
    }

}


