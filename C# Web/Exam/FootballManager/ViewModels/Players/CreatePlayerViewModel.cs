using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.ViewModels.Players
{
    using static Data.DataContracts.Player;
    public class CreatePlayerViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(PlayernameMaxLength, MinimumLength = PlayernameMinLength, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(ImageUrlLenght)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(DescriptionMaxLenght)]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(PositionMaxLenght, MinimumLength = PositionMinLenght, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Position { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Endurance { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Speed { get; set; }
    }
}
