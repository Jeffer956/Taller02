namespace DescomposicionFactores
{
    public class PrimeDecomposer
    {
        //Field
        private readonly int _number;

        //Constructor
        public PrimeDecomposer(int number)
        {
            _number = number;
        }

        //Method
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

    }

}