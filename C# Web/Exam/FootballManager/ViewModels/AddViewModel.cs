using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.ViewModels
{
    public class AddViewModel
    {
        [Required]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Position { get; set; }

        [Required]
        [Range(10, 100)]
        public byte Speed { get; set; }

        [Required]
        [Range(10, 100)]
        public byte Endurance { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Description { get; set; }

        //public ICollection<> MyProperty { get; set; }
    }
}
