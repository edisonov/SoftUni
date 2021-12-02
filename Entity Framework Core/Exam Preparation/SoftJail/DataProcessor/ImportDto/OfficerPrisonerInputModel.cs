﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using SoftJail.Data.Models.Enums;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Officer")]
    public class OfficerPrisonerInputModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [XmlElement("Name")]
        public string Name { get; set; }
        
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        [XmlElement("Money")]
        public decimal Money { get; set; }
        
        [EnumDataType(typeof(Position))]
        [XmlElement("Position")]
        public string Position { get; set; }
        
        [EnumDataType(typeof(Weapon))]
        [XmlElement("Weapon")]
        public string Weapon { get; set; }

        [XmlElement("DepartmentId")]
        public int DepartmentId { get; set; }
        
        [XmlArray("Prisoners")]
        public PrisonerIdInputModel[] Prisoners { get; set; }
    }

    [XmlType("Prisoner")]
    public class PrisonerIdInputModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }

    //<? xml version='1.0' encoding='UTF-8'?>
    //<Officers>
    //<Officer>
    //<Name>Minerva Kitchingman</Name>
    //<Money>2582</Money>
    //<Position>Invalid</Position>
    //<Weapon>ChainRifle</Weapon>
    //<DepartmentId>2</DepartmentId>
    //<Prisoners>
    //<Prisoner id = "15" />
    //</ Prisoners >
    //</ Officer >
}