using System;
using System.Linq;
using Loja.Entidades;
using System.Globalization;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            //var produto = new Produto();

            //var produtos = produto.Listar().Where(x => x.Valor > 4);

            //foreach (Produto item in produtos)
            //{
            //    Console.WriteLine(item.Nome);
            //}

            //new Produto().Listar().ForEach(x =>
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(x.Nome);               
            //    Console.WriteLine(x.Quantidade);                
            //    Console.WriteLine(x.Valor);
                
            //});
            //Console.ReadLine();
            
            new Produto().Listar().Where(p => p.Valor >4).ToList().ForEach(x =>
            {
                Console.WriteLine();
                Console.WriteLine(x.Nome);               
                Console.WriteLine(x.Quantidade);                
                Console.WriteLine(x.Valor);
                
            });
            Console.ReadLine();
        }
    }
}
