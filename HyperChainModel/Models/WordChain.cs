using HyperChainModel.Enums;
using System.ComponentModel.DataAnnotations;

namespace HyperChainModel.Models
{
    public class WordChain
    {
        //Primary key
        [Key]
        public int Id { get; set; }

        public bool AutoLink { get; set; }
        public WordChainType LinkType { get; set; }
        public int RelationGroupId { get; set; }

        // Foreign key
        public int ParentId { get; set; }
        public int ChildId { get; set; }

        // Navigation properties
        [Required]
        public virtual RegistryWord Parent { get; set; }
        [Required]
        public virtual RegistryWord Child { get; set; }
    }
}