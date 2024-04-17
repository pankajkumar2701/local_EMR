using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientlifestyle entity with essential details
    /// </summary>
    public class PatientLifeStyle
    {
        /// <summary>
        /// Primary key for the PatientLifeStyle 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientLifeStyle 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PatientLifeStyle 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the PatientLifeStyle 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// LifeStyleChoiceName of the PatientLifeStyle 
        /// </summary>
        public string? LifeStyleChoiceName { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientLifeStyle belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Summary of the PatientLifeStyle 
        /// </summary>
        public string? Summary { get; set; }
    }
}