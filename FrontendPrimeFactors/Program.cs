using BackenPrimeFactors;
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.Clear();
    int inputNumber = ConsoleExtension.GetInt("Ingrese el número a descomponer: ");

    try
    {
      
        var decomposer = new PrimeDecomposer(inputNumber);

        Console.WriteLine(decomposer.GetPrimeFactorsString());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (!answer.Equals("n", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Bye.");