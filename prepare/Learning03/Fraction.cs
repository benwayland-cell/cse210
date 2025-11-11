

class Fraction
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

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
    
    public void Simplify()
    {
        int testDivisor;
        if (_numerator > _denominator)
        {
            testDivisor = _denominator;
        }
        else
        {
            testDivisor = _numerator;
        }

        while (testDivisor > 1)
        {
            if (_numerator % testDivisor == 0 && _denominator % testDivisor == 0)
            {
                _numerator /= testDivisor;
                _denominator /= testDivisor;
                break;
            }
            
            testDivisor--;
        }
    }
}