Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());
int numeroAsteriscos = numero * 2;

for (int i = 0; i < numero; i++)
{
    for (int j = 0; j < numeroAsteriscos; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

