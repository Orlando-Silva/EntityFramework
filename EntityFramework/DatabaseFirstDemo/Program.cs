using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso rápido:
            var contexto = new DatabaseFirstDemoEntities();
            var post = new Post()
            {
                Body = "Hello World!",
                DatePublished = DateTime.UtcNow,
                Title = "Database Hello World"
            };
            contexto.Post.Add(post); // Aqui é o "Commit".
            contexto.SaveChanges(); // Aqui é onde realmente é salvo, o "Push".

        }
    }
}
