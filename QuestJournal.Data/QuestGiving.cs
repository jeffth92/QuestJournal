using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestJounal.Data
{
    public class QuestGiving
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(GiverId))] //IS THIS RIGHT?
        public int GiverId { get; set; }

        [ForeignKey(nameof(QuestId))]
        public int QuestId { get; set; }
    }
}
