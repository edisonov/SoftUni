using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using VaporStore.Data.Models;
using VaporStore.DataProcessor.Dto.Import;

namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Data;

	public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var games = JsonConvert.DeserializeObject<IEnumerable<GameJsonImportModel>>(jsonString);

            foreach (var jsonGames in games)
            {
                if (!IsValid(jsonGames) || !jsonGames.Tags.Any())
                {
                    sb.AppendLine("Invalid Data");
					continue;
                }

                var genre = context.Genres.FirstOrDefault(x => x.Name == jsonGames.Genre)
                    ?? new Genre { Name = jsonGames.Genre };
                var developer = context.Developers.FirstOrDefault(x => x.Name == jsonGames.Developer) ??
                                new Developer {Name = jsonGames.Developer};
                //if (genre == null)
                //{
                //    genre = new Genre { Name = games.Genre };
                //}

                var game = new Game
                {
                    Name = jsonGames.Name,
                    Genre = genre,
                    Developer = developer,
                    Price = jsonGames.Price,
                    ReleaseDate = jsonGames.ReleaseDate.Value
                };
                foreach (var tag in jsonGames.Tags)
                {
                    var tags = context.Tags.FirstOrDefault(x => x.Name == tag)
                               ?? new Tag {Name = tag};
                    game.GameTags.Add(new GameTag{Tag = tags});
                }

                context.Games.Add(game);
                context.SaveChanges();
                sb.AppendLine($"Added {jsonGames.Name} ({jsonGames.Genre}) with {jsonGames.Tags.Count()} tags");
            }

            return sb.ToString().TrimEnd();
        }

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var users = JsonConvert.DeserializeObject<IEnumerable<UserJsonImportModel>>(jsonString);

            foreach (var jsonUser in users)
            {
                if (!IsValid(jsonUser) || !jsonUser.Cards.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var user = new User
                {
                    Age = jsonUser.Age,
                    Email = jsonUser.Email,
                    FullName = jsonUser.FullName,
                    Username = jsonUser.Username,
                    Cards = jsonUser.Cards.Select(x => new Card
                    {
                        Cvc = x.CVC,
                        Number = x.Number,
                        Type = x.Type.Value
                    }).ToList(),
                };
                context.Users.Add(user);
                sb.AppendLine($"Imported {jsonUser.Username} with {jsonUser.Cards.Count()} cards");
            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var xmlSerializer = new XmlSerializer(typeof(PurchasesXmlImportModel[]),
                new XmlRootAttribute("Purchases"));

            var purchases = (PurchasesXmlImportModel[])xmlSerializer.Deserialize(new StringReader(xmlString));

            foreach (var xmlPurchase in purchases)
            {
                if (!IsValid(xmlPurchase))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var parsedDate = DateTime.TryParseExact(
                    xmlPurchase.Date, "dd/MM/yyyy HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);

                if (!parsedDate)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var purchase = new Purchase
                {
                    Date = date,
                    Type = xmlPurchase.Type.Value,
                    ProductKey = xmlPurchase.Key,
                    Card = context.Cards.FirstOrDefault(x => x.Number == xmlPurchase.Card),
                    Game = context.Games.FirstOrDefault(x => x.Name == xmlPurchase.Title)
                };

                context.Purchases.Add(purchase);

                var userName = context.Users.Where(x => x.Id == purchase.Card.UserId).Select(x => x.Username)
                    .FirstOrDefault();

                sb.AppendLine($"Imported {xmlPurchase.Title} for {userName}");

            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}