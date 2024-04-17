using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a payment entity with essential details
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// TenantId of the Payment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Payment 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the Payment 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Payment belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the Payment belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// Foreign key referencing the PaymentMode to which the Payment belongs 
        /// </summary>
        public Guid? PaymentModeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PaymentMode
        /// </summary>
        [ForeignKey("PaymentModeId")]
        public PaymentMode? PaymentModeId_PaymentMode { get; set; }

        /// <summary>
        /// PaymentDate of the Payment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        /// <summary>
        /// Amount of the Payment 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Refund of the Payment 
        /// </summary>
        public bool? Refund { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Payment belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// RecievedBy of the Payment 
        /// </summary>
        public string? RecievedBy { get; set; }
    }
}