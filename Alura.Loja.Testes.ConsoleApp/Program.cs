using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         using (var contexto = new LojaContex())
            {
                var produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }

                //var p1 = produtos.First();
                //p1.Nome = "Percy Jackson";

                //contexto.SaveChanges();

                Console.WriteLine("============================");

                produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }



            }  
        }

  
    }
}
