using System;
using System.Collections.Generic;

#nullable disable

namespace OrmFundamental.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string DirectorName { get; set; }
        public string Notes { get; set; }
    }
}
