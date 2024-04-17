using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientmedicalhistorynote entity with essential details
    /// </summary>
    public class PatientMedicalHistoryNote
    {
        /// <summary>
        /// Primary key for the PatientMedicalHistoryNote 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientMedicalHistoryNote 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PatientMedicalHistoryNote 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Notes of the PatientMedicalHistoryNote 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientMedicalHistoryNote belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
    }
}