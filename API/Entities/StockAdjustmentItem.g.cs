using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a stockadjustmentitem entity with essential details
    /// </summary>
    public class StockAdjustmentItem
    {
        /// <summary>
        /// TenantId of the StockAdjustmentItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustmentItem 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the StockAdjustment to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? StockAdjustmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockAdjustment
        /// </summary>
        [ForeignKey("StockAdjustmentId")]
        public StockAdjustment? StockAdjustmentId_StockAdjustment { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// AdjustedQuantity of the StockAdjustmentItem 
        /// </summary>
        public int? AdjustedQuantity { get; set; }
        /// <summary>
        /// NewQoh of the StockAdjustmentItem 
        /// </summary>
        public int? NewQoh { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
        /// <summary>
        /// PackUnitPrice of the StockAdjustmentItem 
        /// </summary>
        public int? PackUnitPrice { get; set; }
        /// <summary>
        /// LineRejected of the StockAdjustmentItem 
        /// </summary>
        public bool? LineRejected { get; set; }
        /// <summary>
        /// RejectReason of the StockAdjustmentItem 
        /// </summary>
        public string? RejectReason { get; set; }

        /// <summary>
        /// Required field LowestUnitQuantity of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public int LowestUnitQuantity { get; set; }
        /// <summary>
        /// AdjustedAmount of the StockAdjustmentItem 
        /// </summary>
        public int? AdjustedAmount { get; set; }
    }
}