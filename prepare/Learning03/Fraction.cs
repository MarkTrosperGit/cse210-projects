using System.ComponentModel.DataAnnotations;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int getNumerator()
    {
        return _numerator;
    }
    public int getDenominator()
    {
        return _denominator;
    }
    public void setNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public void setDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        double value;
        value = (double)_numerator / _denominator;
        return value;
    }
}