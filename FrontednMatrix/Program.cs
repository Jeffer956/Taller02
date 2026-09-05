using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.Clear();
    int n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

    if (n > 0)
    {
        var matrix = new OperacionMatriz.Backend.Matrix(n);
        Console.WriteLine(matrix);

        Console.WriteLine($"La sumatoria es: {matrix.Sum}");
        Console.WriteLine($"El valor máximo es: {matrix.Max}");
        Console.WriteLine($"El valor mínimo es: {matrix.Min}");
    }
    else
    {
        Console.WriteLine("El orden de la matriz debe ser mayor a 0.");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (!answer.Equals("n", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Bye.");