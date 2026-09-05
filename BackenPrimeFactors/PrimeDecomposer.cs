namespace BackenPrimeFactors;

public class PrimeDecomposer
{
    // Field
    private int _number;

    // Constructors
    public PrimeDecomposer()
    {
        Number = 2; // Valor por defecto seguro
    }

    public PrimeDecomposer(int number)
    {
        Number = number;
    }

    // Properties
    public int Number
    {
        get => _number;
        set => _number = ValidNumber(value);
    }

    // Public Methods
    public string GetPrimeFactorsString()
    {
        int temp = _number;
        var factors = new List<int>();
        int divisor = 2;

        while (temp > 1)
        {
            if (temp % divisor == 0)
            {
                factors.Add(divisor);
                temp /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        return $"{_number} = {string.Join(" x ", factors)}";
    }

    public override string ToString()
    {
        return GetPrimeFactorsString();
    }

    // Private Methods 
    private int ValidNumber(int number)
    {
        if (number <= 1)
        {
            throw new Exception($"The number: {number}, is not valid. Must be greater than 1.");
        }
        return number;
    }
}