using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreturnitem entity with essential details
    /// </summary>
    public class GoodsReturnItem
    {
        /// <summary>
        /// TenantId of the GoodsReturnItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReturnItem 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReturnItem 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturn to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? GoodsReturnId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturn
        /// </summary>
        [ForeignKey("GoodsReturnId")]
        public GoodsReturn? GoodsReturnId_GoodsReturn { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptItem to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? GoodsReceiptItemId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptItem
        /// </summary>
        [ForeignKey("GoodsReceiptItemId")]
        public GoodsReceiptItem? GoodsReceiptItemId_GoodsReceiptItem { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? ProductUom { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUom")]
        public ProductUom? ProductUom_ProductUom { get; set; }
        /// <summary>
        /// Foreign key referencing the SubReason to which the GoodsReturnItem belongs 
        /// </summary>
        public Guid? SubReason { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubReason
        /// </summary>
        [ForeignKey("SubReason")]
        public SubReason? SubReason_SubReason { get; set; }
        /// <summary>
        /// UnitPrice of the GoodsReturnItem 
        /// </summary>
        public int? UnitPrice { get; set; }
        /// <summary>
        /// ReturnQuantity of the GoodsReturnItem 
        /// </summary>
        public int? ReturnQuantity { get; set; }
        /// <summary>
        /// ReturnUomType of the GoodsReturnItem 
        /// </summary>
        public int? ReturnUomType { get; set; }
        /// <summary>
        /// RemainingQuantity of the GoodsReturnItem 
        /// </summary>
        public int? RemainingQuantity { get; set; }
        /// <summary>
        /// TotalQuantity of the GoodsReturnItem 
        /// </summary>
        public int? TotalQuantity { get; set; }
        /// <summary>
        /// TotalAmount of the GoodsReturnItem 
        /// </summary>
        public int? TotalAmount { get; set; }
        /// <summary>
        /// LineRejected of the GoodsReturnItem 
        /// </summary>
        public bool? LineRejected { get; set; }
        /// <summary>
        /// Reason of the GoodsReturnItem 
        /// </summary>
        public string? Reason { get; set; }
    }
}