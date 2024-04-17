using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a purchaseorderfile entity with essential details
    /// </summary>
    public class PurchaseOrderFile
    {
        /// <summary>
        /// Primary key for the PurchaseOrderFile 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PurchaseOrderFile 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PurchaseOrderFile 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the PurchaseOrder to which the PurchaseOrderFile belongs 
        /// </summary>
        public Guid? PurchaseOrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrder
        /// </summary>
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder? PurchaseOrderId_PurchaseOrder { get; set; }
        /// <summary>
        /// PurchaseOrderCode of the PurchaseOrderFile 
        /// </summary>
        public string? PurchaseOrderCode { get; set; }
        /// <summary>
        /// Title of the PurchaseOrderFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the PurchaseOrderFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the PurchaseOrderFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the PurchaseOrderFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the PurchaseOrderFile 
        /// </summary>
        public string? AzureFilePath { get; set; }
        /// <summary>
        /// CreatedBy of the PurchaseOrderFile 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PurchaseOrderFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Print of the PurchaseOrderFile 
        /// </summary>
        public bool? Print { get; set; }
    }
}