Console.Clear();
double Nota1, Nota2, Nota3, Nota4, media ;
string resultado; 
//PAS 11/10/2024
Console.WriteLine("-- Média --");
Console.WriteLine();
Console.WriteLine("Digite suas notas abaixo.");
Console.Write("Nota 1:... ");
Nota1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Nota 2:...  ");
Nota2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Nota 3:... ");
Nota3 = Convert.ToDouble (Console.ReadLine());
Console.Write("Nota 4:... ");
Nota4 = Convert.ToDouble (Console.ReadLine());

if (Nota1 < 0.0 || Nota1 > 10.0
    || Nota2 < 0.0 || Nota2 > 10.0
    || Nota3 < 0.0 || Nota3 > 10.0
    || Nota4 < 0.0 || Nota4 > 10.0
)

{
    Console.WriteLine("Digite somentes notas entre 0.0 e 10.0");
}
else
{
    media = (Nota1 + Nota2 + Nota3 + Nota4) /4;

    if (media < 5.0)
    {
        resultado = "Reprovado";
    }

   else if (media < 6.0)
    {
        resultado = "Em recuperação";
    }
    
   else
    {
        resultado = "Aprovado";
    }

    Console.WriteLine($"\n Você ficou com média {media:n1}. Resultado:{resultado} ");
}