#region --Using--
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace VidzyCodeFirst.Entities
{
    public class Genre
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public IList<Video> Videos { get; set; }
    }
}
