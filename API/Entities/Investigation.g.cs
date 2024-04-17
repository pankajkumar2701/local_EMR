using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a investigation entity with essential details
    /// </summary>
    public class Investigation
    {
        /// <summary>
        /// TenantId of the Investigation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Investigation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Sequence of the Investigation 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// InvestigationProfile of the Investigation 
        /// </summary>
        public bool? InvestigationProfile { get; set; }
        /// <summary>
        /// IsDeleted of the Investigation 
        /// </summary>
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the Investigation belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
    }
}