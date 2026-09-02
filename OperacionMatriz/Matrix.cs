namespace OperacionMatriz
{
    public class Matrix
    {

        private readonly int _n;
        private int[,] _data;
        public int Sum { get; private set; }
        public int Max { get; private set; }
        public int Min { get; private set; }

        public Matrix(int n)
        {
            _n = n;
            _data = new int[_n, _n];
            Max = int.MinValue;
            Min = int.MaxValue;
            Calculate();
        }

        private void Calculate()
        {
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
    }
}