using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestJounal.Data
{
    public class QuestBelonging
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }

        [ForeignKey(nameof(QuestId))]
        public int QuestId { get; set; }
    }
}
