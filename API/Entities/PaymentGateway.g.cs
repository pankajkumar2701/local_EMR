using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a paymentgateway entity with essential details
    /// </summary>
    public class PaymentGateway
    {
        /// <summary>
        /// Primary key for the PaymentGateway 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PaymentGateway 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Name of the PaymentGateway 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Appointment to which the PaymentGateway belongs 
        /// </summary>
        public Guid? AppointmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Appointment
        /// </summary>
        [ForeignKey("AppointmentId")]
        public Appointment? AppointmentId_Appointment { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the PaymentGateway belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PaymentGateway belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the PaymentGateway belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// Amount of the PaymentGateway 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// RazorPayOrderId of the PaymentGateway 
        /// </summary>
        public string? RazorPayOrderId { get; set; }
        /// <summary>
        /// RazorPayPaymentLink of the PaymentGateway 
        /// </summary>
        public string? RazorPayPaymentLink { get; set; }
        /// <summary>
        /// RazorPayPaymentLinkId of the PaymentGateway 
        /// </summary>
        public string? RazorPayPaymentLinkId { get; set; }

        /// <summary>
        /// RazorPayLinkCreated of the PaymentGateway 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RazorPayLinkCreated { get; set; }

        /// <summary>
        /// RazorPayLinkExpired of the PaymentGateway 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RazorPayLinkExpired { get; set; }
        /// <summary>
        /// RazorPayPaymentId of the PaymentGateway 
        /// </summary>
        public string? RazorPayPaymentId { get; set; }
        /// <summary>
        /// RazorPayPaymentStatus of the PaymentGateway 
        /// </summary>
        public bool? RazorPayPaymentStatus { get; set; }
        /// <summary>
        /// RazorPaymentCapture of the PaymentGateway 
        /// </summary>
        public string? RazorPaymentCapture { get; set; }
        /// <summary>
        /// CreatedBy of the PaymentGateway 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PaymentGateway 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// UpdatedOn of the PaymentGateway 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// RazorPayRefundId of the PaymentGateway 
        /// </summary>
        public string? RazorPayRefundId { get; set; }

        /// <summary>
        /// RefundDate of the PaymentGateway 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RefundDate { get; set; }
    }
}