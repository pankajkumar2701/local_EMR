using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientpharmacyqueue entity with essential details
    /// </summary>
    public class PatientPharmacyQueue
    {
        /// <summary>
        /// TenantId of the PatientPharmacyQueue 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientPharmacyQueue 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the PatientPharmacyQueue 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientPharmacyQueue belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the PatientPharmacyQueue belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// Foreign key referencing the Dispense to which the PatientPharmacyQueue belongs 
        /// </summary>
        public Guid? DispenseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Dispense
        /// </summary>
        [ForeignKey("DispenseId")]
        public Dispense? DispenseId_Dispense { get; set; }
        /// <summary>
        /// CreatedBy of the PatientPharmacyQueue 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PatientPharmacyQueue 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PatientPharmacyQueue 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PatientPharmacyQueue 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Required field LocationId of the PatientPharmacyQueue 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }
    }
}