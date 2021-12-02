using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using CarDealer.Data;
using CarDealer.DataTransferObject.Input;
using CarDealer.Models;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var supplierXml = File.ReadAllText("./Datasets/suppliers.xml");
            var partsXml = File.ReadAllText("./Datasets/parts.xml");

            ImportSuppliers(context, supplierXml);
            var result = ImportParts(context, partsXml);

            Console.WriteLine(result);

        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            const string root = "Parts";

            var xmlSerializer = new XmlSerializer(typeof(PartInputModel[]), new XmlRootAttribute(root));

            var textReader = new StringReader(inputXml);

            var partInputModels = xmlSerializer.Deserialize(textReader) as PartInputModel[];

            var supplierIds = context.Suppliers.Select(x => x.Id).ToList();

            var parts = partInputModels
                .Where(s => supplierIds.Contains(s.SupplierId))
                .Select(x => new Part
                {
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    SupplierId = x.SupplierId
                })
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierInputModel[]),new XmlRootAttribute("Suppliers"));

            var textReader = new StringReader(inputXml);

            var suppliersDto = xmlSerializer.Deserialize(textReader) as SupplierInputModel[];

            var suppliers = suppliersDto.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.IsImporter,
            })
                .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();


            return $"Successfully imported {suppliers.Count}";
        }
    }
}