using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreturn entity with essential details
    /// </summary>
    public class GoodsReturn
    {
        /// <summary>
        /// TenantId of the GoodsReturn 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReturn 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// GrrNumber of the GoodsReturn 
        /// </summary>
        public string? GrrNumber { get; set; }

        /// <summary>
        /// ReturnDate of the GoodsReturn 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReturn belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// Supplier of the GoodsReturn 
        /// </summary>
        public string? Supplier { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the GoodsReturn belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturnFile to which the GoodsReturn belongs 
        /// </summary>
        public Guid? GoodsReturnFile { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturnFile
        /// </summary>
        [ForeignKey("GoodsReturnFile")]
        public GoodsReturnFile? GoodsReturnFile_GoodsReturnFile { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturnItem to which the GoodsReturn belongs 
        /// </summary>
        public Guid? GoodsReturnItem { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturnItem
        /// </summary>
        [ForeignKey("GoodsReturnItem")]
        public GoodsReturnItem? GoodsReturnItem_GoodsReturnItem { get; set; }
        /// <summary>
        /// Foreign key referencing the SubReason to which the GoodsReturn belongs 
        /// </summary>
        public Guid? SubReason { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubReason
        /// </summary>
        [ForeignKey("SubReason")]
        public SubReason? SubReason_SubReason { get; set; }
        /// <summary>
        /// Reason of the GoodsReturn 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ReferrenceNo of the GoodsReturn 
        /// </summary>
        public string? ReferrenceNo { get; set; }
    }
}