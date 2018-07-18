#region --Using--
using System;
using System.Collections.Generic;
#endregion

namespace VidzyCodeFirst.Entities
{
    public class Video
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public Classification Classiﬁcation { get; set; }

    }

    public enum Classification : int
    {
        Platinum = 1,
        Gold = 2,
        Silver = 3
    }
}
