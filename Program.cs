// Exercício preposto surso Nélio Alves
// Programa vai pedir para o usuario digitar a temperatura em Celsius, logo em seguida o programa mostra na tela a temperatura
// em Fahrenheit. Depois disso pedira se deseja repetir o precesso.

double F, Temp;
char X;
do
{
    Console.Write("Digite a temperatura em Celsius:");
    Temp = double.Parse(Console.ReadLine());
    F = (9 * Temp / 5) + 32;

    Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1"));
    Console.Write("Deseja repetir (s / n)? ");
    X = char.Parse(Console.ReadLine());
    
}while (X == 's' || X == 'S');
