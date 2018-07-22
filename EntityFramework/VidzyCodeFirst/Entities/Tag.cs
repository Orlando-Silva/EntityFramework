using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst.Entities
{
    public class Tag
    {
        public int ID { get; set; }

        public IList<Video> Videos { get; set; }

    }
}
