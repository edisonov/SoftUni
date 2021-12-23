using System.Linq;
using System.Text;
using Artillery.Data.Models;
using Artillery.Data.Models.Enums;
using Artillery.DataProcessor.ImportDto;
using Newtonsoft.Json;
using Country = Artillery.Data.Models.Country;

namespace Artillery.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Artillery.Data;

    public class Deserializer
    {
        private const string ErrorMessage =
                "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var validCountries = new List<Country>();

            var countries = XmlConverter.Deserializer<CountryDto>(xmlString, "Countries");

            foreach (var countryDto in countries)
            {
                if (!IsValid(countryDto))
                {
                    sb.AppendLine("Invalid data.");
                    continue;
                }

                var country = new Country
                {
                    CountryName = countryDto.CountryName,
                    ArmySize = countryDto.ArmySize
                };

                validCountries.Add(country);

                sb.AppendLine($"Successfully import {countryDto.CountryName} with {countryDto.ArmySize} army personnel.");
            }

            context.AddRange(validCountries);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var validManufacturer = new List<Manufacturer>();

            var manufacturers = XmlConverter.Deserializer<ManufacturerDto>(xmlString, "Manufacturers");

            foreach (var manufacturerDto in manufacturers)
            {
                if (!IsValid(manufacturerDto))
                {
                    sb.AppendLine("Invalid data.");
                    continue;
                }

                if (validManufacturer.Any(m => m.ManufacturerName == manufacturerDto.ManufacturerName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string[] foundedDataArray = manufacturerDto.Founded.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (foundedDataArray.Length < 2)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string countryName = foundedDataArray[foundedDataArray.Length - 1];
                string townName = foundedDataArray[foundedDataArray.Length - 2];

                var manufacturer = new Manufacturer
                {
                    ManufacturerName = manufacturerDto.ManufacturerName,
                    Founded = manufacturerDto.Founded
                };

                
                validManufacturer.Add(manufacturer);

                sb.AppendLine(string.Format(SuccessfulImportManufacturer, manufacturer.ManufacturerName, $"{townName}, {countryName}"));
            }

            context.AddRange(validManufacturer);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var validShell = new List<Shell>();

            var shells = XmlConverter.Deserializer<ShellDto>(xmlString, "Shells");

            foreach (var shellDto in shells)
            {
                if (!IsValid(shellDto))
                {
                    sb.AppendLine("Invalid data.");
                    continue;
                }

                var shell = new Shell
                {
                    ShellWeight = shellDto.ShellWeight,
                    Caliber = shellDto.Caliber
                };

                validShell.Add(shell);

                sb.AppendLine($"Successfully import shell caliber #{shellDto.Caliber} weight {shellDto.ShellWeight} kg.");
            }

            context.AddRange(validShell);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var validGuns = new List<Gun>();

            var guns = JsonConvert.DeserializeObject<IEnumerable<GunDto>>(jsonString);

            foreach (var gunDto in guns)
            {
                if (!IsValid(gunDto))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                bool hasGunType = Enum.TryParse<GunType>(gunDto.GunType, true, out GunType gunType);


                if (!hasGunType)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var gun = new Gun
                {
                    ManufacturerId = gunDto.ManufacturerId,
                    GunWeight = gunDto.GunWeight,
                    BarrelLength = gunDto.BarrelLength,
                    NumberBuild = gunDto.NumberBuild,
                    Range = gunDto.Range,
                    ShellId = gunDto.ShellId,
                    GunType = gunType,
                };

                HashSet<CountryGun> countryGuns = new HashSet<CountryGun>();

                foreach (var countryId in gunDto.Countries)
                {
                    Country country = context.Countries.FirstOrDefault(c => c.Id == countryId.Id);

                    CountryGun countryGun = new CountryGun()
                    {
                        Gun = gun,
                        Country = country
                    };

                    countryGuns.Add(countryGun);
                }

                gun.CountriesGuns = countryGuns;

                validGuns.Add(gun);

                sb.AppendLine(string.Format(SuccessfulImportGun, gun.GunType, gun.GunWeight, gun.BarrelLength));
            }

            context.AddRange(validGuns);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
