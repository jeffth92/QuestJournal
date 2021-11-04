using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestJounal.Data
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Location { get; set; }
        public string GMEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime JoinDate { get; set; } //might belong better in Player class.
        public bool IsActive { get; set; }

        [ForeignKey(nameof(AdminId))]
        public int AdminId { get; set; }

        [ForeignKey(nameof(PlayerRoster))]
        public List<Player> PlayerRoster { get; set; }
    }
}
