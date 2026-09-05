namespace OperacionMatriz.Backend;

public class Matrix
{
    // Fields
    private int _n;
    private int[,] _data;

    // Constructors
    public Matrix()
    {
        N = 3; 
    }

    public Matrix(int n)
    {
        N = n;
    }


    // Properties
    public int N
    {
        get => _n;
        set
        {
            _n = ValidN(value);
            _data = new int[_n, _n];
            Calculate();
        }
    }

    public int Sum { get; private set; }
    public int Max { get; private set; }
    public int Min { get; private set; }

    // Public Methods
    public void PrintMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                Console.Write($"{_data[i, j],-4}");
            }
            Console.WriteLine();
        }
    }

    // Private Methods
    private void Calculate()
    {
        Sum = 0;
        Max = int.MinValue;
        Min = int.MaxValue;

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _data[i, j] = (i + 1) - j;
                Sum += _data[i, j];

                if (_data[i, j] > Max) Max = _data[i, j];
                if (_data[i, j] < Min) Min = _data[i, j];
            }
        }
    }

    private int ValidN(int n)
    {
        if (n <= 0)
        {
            throw new Exception($"The order:{n}, is not valid. Must be greater than 0.");
        }
        return n;
    }
}