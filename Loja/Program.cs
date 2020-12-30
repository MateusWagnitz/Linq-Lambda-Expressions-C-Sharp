using System;
using System.Linq;
using Loja.Entidades;
using System.Globalization;
using Newtonsoft.Json;

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

            var produtos = new Produto().Listar();

            var nomes = produtos
                //.Where(p => p.DataVencimento.Year == 2022)
                //.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
                //.Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2, "PAULO"), Value = p.Valor })      //setando o valor de forma direta 
                //.Select(p => new ProdutoSelecionado { Name = p.Nome.Remove(2,2), Value = p.Valor })                            //remove
                //.Select(p => new ProdutoSelecionado { Name = p.Nome.Replace("a", "z"), Value = p.Valor })                      //replace
                .Select(p => new ProdutoSelecionado { Name = p.Nome.Replace("a", "z"), Value = p.Valor, DiaDeVencimento = p.DataVencimento.Day }) 
                .ToList();

            nomes.ForEach(x => 
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
                Console.WriteLine(" ");
            });


            Console.ReadLine();



        }
    }

    public class ProdutoSelecionado
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int DiaDeVencimento { get; set; }
    }
}
