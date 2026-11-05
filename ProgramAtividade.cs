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


// int numeroSecreto = 67;
// int tentativa = 0;
// int quantidadeTentativas = 0;

// Console.WriteLine("\n--- Jogo da Adivinhação ---\n");
// Console.WriteLine("Tente adivinhar o número secreto!");

// while (tentativa != numeroSecreto)
// {
//     Console.Write("\nDigite o seu palpite: ");
//     tentativa = Convert.ToInt32(Console.ReadLine());
//     quantidadeTentativas++;

//     if (tentativa < numeroSecreto)
//     {
//         Console.WriteLine("O número secreto é MAIOR.");
//     }
//     else if (tentativa > numeroSecreto)
//     {
//         Console.WriteLine("O número secreto é MENOR.");
//     }
// }


// Console.WriteLine("\n Parabéns! Você acertou o número!");
// Console.WriteLine($"Total de tentativas: {quantidadeTentativas}");


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


//// Exercício 6 — Lista de produtos


// List<string> nomes = new List<string>();

// Console.WriteLine("\n--- Cadastro de Produtos ---\n");

// Console.Write("Digite o nome do 1º produto: ");
// nomes.Add(Console.ReadLine());

// Console.Write("Digite o nome do 2º produto: ");
// nomes.Add(Console.ReadLine());

// Console.Write("Digite o nome do 3º produto: ");
// nomes.Add(Console.ReadLine());

// Console.WriteLine("\n--- Produtos Cadastrados ---\n");
// Console.WriteLine(string.Join("\n", nomes));

