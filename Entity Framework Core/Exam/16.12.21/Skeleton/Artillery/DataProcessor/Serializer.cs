
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Artillery.Data.Models.Enums;
using Artillery.DataProcessor.ExportDto;
using Newtonsoft.Json;

namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using System;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            var result = context.Shells
                .Where(x => x.ShellWeight > shellWeight)
                .OrderBy(x => x.ShellWeight)
                .Select(s => new
            {
                ShellWeight = s.ShellWeight,
                Caliber = s.Caliber,
                Guns = s.Guns
                    .Where(gun => (int)gun.GunType == 3)
                    .OrderByDescending(x => x.GunWeight)
                    .Select(g => new
                {
                    GunType = g.GunType.ToString(),
                    GunWeight = g.GunWeight,
                    BarrelLength = g.BarrelLength,
                    Range = g.Range > 3000 ? "Long-range" : "Regular range",
                })
            })
                .ToArray();

            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            GunsExportDto[] gunsToExport = context.Guns
                                      .Where(g => g.Manufacturer.ManufacturerName == manufacturer)
                                      .OrderBy(g => g.BarrelLength)
                                      .Select(g => new GunsExportDto
                                      {
                                          Manufacturer = g.Manufacturer.ManufacturerName,
                                          GunType = g.GunType.ToString(),
                                          BarrelLength = g.BarrelLength,
                                          GunWeight = g.GunWeight,
                                          Range = g.Range,
                                          Countries = g.CountriesGuns
                                                       .Where(cg => cg.Country.ArmySize > 4500000)
                                                       .OrderBy(cg => cg.Country.ArmySize)
                                                       .Select(cg => new CountryExportDto
                                                       {
                                                           Country = cg.Country.CountryName,
                                                           ArmySize = cg.Country.ArmySize
                                                       })
                                                       .ToArray()

                                      })
                                      .ToArray();

            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Guns");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer serializer = new XmlSerializer(typeof(GunsExportDto[]), xmlRoot);

            using StringWriter sw = new StringWriter(sb);

            serializer.Serialize(sw, gunsToExport, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}
