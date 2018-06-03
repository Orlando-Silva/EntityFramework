#region --Using--
using CodeFirstDemo.Entidades;
using System.Data.Entity;
#endregion


namespace CodeFirstDemo.Contexto
{
    public class CodeFirstDemoContexto : DbContext
    {

        public virtual DbSet<Post> Posts { get; set; }

    }
}
