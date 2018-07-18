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

        public IList<Genre> Genres { get; set; }
    }
}
