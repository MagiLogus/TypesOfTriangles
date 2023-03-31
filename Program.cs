//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. Sendo    que:  − Triângulo    Equilátero:    possui    os    3    lados    iguais, − Triângulo    Isóscele:    possui    2    lados    iguais, − Triângulo    Escaleno:    possui    3    lados    diferentes.

// Algoritimo 
// Entrada: lado A / lado B / lado C
// Proscessamento: 

//Entrada 

Console.WriteLine(@$"
--------------------------------
|        Programa para         |
|      calcular um tipo de     |
|           triangulo          |
--------------------------------
");

Console.WriteLine("Informe as medidas dos lados do triângulo:");

Console.WriteLine($"Lado A:");
float ladoA = float.Parse(Console.ReadLine());

Console.WriteLine($"Lado B:");
float ladoB = float.Parse(Console.ReadLine());

Console.WriteLine($"Lado C:");
float ladoC = float.Parse(Console.ReadLine());

// Processamento 


// Saida
if (ladoA == ladoB && ladoB ==ladoC)
{
Console.WriteLine("Este é um triângulo equilátero.");   
}
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
{
Console.WriteLine("Este é um triângulo isósceles.");
}
else 
{
Console.WriteLine("Este é um triângulo Escaleno.");  
}