using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptitem entity with essential details
    /// </summary>
    public class GoodsReceiptItem
    {
        /// <summary>
        /// TenantId of the GoodsReceiptItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReceiptItem 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReceiptItem 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReceiptItem belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the GoodsReceiptItem belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the GoodsReceiptItem belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// ReceivedQuantity of the GoodsReceiptItem 
        /// </summary>
        public int? ReceivedQuantity { get; set; }
        /// <summary>
        /// PackUnitPrice of the GoodsReceiptItem 
        /// </summary>
        public int? PackUnitPrice { get; set; }
        /// <summary>
        /// OrderQuantity of the GoodsReceiptItem 
        /// </summary>
        public int? OrderQuantity { get; set; }
        /// <summary>
        /// RemainingQuantity of the GoodsReceiptItem 
        /// </summary>
        public int? RemainingQuantity { get; set; }
        /// <summary>
        /// ProductUomId of the GoodsReceiptItem 
        /// </summary>
        public Guid? ProductUomId { get; set; }
        /// <summary>
        /// TotalCost of the GoodsReceiptItem 
        /// </summary>
        public int? TotalCost { get; set; }
        /// <summary>
        /// LineRejected of the GoodsReceiptItem 
        /// </summary>
        public bool? LineRejected { get; set; }
        /// <summary>
        /// Reason of the GoodsReceiptItem 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// Foreign key referencing the PurchaseOrder to which the GoodsReceiptItem belongs 
        /// </summary>
        public Guid? PurchaseOrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrder
        /// </summary>
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder? PurchaseOrderId_PurchaseOrder { get; set; }
        /// <summary>
        /// Foreign key referencing the PurchaseOrderLine to which the GoodsReceiptItem belongs 
        /// </summary>
        public Guid? PurchaseOrderLineId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrderLine
        /// </summary>
        [ForeignKey("PurchaseOrderLineId")]
        public PurchaseOrderLine? PurchaseOrderLineId_PurchaseOrderLine { get; set; }
        /// <summary>
        /// TaxAmount of the GoodsReceiptItem 
        /// </summary>
        public int? TaxAmount { get; set; }
        /// <summary>
        /// LowestUnitQuantity of the GoodsReceiptItem 
        /// </summary>
        public int? LowestUnitQuantity { get; set; }
        /// <summary>
        /// Bonus of the GoodsReceiptItem 
        /// </summary>
        public bool? Bonus { get; set; }
        /// <summary>
        /// BatchNumber of the GoodsReceiptItem 
        /// </summary>
        public string? BatchNumber { get; set; }

        /// <summary>
        /// ExpiryDate of the GoodsReceiptItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// ManufactureDate of the GoodsReceiptItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
    }
}