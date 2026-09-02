using Shared;
using DescomposicionFactores;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.Clear();

    int number = ConsoleExtension.GetInt("Ingrese el número a descomponer: ");

    if (number > 1)
    {
        var decomposer = new PrimeDecomposer(number);
        Console.WriteLine(decomposer.GetPrimeFactorsString());
    }
    else
    {
        Console.WriteLine("Por favor ingrese un número mayor a 1.");
    }

    // Validación de entrada para la respuesta [S/N]
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (!answer.Equals("n", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("God Bye.");