using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitytesting.Models
{
    public class DBInitializer
    {
        public static void Initialize(PlayerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Characters.Any())
            {
                return;
            }

            var characters = new Character[]
            {
                new Character{Name="Thomas"},
                new Character{Name="Willow"},
                new Character{Name="Dirt"}
            };

            foreach (Character c in characters)
            {
                context.Characters.Add(c);
            }
            context.SaveChanges();
        }
    }
}
