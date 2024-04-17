using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a pricelistversion entity with essential details
    /// </summary>
    public class PriceListVersion
    {
        /// <summary>
        /// TenantId of the PriceListVersion 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListVersion 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// PriceListBaseType of the PriceListVersion 
        /// </summary>
        public int? PriceListBaseType { get; set; }
        /// <summary>
        /// PricelistType of the PriceListVersion 
        /// </summary>
        public int? PricelistType { get; set; }

        /// <summary>
        /// Required field Name of the PriceListVersion 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Notes of the PriceListVersion 
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// StartDate of the PriceListVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the PriceListVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListVersion belongs 
        /// </summary>
        public Guid? PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }
        /// <summary>
        /// Version of the PriceListVersion 
        /// </summary>
        public int? Version { get; set; }
        /// <summary>
        /// CreatedBy of the PriceListVersion 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PriceListVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
    }
}