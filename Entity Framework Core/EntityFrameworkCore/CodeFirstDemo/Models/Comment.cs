using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public sealed class Comment
    {

        public Comment()
        {
            this.NewsCollection = new HashSet<News>();
        }
        public int Id { get; set; }

        public int NewsId { get; set; }

        public News News { get; set; }

        [MaxLength(50)]
        public string Author { get; set; }

        public string Content { get; set; }

        public ICollection<News> NewsCollection { get; set; }

    }
}