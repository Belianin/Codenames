using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenames
{
    public class RandomNamesRepository : INamesRepository
    {
        private readonly Random random = new Random();
        private readonly string[] names = new string[]
        {
            "Пунга", "Квир", "Челендик", "Хост", "Вассиан", "Гордий", "Севастина", "Ксома", "Пожухмен"
        };

        private readonly string[] traits = new string[]
        {
            "Находчивость", "Сила воли", "Наивность", "Хитрость", "Прикольность"
        };

        public IEnumerable<Name> GetByDate(DateTime date)
        {
            for (int i = 0; i < random.Next(3) + 1; i++)
            {
                var name = new Name();
                name.Value = names[random.Next(names.Length)];
                var traits = new List<Trait>();
                for (int y = 0; y < random.Next(3) + 1; y++)
                {
                    traits.Add(new Trait()
                    {
                        Name = this.traits[random.Next(this.traits.Length)],
                        Mark = random.Next(6)
                    });
                }
                name.Traits = traits.ToArray();

                yield return name;
            }
        }
    }
}
