using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patienthospitalisationhistory entity with essential details
    /// </summary>
    public class PatientHospitalisationHistory
    {
        /// <summary>
        /// Primary key for the PatientHospitalisationHistory 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientHospitalisationHistory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PatientHospitalisationHistory 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientHospitalisationHistory belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// NoSignificantHospitalisation of the PatientHospitalisationHistory 
        /// </summary>
        public bool? NoSignificantHospitalisation { get; set; }
        /// <summary>
        /// Notes of the PatientHospitalisationHistory 
        /// </summary>
        public string? Notes { get; set; }
    }
}