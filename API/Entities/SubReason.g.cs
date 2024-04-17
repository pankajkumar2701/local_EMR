using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a subreason entity with essential details
    /// </summary>
    public class SubReason
    {
        /// <summary>
        /// TenantId of the SubReason 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the SubReason 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the SubReason 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// CreatedBy of the SubReason 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the SubReason 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SubReason 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SubReason 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturn to which the SubReason belongs 
        /// </summary>
        public Guid? GoodsReturns { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturn
        /// </summary>
        [ForeignKey("GoodsReturns")]
        public GoodsReturn? GoodsReturns_GoodsReturn { get; set; }
    }
}