using System;
using System.Linq;
using Loja.Entidades;
using System.Globalization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] cores = { "Preto", "Branco", "Verde", "Vermelho", "Azul" };

            //var resultado = cores.Where(x => x.Contains("e") || x.Contains("z"));

            //foreach (string cor in resultado)
            //{
            //    Console.WriteLine(cor);
            //}

            //Console.ReadLine();

            //__________________________________________________________________________

            //var produto = new Produto();

            //var produtos = produto.Listar().Where(x => x.Valor > 4);

            //foreach (Produto item in produtos)
            //{
            //    Console.WriteLine(item.Nome);
            //}

            //__________________________________________________________________________

            //new Produto().Listar().ForEach(x =>
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(x.Nome);               
            //    Console.WriteLine(x.Quantidade);                
            //    Console.WriteLine(x.Valor);

            //});
            //Console.ReadLine();

            //__________________________________________________________________________

            //new Produto().Listar().Where(p => p.Valor >4).ToList().ForEach(x =>
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(x.Nome);               
            //    Console.WriteLine(x.Quantidade);                
            //    Console.WriteLine(x.Valor);

            //});
            //Console.ReadLine();

            //__________________________________________________________________________
            //var produtos = new Produto().Listar();

            //var nomes = produtos
            //    .Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
            //    .Select(p => new {Name = p.Nome, Value = p.Valor})  //necessario atribuir nomes caso queira selecionar mais que uma propriedade
            //    .ToList();

            //nomes.ForEach(x => {
            //    Console.WriteLine(JsonConvert.SerializeObject(x));
            //    Console.WriteLine(" ");
            //    });      


            //Console.ReadLine();

            //__________________________________________________________________________

            //var produtos = new Produto().Listar();


            ////var nomes = produtos
            ////    //.Where(p => p.DataVencimento.Year == 2022)
            ////    //.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
            ////    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2, "PAULO"), Value = p.Valor })      //setando o valor de forma direta 
            ////    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Remove(2,2), Value = p.Valor })                            //remove
            ////    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Replace("a", "z"), Value = p.Valor })                      //replace
            ////    .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor, DiaDeVencimento = p.DataVencimento.Day })
            ////    .ToList();

            //produtos.ForEach(x => 
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(x));
            //    Console.WriteLine(" ");
            //});


            //Console.ReadLine();

            //__________________________________________________________________________

            //var produtos = new Produto().Listar();

            //List<Produto> produtos = new List<Produto>();

            //var produto2 = produtos.FirstOrDefault();

            //var produto1 = produtos.First();

            //var produto2 = produtos.LastOrDefault();

            //var produto1 = produtos.Last();

            //if (produtos.Any(p => p.Quantidade > 10))
            //{
            //    Console.WriteLine("Tem");
            //}


            //produtos.ForEach(x =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(x));
            //    Console.WriteLine(" ");
            //});

            //__________________________________________________________________________

            //var produtos1 = new Produto().Listar();

            //var produtos2 = new List<Produto>();
            //produtos2.Add(new Produto() { Nome = "Iphone", Valor = 2500 });
            //produtos2.Add(new Produto() { Nome = "LG", Valor = 3500 });

            //produtos1.AddRange(produtos2); //adicionando uma lista a outra

            //produtos1.ForEach(x => Console.WriteLine(x.Nome));

            //int[] numerosPares = { 2, 4, 6, 8, 10 };
            //int[] numerosImpares = { 1, 3, 5, 7, 9 };
            //int[] numerosMisturados = { 1, 2, 3, 4 };

            //var temNumerosPares = numerosMisturados.Intersect(numerosPares);              //tudo que existe na lista

            //var numerosQuenaoSeRepetem = numerosMisturados.Except(numerosPares);          //tudo que não existe na lista

            //__________________________________________________________________________

            //var sequencia = Enumerable.Range(10, 3);                               //range
            //var repetir = Enumerable.Repeat("Paulo", 10);                          //repeat

            //__________________________________________________________________________

            //var produtos = new Produto().Listar();

            ////Valor produto maior
            //var valorProdutoMaisCaro = produtos.Max(p => p.Valor);

            ////Valor produto menor
            //var valorProdutoMaisBarato = produtos.Min(p => p.Valor);

            ////Media dos produtos
            //var maiorEsqtoque = produtos.Average(p => p.Valor);

            ////Soma dos produtos
            //var somaProdutos = produtos.Sum(p => p.Valor);


            //__________________________________________________________________________

            //var produtosFrutas = new Produto().ListarFrutas();
            //var produtosEletronicos = new Produto().ListarEletronicos();

            //var produtos = new List<Produto>();
            //produtos.AddRange(produtosFrutas);
            //produtos.AddRange(produtosEletronicos);

            //produtos.ForEach(x =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(x));
            //});

            //Console.WriteLine("----------------------------------------");

            //var resultado = (from p in produtos
            //                group p by p.Categoria into grupo
            //                select new RelatorioProdutoPorCategoria
            //                {
            //                    NomeDaCategoria = grupo.Key,
            //                    ValorMinimo = grupo.Min(x => x.Valor),
            //                    ValorMaximo = grupo.Max(x => x.Valor),
            //                    ValorTotal = grupo.Sum(x => x.Valor)
            //                }).OrderBy(x => x.NomeDaCategoria);

            //resultado.ToList().ForEach(x =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(x));
            //});


            //Console.ReadLine();

            //__________________________________________________________________________




        }
    }

    public class RelatorioProdutoPorCategoria
    {
        public string NomeDaCategoria { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class ProdutoSelecionado
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int DiaDeVencimento { get; set; }
    }
}
