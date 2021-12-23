using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto
{
    [XmlType("Shell")]
    public class ShellDto
    {
        [XmlElement("ShellWeight")]
        [Range(2.0, 1680.0)]
        public double ShellWeight { get; set; }

        [Required]
        [XmlElement("Caliber")]
        [StringLength(30, MinimumLength = 4)]
        public string Caliber { get; set; }
    }
}