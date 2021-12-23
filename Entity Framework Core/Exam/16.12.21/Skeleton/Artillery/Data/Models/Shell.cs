using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models
{
    public class Shell
    {
        public Shell()
        {
            this.Guns = new HashSet<Gun>();
        }
        public int Id { get; set; }

        [Range(2.0, maximum: 1680.0)]
        public double ShellWeight { get; set; }

        [Required]
        [MaxLength(30)]
        public string Caliber { get; set; }

        public ICollection<Gun> Guns { get; set; }
    }
}

//• Id – integer, Primary Key
//• ShellWeight – double in range  [2…1_680] (required)
//    • Caliber – text with length [4…30] (required)
//    • Guns – a collection of Gun