﻿using bytebank_ATENDIMENTO.bytebank_Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente();

#region Exemplos Arrays em C#
//TestaArrayInt();
//TestaBuscarPalavra();
//TestaMediana(amostra);
//TestaArrayDeContasCorrentes();


//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do Array: {idades.Length}");

//    int acumulador = 0;

//    for( int i = 0; i < idades.Length; i++)
//    {
//        int idade  = idades[i];
//        Console.WriteLine($"índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média de idades = {media}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i+1}ª Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite a palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}.");
//            break;
//        }
//    }
//}

//Array amostra = Array.CreateInstance(typeof(double), 5);
//Array amostra = new double[5];
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//void TestaMediana(Array array)
//{
//    if((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;

//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//        numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

//    var contaDoAndre = new ContaCorrente(963, "123456-X");
//    listaDeContas.Adicionar(contaDoAndre);
//listaDeContas.ExibirLista();
//Console.WriteLine("*************************************");
//listaDeContas.Remover(contaDoAndre);
//listaDeContas.ExibirLista();

//for (int i = 0; i < listaDeContas.Tamanho; i++)
//{
//    ContaCorrente conta = listaDeContas[i];
//    Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
//}
//}

// Classe genérica
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá mundo!");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}


//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>() {
//    new ContaCorrente(95, "5679787-A"),
//    new ContaCorrente(95, "4456688-B"),
//    new ContaCorrente(94, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>() {
//    new ContaCorrente(95, "5679787-E"),
//    new ContaCorrente(95, "4456688-F"),
//    new ContaCorrente(94, "7781438-G")
//};

//// Adiciona uma lista em outra
//_listaDeContas2.AddRange(_listaDeContas3);

//// Inverte a lista
//_listaDeContas2.Reverse();
//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//// Recorta a lista conforme as posições passadas como parametro
//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}
//Console.WriteLine("\n\n");

//// Limpa a lista
//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}
#endregion