using System.Collections.Generic;
using System.Linq;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;


namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private IList<IDecoration> decorations;

        public DecorationRepository()
        {
            decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => (IReadOnlyCollection<IDecoration>) decorations;


        public void Add(IDecoration model)
        {
            this.decorations.Add(model);
        }

        public bool Remove(IDecoration model)
        {

            if (decorations.Any(x => x.GetType().Name == model.GetType().Name))
            {
                this.decorations.Remove(model);
                return true;
            }

            return false;
        }

        public IDecoration FindByType(string type)
        { 
            IDecoration decoration = decorations.FirstOrDefault
                (x => x.GetType().Name == type);
            return decoration;
        }
    }
}