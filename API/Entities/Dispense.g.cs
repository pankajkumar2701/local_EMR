using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a dispense entity with essential details
    /// </summary>
    public class Dispense
    {
        /// <summary>
        /// Primary key for the Dispense 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Dispense 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Name of the Dispense 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Dispense belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the Dispense belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// DispenseNo of the Dispense 
        /// </summary>
        public string? DispenseNo { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the Dispense belongs 
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("InvoiceId")]
        public Invoice? InvoiceId_Invoice { get; set; }
        /// <summary>
        /// Closed of the Dispense 
        /// </summary>
        public bool? Closed { get; set; }
        /// <summary>
        /// CreatedBy of the Dispense 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Dispense 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Dispense 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Dispense 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Dispense belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the DispenseActivityHistory to which the Dispense belongs 
        /// </summary>
        public Guid? DispenseActivityHistory { get; set; }

        /// <summary>
        /// Navigation property representing the associated DispenseActivityHistory
        /// </summary>
        [ForeignKey("DispenseActivityHistory")]
        public DispenseActivityHistory? DispenseActivityHistory_DispenseActivityHistory { get; set; }
        /// <summary>
        /// Foreign key referencing the DispenseItem to which the Dispense belongs 
        /// </summary>
        public Guid? DispenseItems { get; set; }

        /// <summary>
        /// Navigation property representing the associated DispenseItem
        /// </summary>
        [ForeignKey("DispenseItems")]
        public DispenseItem? DispenseItems_DispenseItem { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientPharmacyQueue to which the Dispense belongs 
        /// </summary>
        public Guid? PatientPharmacyQueues { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientPharmacyQueue
        /// </summary>
        [ForeignKey("PatientPharmacyQueues")]
        public PatientPharmacyQueue? PatientPharmacyQueues_PatientPharmacyQueue { get; set; }
    }
}