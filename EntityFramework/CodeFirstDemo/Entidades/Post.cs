#region --Using--
using System;
#endregion

namespace CodeFirstDemo.Entidades
{
    //No CodeFirst, geramos as classes e a implementação do DbContext manualmente.
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
