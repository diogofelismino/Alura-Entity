using Microsoft.EntityFrameworkCore.ChangeTracking;
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


                ExibeEntries(contexto.ChangeTracker.Entries());

                Console.WriteLine("============================");
                ;

                var novoProdut = new Produto()
                {
                    Nome = "Caosewq3",
                    Categoria = "Terrorqwe3",
                    Preco = 6.92
                };
                ExibeEntries(contexto.ChangeTracker.Entries());

                //var p1 = produtos.First();

                contexto.Produtos.Add(novoProdut);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.Produtos.Remove(novoProdut);

                ExibeEntries(contexto.ChangeTracker.Entries());

                ///contexto.SaveChanges();
                ///
                var entry = contexto.Entry(novoProdut);
                Console.WriteLine("\n\n"+ entry.Entity.ToString() + " - " + entry.State);


                //ExibeEntries(contexto.ChangeTracker.Entries());



            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("============================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " +  e.State);
            }
        }

    }
}
