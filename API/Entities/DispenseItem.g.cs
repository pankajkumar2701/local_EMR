using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a dispenseitem entity with essential details
    /// </summary>
    public class DispenseItem
    {
        /// <summary>
        /// Primary key for the DispenseItem 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the DispenseItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the DispenseItem 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Dispense to which the DispenseItem belongs 
        /// </summary>
        public Guid? DispenseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Dispense
        /// </summary>
        [ForeignKey("DispenseId")]
        public Dispense? DispenseId_Dispense { get; set; }

        /// <summary>
        /// Required field Sequence of the DispenseItem 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the DispenseItem belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the DispenseItem belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// Quantity of the DispenseItem 
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// Summary of the DispenseItem 
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// ProductUomId of the DispenseItem 
        /// </summary>
        public Guid? ProductUomId { get; set; }
        /// <summary>
        /// LowestUnitQuantity of the DispenseItem 
        /// </summary>
        public int? LowestUnitQuantity { get; set; }
        /// <summary>
        /// UnitSellingPrice of the DispenseItem 
        /// </summary>
        public int? UnitSellingPrice { get; set; }
        /// <summary>
        /// TaxPercent of the DispenseItem 
        /// </summary>
        public int? TaxPercent { get; set; }
        /// <summary>
        /// TaxAmount of the DispenseItem 
        /// </summary>
        public int? TaxAmount { get; set; }
        /// <summary>
        /// DiscountPercent of the DispenseItem 
        /// </summary>
        public int? DiscountPercent { get; set; }
        /// <summary>
        /// DiscountAmount of the DispenseItem 
        /// </summary>
        public int? DiscountAmount { get; set; }
        /// <summary>
        /// DiscountType of the DispenseItem 
        /// </summary>
        public int? DiscountType { get; set; }
        /// <summary>
        /// TotalAmount of the DispenseItem 
        /// </summary>
        public int? TotalAmount { get; set; }
        /// <summary>
        /// HsnCode of the DispenseItem 
        /// </summary>
        public string? HsnCode { get; set; }
        /// <summary>
        /// Delete of the DispenseItem 
        /// </summary>
        public bool? Delete { get; set; }
        /// <summary>
        /// DeleteReason of the DispenseItem 
        /// </summary>
        public string? DeleteReason { get; set; }
        /// <summary>
        /// CreatedBy of the DispenseItem 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the DispenseItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DispenseItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DispenseItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// FromOpenPrescription of the DispenseItem 
        /// </summary>
        public bool? FromOpenPrescription { get; set; }
        /// <summary>
        /// Foreign key referencing the DispenseItemDosage to which the DispenseItem belongs 
        /// </summary>
        public Guid? DispenseItemDosage { get; set; }

        /// <summary>
        /// Navigation property representing the associated DispenseItemDosage
        /// </summary>
        [ForeignKey("DispenseItemDosage")]
        public DispenseItemDosage? DispenseItemDosage_DispenseItemDosage { get; set; }
    }
}