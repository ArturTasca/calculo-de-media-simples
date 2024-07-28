var nota1 = 45;
var nota2 = 70;
var nota3 = 85;
var media = 0;

media =(nota1 + nota2 + nota3) / 3;
Console.WriteLine(media);

//acima de 70 = aprovado
//entre 50 e 70 = recuperação
//abaixo de 50 = reprovado

if (media >= 70) 
{
    Console.WriteLine("O Aluno for aprovado");
}

if (media >= 50 && media <70)
{
    Console.WriteLine("O aluno está em recuperação");

}
if (media <50)
{
    Console.WriteLine("O aluno foi reprovado");
}
