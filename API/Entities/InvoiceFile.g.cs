using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a invoicefile entity with essential details
    /// </summary>
    public class InvoiceFile
    {
        /// <summary>
        /// Primary key for the InvoiceFile 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the InvoiceFile 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the InvoiceFile 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the InvoiceFile belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// InvoiceCode of the InvoiceFile 
        /// </summary>
        public string? InvoiceCode { get; set; }

        /// <summary>
        /// InvoiceDate of the InvoiceFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        /// <summary>
        /// CreatedBy of the InvoiceFile 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the InvoiceFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Title of the InvoiceFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the InvoiceFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the InvoiceFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the InvoiceFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the InvoiceFile 
        /// </summary>
        public string? AzureFilePath { get; set; }
        /// <summary>
        /// Paid of the InvoiceFile 
        /// </summary>
        public bool? Paid { get; set; }
    }
}