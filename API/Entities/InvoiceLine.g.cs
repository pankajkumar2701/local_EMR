using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a invoiceline entity with essential details
    /// </summary>
    public class InvoiceLine
    {
        /// <summary>
        /// TenantId of the InvoiceLine 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the InvoiceLine 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the InvoiceLine 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the InvoiceLine belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the InvoiceLine belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Description of the InvoiceLine 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Quantity of the InvoiceLine 
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// UnitPrice of the InvoiceLine 
        /// </summary>
        public int? UnitPrice { get; set; }
        /// <summary>
        /// DiscountTotal of the InvoiceLine 
        /// </summary>
        public int? DiscountTotal { get; set; }
        /// <summary>
        /// DiscountPercentage of the InvoiceLine 
        /// </summary>
        public bool? DiscountPercentage { get; set; }
        /// <summary>
        /// Amount of the InvoiceLine 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// CoPayAmount of the InvoiceLine 
        /// </summary>
        public int? CoPayAmount { get; set; }
        /// <summary>
        /// PayorAmount of the InvoiceLine 
        /// </summary>
        public int? PayorAmount { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the InvoiceLine belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// BatchNumber of the InvoiceLine 
        /// </summary>
        public string? BatchNumber { get; set; }

        /// <summary>
        /// BatchExapiryDate of the InvoiceLine 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? BatchExapiryDate { get; set; }
        /// <summary>
        /// CostPrice of the InvoiceLine 
        /// </summary>
        public int? CostPrice { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the InvoiceLine belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
        /// <summary>
        /// Foreign key referencing the GstSettings to which the InvoiceLine belongs 
        /// </summary>
        public Guid? GstSettingsId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GstSettings
        /// </summary>
        [ForeignKey("GstSettingsId")]
        public GstSettings? GstSettingsId_GstSettings { get; set; }
        /// <summary>
        /// GstPercentage of the InvoiceLine 
        /// </summary>
        public int? GstPercentage { get; set; }
        /// <summary>
        /// DiscountValue of the InvoiceLine 
        /// </summary>
        public int? DiscountValue { get; set; }
        /// <summary>
        /// HsnCode of the InvoiceLine 
        /// </summary>
        public string? HsnCode { get; set; }
        /// <summary>
        /// TaxAmount of the InvoiceLine 
        /// </summary>
        public int? TaxAmount { get; set; }
        /// <summary>
        /// Dispensed of the InvoiceLine 
        /// </summary>
        public bool? Dispensed { get; set; }
    }
}