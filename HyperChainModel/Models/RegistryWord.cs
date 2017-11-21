using HyperChainModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperChainModel.Models
{
    public class RegistryWord
    {
        //Primary key
        [Key]
        public int Id { get; set; }

        public string Word { get; set; }
        public int SemanticId { get; set; }
        public WordProcessedStatus Status { get; set; } = WordProcessedStatus.NotProcessed;

        // Navigation property 
        public virtual ICollection<WordChain> Links { get; set; }
    }
}
