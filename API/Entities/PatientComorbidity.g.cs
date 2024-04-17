using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientcomorbidity entity with essential details
    /// </summary>
    public class PatientComorbidity
    {
        /// <summary>
        /// TenantId of the PatientComorbidity 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientComorbidity 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the PatientComorbidity 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field Sequence of the PatientComorbidity 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Summary of the PatientComorbidity 
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// Foreign key referencing the Comorbidity to which the PatientComorbidity belongs 
        /// </summary>
        public Guid? ComorbidityId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Comorbidity
        /// </summary>
        [ForeignKey("ComorbidityId")]
        public Comorbidity? ComorbidityId_Comorbidity { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientComorbidity belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
    }
}