using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitytesting.Models
{
    public class Character
    {
        public int CharacterID { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        
        public ICollection<CharacterSheet> CharacterSheet { get; set; }
    }
}
