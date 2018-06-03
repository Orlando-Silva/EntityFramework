#region --Using--
using CodeFirstDemo.Contexto;
using CodeFirstDemo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // É necessário inserir o comando enable-migrations no Console do Gerenciador de Pacotes para gerar o ADO.NET:
            // Toda vez que alguma mudança é feita, deve-se inserir o comando migration-add <nome que represente a alteração>.
            // É importante este segundo comando pois ele gera um migration, que serve para atualizar a base de dados com as alteraçõs que foram feitas.
            // Para rodar as Migration, deve-se inserir no console Update-Database, este comando gera tudo automáticamente no banco de dados.
            var contexto = new CodeFirstDemoContexto();
            var post = new Post()
            {
                Body = "Code First Hello World!",
                Title = "Code First Hello World",
                DatePublished = DateTime.UtcNow,
            };
            contexto.Posts.Add(post);
            contexto.SaveChanges();

            Console.ReadLine();
        }
    }
}
