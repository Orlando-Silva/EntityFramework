#region --Using--
using System.Data.Entity.ModelConfiguration;
using VidzyCodeFirst.Entities;
#endregion

namespace VidzyCodeFirst.DAL.FluentAPIConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        #region --Construtor
        public VideoConfiguration()
        {
            Property(v => v.Classiﬁcation)
                .HasColumnType("tinyint");

            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(v => v.Genre)
                .WithMany(g => g.Videos)
                .Map(m => m.MapKey("GenreId"));

            HasMany(v => v.Tags)
                .WithMany(t => t.Videos)
                .Map(m =>
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });

        }
        #endregion

    }
}
