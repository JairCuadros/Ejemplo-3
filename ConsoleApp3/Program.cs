Console.WriteLine("Por favor ingrese el primer número:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor ingrese el segundo número:");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor ingrese el tercer número:");
int C = int.Parse(Console.ReadLine());
int mayor = A;
if (B > mayor)
{
    mayor = B;
}
if (C > mayor)
{
    mayor = C;
}
Console.WriteLine($"El mayor de los tres números es: {mayor}");