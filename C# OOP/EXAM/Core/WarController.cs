using System;
using System.Collections.Generic;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Core
{
	public class WarController
    {
        private List<Character> characters;

		public WarController()
        {
            characters = new List<Character>();
        }

		public string JoinParty(string[] args)
		{
			characters.AddRange(args);
		}

		public string AddItemToPool(string[] args)
		{
			throw new NotImplementedException();
		}

		public string PickUpItem(string[] args)
		{
			throw new NotImplementedException();
		}

		public string UseItem(string[] args)
		{
			throw new NotImplementedException();
		}

		public string GetStats()
		{
			throw new NotImplementedException();
		}

		public string Attack(string[] args)
		{
			throw new NotImplementedException();
		}

		public string Heal(string[] args)
		{
			throw new NotImplementedException();
		}
	}
}
