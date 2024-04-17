using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a product entity with essential details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// TenantId of the Product 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Product 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// OnlineDefault of the Product 
        /// </summary>
        public bool? OnlineDefault { get; set; }
        /// <summary>
        /// Default of the Product 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductCategory to which the Product belongs 
        /// </summary>
        public Guid? ProductCategoryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductCategory
        /// </summary>
        [ForeignKey("ProductCategoryId")]
        public ProductCategory? ProductCategoryId_ProductCategory { get; set; }
        /// <summary>
        /// ProductType of the Product 
        /// </summary>
        public int? ProductType { get; set; }
        /// <summary>
        /// Inventoried of the Product 
        /// </summary>
        public bool? Inventoried { get; set; }
        /// <summary>
        /// HsnCode of the Product 
        /// </summary>
        public string? HsnCode { get; set; }
        /// <summary>
        /// ProductManufactureId of the Product 
        /// </summary>
        public Guid? ProductManufactureId { get; set; }
        /// <summary>
        /// Description of the Product 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// FormulationId of the Product 
        /// </summary>
        public Guid? FormulationId { get; set; }
        /// <summary>
        /// ScheduleDrug of the Product 
        /// </summary>
        public int? ScheduleDrug { get; set; }
        /// <summary>
        /// ProductClassificationId of the Product 
        /// </summary>
        public Guid? ProductClassificationId { get; set; }
        /// <summary>
        /// LowestUomId of the Product 
        /// </summary>
        public Guid? LowestUomId { get; set; }
        /// <summary>
        /// BaseType of the Product 
        /// </summary>
        public int? BaseType { get; set; }
        /// <summary>
        /// Status of the Product 
        /// </summary>
        public bool? Status { get; set; }
        /// <summary>
        /// ReOrderLevel of the Product 
        /// </summary>
        public int? ReOrderLevel { get; set; }
        /// <summary>
        /// ReOrderQuantity of the Product 
        /// </summary>
        public int? ReOrderQuantity { get; set; }
        /// <summary>
        /// GstCategoryId of the Product 
        /// </summary>
        public Guid? GstCategoryId { get; set; }
        /// <summary>
        /// GstPercentage of the Product 
        /// </summary>
        public int? GstPercentage { get; set; }
        /// <summary>
        /// ReOrderQuantityUomId of the Product 
        /// </summary>
        public Guid? ReOrderQuantityUomId { get; set; }
        /// <summary>
        /// DrugScheduleId of the Product 
        /// </summary>
        public Guid? DrugScheduleId { get; set; }
        /// <summary>
        /// ComponentType of the Product 
        /// </summary>
        public int? ComponentType { get; set; }
        /// <summary>
        /// InvestigationId of the Product 
        /// </summary>
        public Guid? InvestigationId { get; set; }
        /// <summary>
        /// ProcedureId of the Product 
        /// </summary>
        public Guid? ProcedureId { get; set; }
        /// <summary>
        /// ContactId of the Product 
        /// </summary>
        public Guid? ContactId { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the Product belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
        /// <summary>
        /// Import of the Product 
        /// </summary>
        public bool? Import { get; set; }

        /// <summary>
        /// SellingStartDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingStartDate { get; set; }

        /// <summary>
        /// SellingEndDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingEndDate { get; set; }
        /// <summary>
        /// SellingPrice of the Product 
        /// </summary>
        public int? SellingPrice { get; set; }
        /// <summary>
        /// Error of the Product 
        /// </summary>
        public string? Error { get; set; }
        /// <summary>
        /// BasePrice of the Product 
        /// </summary>
        public int? BasePrice { get; set; }
        /// <summary>
        /// Price of the Product 
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// Qoh of the Product 
        /// </summary>
        public int? Qoh { get; set; }
        /// <summary>
        /// Foreign key referencing the Investigation to which the Product belongs 
        /// </summary>
        public Guid? Investigation { get; set; }

        /// <summary>
        /// Navigation property representing the associated Investigation
        /// </summary>
        [ForeignKey("Investigation")]
        public Investigation? Investigation_Investigation { get; set; }
        /// <summary>
        /// Foreign key referencing the Procedure to which the Product belongs 
        /// </summary>
        public Guid? Procedure { get; set; }

        /// <summary>
        /// Navigation property representing the associated Procedure
        /// </summary>
        [ForeignKey("Procedure")]
        public Procedure? Procedure_Procedure { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the Product belongs 
        /// </summary>
        public Guid? Contact { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("Contact")]
        public Address? Contact_Address { get; set; }
        /// <summary>
        /// Foreign key referencing the Formulation to which the Product belongs 
        /// </summary>
        public Guid? Formulation { get; set; }

        /// <summary>
        /// Navigation property representing the associated Formulation
        /// </summary>
        [ForeignKey("Formulation")]
        public Formulation? Formulation_Formulation { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductManufacture to which the Product belongs 
        /// </summary>
        public Guid? ProductManufacture { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductManufacture
        /// </summary>
        [ForeignKey("ProductManufacture")]
        public ProductManufacture? ProductManufacture_ProductManufacture { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductClassification to which the Product belongs 
        /// </summary>
        public Guid? ProductClassification { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductClassification
        /// </summary>
        [ForeignKey("ProductClassification")]
        public ProductClassification? ProductClassification_ProductClassification { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the Product belongs 
        /// </summary>
        public Guid? Uom { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("Uom")]
        public Uom? Uom_Uom { get; set; }
        /// <summary>
        /// Foreign key referencing the GstSettings to which the Product belongs 
        /// </summary>
        public Guid? GstSettings { get; set; }

        /// <summary>
        /// Navigation property representing the associated GstSettings
        /// </summary>
        [ForeignKey("GstSettings")]
        public GstSettings? GstSettings_GstSettings { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the Product belongs 
        /// </summary>
        public Guid? ProductUoms { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUoms")]
        public ProductUom? ProductUoms_ProductUom { get; set; }
        /// <summary>
        /// Foreign key referencing the FinanceSetting to which the Product belongs 
        /// </summary>
        public Guid? FinanceSettings { get; set; }

        /// <summary>
        /// Navigation property representing the associated FinanceSetting
        /// </summary>
        [ForeignKey("FinanceSettings")]
        public FinanceSetting? FinanceSettings_FinanceSetting { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the Product belongs 
        /// </summary>
        public Guid? ProductBatch { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatch")]
        public ProductBatch? ProductBatch_ProductBatch { get; set; }
    }
}