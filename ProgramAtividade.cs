// // Exercício 1 — Calculando uma compra

// Console.WriteLine("\n--- Calculo da compra ---\n");
// Console.Write("Nome do produto: ");
// string? NomeProduto = Console.ReadLine();

// Console.Write("Quantidade: ");
// string? Quantidade = Console.ReadLine();
// int quantidade = int.Parse(Quantidade);

// Console.Write("Preço Unitário: ");
// string? PrecoUnitario = Console.ReadLine();
// decimal preco = decimal.Parse(PrecoUnitario);

// Console.WriteLine("\n--- Resultado Final ---\n");
// Console.WriteLine($"Produto: {NomeProduto}\n Quantidade: {quantidade}\n Preço Unitário: {preco}\n \nValor Total: {preco * quantidade}");


// // Exercício 2 — Classificação de notasz

// Console.WriteLine("--- Verificação de notas ---\n");
// Console.Write("Nome do Aluno: ");
// string? Nome = Console.ReadLine();

// Console.Write("Nota do Aluno: ");
// string? Nota = Console.ReadLine();
// int nota = int.Parse(Nota);

// if(nota >= 7 && nota <= 10)
// {
// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"Aluno(a) aprovado(a)!");
// }
// else if (nota >= 5 && nota < 7)
// {
// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"Aluno(a) de recuperação!");
// }
// else if(nota < 5 && nota >= 0)
// {
// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"Aluno(a) reprovado(a)!");
// }
// else
// {
// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"Valor da nota do aluno inválido");
// }


// Exercício 3 — Adivinhe o número


// // Exercício 4 — Calculadora com métodos


// Console.WriteLine("--- Somar ---\n");
// Console.Write("Valor A: ");
// string? A = Console.ReadLine();
// decimal a = decimal.Parse(A);

// Console.Write("Valor B: ");
// string? B = Console.ReadLine();
// decimal b = decimal.Parse(B);

// decimal resultadoSoma = Somar(a,b);
// Console.WriteLine(resultadoSoma);

// static decimal Somar (decimal a, decimal b)
// {
// Console.WriteLine("\n--- Resultado Final ---\n");
//     return a + b;
// }

// Console.WriteLine("\n--- Multiplicar ---\n");
// Console.Write("Valor C: ");
// string? C = Console.ReadLine();
// decimal c = decimal.Parse(C);

// Console.Write("Valor D: ");
// string? D = Console.ReadLine();
// decimal d = decimal.Parse(D);

// decimal resultadoMult = Multiplicar(c,d);
// Console.WriteLine(resultadoMult);

// static decimal Multiplicar (decimal a, decimal b)
// {
// Console.WriteLine("\n--- Resultado Final ---\n");
//     return a * b;
// }


//// Exercício 5 — Cadastro de notas em um array


// double[] notas = new double[3];

// Console.WriteLine("--- Cadastro de Notas ---");
// for (int i = 0; i < notas.Length; i++)
// {
//     Console.Write($"Digite a {i + 1}ª nota: ");
//     notas[i] = Convert.ToDouble(Console.ReadLine());
// }

// Console.WriteLine("\n--- Notas Registradas ---");
// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Nota {i + 1}: {notas[i]}");
// }

// double soma = 0;
// foreach (double nota in notas)
// {
//     soma += nota; 
// }

// double media = soma / notas.Length;

// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"A média do aluno é: {media}");

