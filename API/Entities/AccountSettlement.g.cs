using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a accountsettlement entity with essential details
    /// </summary>
    public class AccountSettlement
    {
        /// <summary>
        /// Primary key for the AccountSettlement 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the AccountSettlement 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the AccountSettlement 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Appointment to which the AccountSettlement belongs 
        /// </summary>
        public Guid? AppointmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Appointment
        /// </summary>
        [ForeignKey("AppointmentId")]
        public Appointment? AppointmentId_Appointment { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the AccountSettlement belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// RazorPayTransferId of the AccountSettlement 
        /// </summary>
        public string? RazorPayTransferId { get; set; }
        /// <summary>
        /// RazorPaySourceAccountId of the AccountSettlement 
        /// </summary>
        public string? RazorPaySourceAccountId { get; set; }
        /// <summary>
        /// RazorPayRecipientAccountId of the AccountSettlement 
        /// </summary>
        public string? RazorPayRecipientAccountId { get; set; }
        /// <summary>
        /// Amount of the AccountSettlement 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Foreign key referencing the Currency to which the AccountSettlement belongs 
        /// </summary>
        public Guid? Currency { get; set; }

        /// <summary>
        /// Navigation property representing the associated Currency
        /// </summary>
        [ForeignKey("Currency")]
        public Currency? Currency_Currency { get; set; }
        /// <summary>
        /// RazorPayStatus of the AccountSettlement 
        /// </summary>
        public string? RazorPayStatus { get; set; }

        /// <summary>
        /// CreatedDate of the AccountSettlement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
    }
}