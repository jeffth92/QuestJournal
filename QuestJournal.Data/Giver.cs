using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestJounal.Data
{
    class Giver
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime EnteredGame { get; set; }
        public bool IsActive { get; set; }
    }
}
