#region --Using--
using System.Data.Entity.ModelConfiguration;
using VidzyCodeFirst.Entities;
#endregion

namespace VidzyCodeFirst.DAL.FluentAPIConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        #region --Construtor--
        public GenreConfiguration()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
        #endregion
    }
}
