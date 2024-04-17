using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a visitmedicalcertificate entity with essential details
    /// </summary>
    public class VisitMedicalCertificate
    {
        /// <summary>
        /// Primary key for the VisitMedicalCertificate 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the VisitMedicalCertificate 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the VisitMedicalCertificate 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the VisitMedicalCertificate belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the VisitMedicalCertificate belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }

        /// <summary>
        /// FromDate of the VisitMedicalCertificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// ToDate of the VisitMedicalCertificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        /// <summary>
        /// Reason of the VisitMedicalCertificate 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// CreatedBy of the VisitMedicalCertificate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the VisitMedicalCertificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the VisitMedicalCertificate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the VisitMedicalCertificate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the VisitMedicalCertificate belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// ProductName of the VisitMedicalCertificate 
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// Foreign key referencing the InvoiceLine to which the VisitMedicalCertificate belongs 
        /// </summary>
        public Guid? InvoiceLineId { get; set; }

        /// <summary>
        /// Navigation property representing the associated InvoiceLine
        /// </summary>
        [ForeignKey("InvoiceLineId")]
        public InvoiceLine? InvoiceLineId_InvoiceLine { get; set; }
    }
}