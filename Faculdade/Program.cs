using Faculdade.Classes;

Disciplina poo = new Disciplina("Programação Orientada a Objeto", 80);

Aluno fulano = new Aluno("Fulano", poo);
Aluno ciclano = new Aluno("Ciclano", poo);

Random rand = new Random();

fulano.Nota1 = (float)(rand.NextDouble() * 10);
fulano.Nota2 = (float)(rand.NextDouble() * 10);

ciclano.Nota1 = (float)(rand.NextDouble() * 10);
ciclano.Nota2 = (float)(rand.NextDouble() * 10);

for(int i = 0; i <= 20; i++)
{
    ciclano.atribuirFalta();
}

fulano.calcularMedia();
ciclano.calcularMedia();

fulano.verificarStatus();
ciclano.verificarStatus();

Console.WriteLine("Fulano:\n   Nota 1: {0:0.00}\n   Nota 2: {1:0.00}\n   Média: {2:0.00}\n   Faltas: {3}\n   Status: {4}\n", fulano.Nota1, fulano.Nota2, fulano.Media, fulano.Faltas, fulano.Status);
Console.WriteLine("Ciclano:\n   Nota 1: {0:0.00}\n   Nota 2: {1:0.00}\n   Média: {2:0.00}\n   Faltas: {3}\n   Status: {4}\n", ciclano.Nota1, ciclano.Nota2, ciclano.Media, ciclano.Faltas, ciclano.Status);