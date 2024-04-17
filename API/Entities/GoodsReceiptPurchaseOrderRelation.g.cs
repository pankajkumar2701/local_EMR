using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptpurchaseorderrelation entity with essential details
    /// </summary>
    public class GoodsReceiptPurchaseOrderRelation
    {
        /// <summary>
        /// Primary key for the GoodsReceiptPurchaseOrderRelation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the GoodsReceiptPurchaseOrderRelation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceiptPurchaseOrderRelation 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReceiptPurchaseOrderRelation belongs 
        /// </summary>
        [Required]
        public Guid GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// Foreign key referencing the PurchaseOrder to which the GoodsReceiptPurchaseOrderRelation belongs 
        /// </summary>
        public Guid? PurchaseOrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrder
        /// </summary>
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder? PurchaseOrderId_PurchaseOrder { get; set; }
    }
}