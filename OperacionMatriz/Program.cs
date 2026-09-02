using Shared;
using OperacionMatriz;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.Clear(); // Limpia la pantalla en cada repetición

    int n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

    if (n > 0)
    {
        var matrix = new Matrix(n);
        matrix.PrintMatrix();

        Console.WriteLine($"La sumatoria es: {matrix.Sum}");
        Console.WriteLine($"El valor máximo es: {matrix.Max}");
        Console.WriteLine($"El valor mínimo es: {matrix.Min}");
    }
    else
    {
        Console.WriteLine("El orden de la matriz debe ser mayor a 0.");
    }

    // Validación de entrada para la respuesta [S/N]
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (!answer.Equals("n", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("God Bye");