using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreceipt entity with essential details
    /// </summary>
    public class GoodsReceipt
    {
        /// <summary>
        /// Required field TenantId of the GoodsReceipt 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReceipt 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Code of the GoodsReceipt 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceipt 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// ReceivedDate of the GoodsReceipt 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptItem to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? GoodsReceiptItem { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptItem
        /// </summary>
        [ForeignKey("GoodsReceiptItem")]
        public GoodsReceiptItem? GoodsReceiptItem_GoodsReceiptItem { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturn to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? GoodsReturns { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturn
        /// </summary>
        [ForeignKey("GoodsReturns")]
        public GoodsReturn? GoodsReturns_GoodsReturn { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptActivityHistory to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? GoodsReceiptActivityHistory { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptActivityHistory
        /// </summary>
        [ForeignKey("GoodsReceiptActivityHistory")]
        public GoodsReceiptActivityHistory? GoodsReceiptActivityHistory_GoodsReceiptActivityHistory { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptFile to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? GoodsReceiptFile { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptFile
        /// </summary>
        [ForeignKey("GoodsReceiptFile")]
        public GoodsReceiptFile? GoodsReceiptFile_GoodsReceiptFile { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptPurchaseOrderRelation to which the GoodsReceipt belongs 
        /// </summary>
        public Guid? GoodsReceiptPurchaseOrderRelation { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptPurchaseOrderRelation
        /// </summary>
        [ForeignKey("GoodsReceiptPurchaseOrderRelation")]
        public GoodsReceiptPurchaseOrderRelation? GoodsReceiptPurchaseOrderRelation_GoodsReceiptPurchaseOrderRelation { get; set; }
        /// <summary>
        /// Supplier of the GoodsReceipt 
        /// </summary>
        public string? Supplier { get; set; }
        /// <summary>
        /// Reason of the GoodsReceipt 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// GoodsReceiptType of the GoodsReceipt 
        /// </summary>
        public int? GoodsReceiptType { get; set; }
        /// <summary>
        /// ReferenceNumber of the GoodsReceipt 
        /// </summary>
        public string? ReferenceNumber { get; set; }
    }
}