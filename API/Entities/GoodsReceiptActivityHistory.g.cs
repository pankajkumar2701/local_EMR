using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptactivityhistory entity with essential details
    /// </summary>
    public class GoodsReceiptActivityHistory
    {
        /// <summary>
        /// Primary key for the GoodsReceiptActivityHistory 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the GoodsReceiptActivityHistory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceiptActivityHistory 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReceiptActivityHistory belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// FromStep of the GoodsReceiptActivityHistory 
        /// </summary>
        public int? FromStep { get; set; }
        /// <summary>
        /// ToStep of the GoodsReceiptActivityHistory 
        /// </summary>
        public int? ToStep { get; set; }
        /// <summary>
        /// Description of the GoodsReceiptActivityHistory 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Active of the GoodsReceiptActivityHistory 
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Reason of the GoodsReceiptActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the GoodsReceiptActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
    }
}