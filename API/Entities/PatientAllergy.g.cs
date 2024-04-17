using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientallergy entity with essential details
    /// </summary>
    public class PatientAllergy
    {
        /// <summary>
        /// Primary key for the PatientAllergy 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientAllergy 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PatientAllergy 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Sequence of the PatientAllergy 
        /// </summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// Allergy of the PatientAllergy 
        /// </summary>
        public string? Allergy { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientAllergy belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Summary of the PatientAllergy 
        /// </summary>
        public string? Summary { get; set; }
    }
}