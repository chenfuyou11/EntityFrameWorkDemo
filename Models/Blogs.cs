using System;
using System.Collections.Generic;

namespace EntityFrameWorkDemo.Models
{
    public partial class Blogs
    {
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        public int Id { get; set; }
        public decimal Rating { get; set; }
        public string XmlUrl { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int BlogStatus { get; set; }
        public DateTime BdateTime { get; set; }


        public virtual ICollection<Posts> Posts { get; set; }
    }
}
