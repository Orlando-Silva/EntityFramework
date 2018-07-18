#region --Using--
using System.Data.Entity;
using VidzyCodeFirst.Entities;
#endregion

namespace VidzyCodeFirst.DAL
{
    public class VidzyContext : DbContext
    {

        #region --Atributos--
        public virtual DbSet<Video> Videos { get; set; }

        public virtual DbSet<Genre> Genres { get; set; }
        #endregion

        #region --Construtor--
        public VidzyContext() : base("name=localhost")
        {

        }
        #endregion

    }
}
