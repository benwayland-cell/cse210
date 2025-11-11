

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
    
    /* Simplifies the fraction */
    public void Simplify()
    {
        // start with testDivisor being _numerator or _denominator, whichever is smaller
        int testDivisor;
        if (_numerator > _denominator)
        {
            testDivisor = _denominator;
        }
        else
        {
            testDivisor = _numerator;
        }

        // test every number until we find a number that both are divisible by
        while (testDivisor > 1)
        {
            // if they're both divisible by testDivisor
            if (_numerator % testDivisor == 0 && _denominator % testDivisor == 0)
            {
                // divide them both be the testDivisor and end the function
                _numerator /= testDivisor;
                _denominator /= testDivisor;
                break;
            }

            testDivisor--;
        }
    }
}