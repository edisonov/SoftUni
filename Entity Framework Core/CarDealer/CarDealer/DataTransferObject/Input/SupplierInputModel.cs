﻿using System.Xml.Serialization;

namespace CarDealer.DataTransferObject.Input
{
    [XmlType("Supplier")]
    public class SupplierInputModel
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("isImporter")]
        public bool IsImporter { get; set; }
    }
}