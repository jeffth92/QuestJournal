using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestJounal.Data
{
    public class Quest
    {
        [Key]
        public int Id { get; set; }
        public string QuestName { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public string Location { get; set; } 
    }
}
