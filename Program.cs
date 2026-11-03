// // Exercício 1 — Calculando uma compra
// Console.Write("Produto: ");
// string? NomeProduto = Console.ReadLine();

// Console.Write("Quantidade: ");
// string? Quantidade = Console.ReadLine();
// int quantidade = int.Parse(Quantidade);

// Console.Write("Preço Unitário: ");
// string? PrecoUnitario = Console.ReadLine();
// decimal preco = decimal.Parse(PrecoUnitario);

// Console.WriteLine($"Produto: {NomeProduto}\n Quantidade: {quantidade}\n Preço Unitário: {preco}\n Valor Total: {preco * quantidade}");

// // Exercício 2 — Classificação de notas
// Console.Write("Nome do Aluno: ");
// string? Nome = Console.ReadLine();

// Console.Write("Nota do Aluno: ");
// string? Nota = Console.ReadLine();
// int nota = int.Parse(Nota);

// if(nota >= 7 && nota <= 10)
// {
// Console.WriteLine($"Aluno(a) aprovado(a)!");
// }
// else if (nota >= 5 && nota < 7)
// {
// Console.WriteLine($"Aluno(a) de recuperação!");
// }
// else if(nota < 5 && nota >= 0)
// {
// Console.WriteLine($"Aluno(a) reprovado(a)!");
// }
// else
// {
// Console.WriteLine($"Valor da nota do aluno inválido");
// }

// Exercício 3 — Adivinhe o número


// Exercício 4 — Calculadora com métodos


static int Somar(int a, int b)
{
    return a + b;
}