using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a procedure entity with essential details
    /// </summary>
    public class Procedure
    {
        /// <summary>
        /// TenantId of the Procedure 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Procedure 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Procedure 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the Procedure 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Favourite of the Procedure 
        /// </summary>
        public bool? Favourite { get; set; }
        /// <summary>
        /// IsDeleted of the Procedure 
        /// </summary>
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// FemaleOnly of the Procedure 
        /// </summary>
        public bool? FemaleOnly { get; set; }
        /// <summary>
        /// NoKnownProcedure of the Procedure 
        /// </summary>
        public bool? NoKnownProcedure { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the Procedure belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
    }
}