int nota = int.Parse(Console.ReadLine());

/*
if (nota < 5)
{
    Console.WriteLine("Reprovado");
}
else if (nota > 5 && nota < 8)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Aprovado");
}
*/

var resultado = nota < 8 ? "Reprovado" : "Aprovado";
Console.WriteLine(resultado);