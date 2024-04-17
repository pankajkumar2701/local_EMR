using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientpregnancy entity with essential details
    /// </summary>
    public class PatientPregnancy
    {
        /// <summary>
        /// TenantId of the PatientPregnancy 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientPregnancy 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the PatientPregnancy 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientPregnancy belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// IsPregnant of the PatientPregnancy 
        /// </summary>
        public bool? IsPregnant { get; set; }
        /// <summary>
        /// EntityCode of the PatientPregnancy 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the PatientPregnancy 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// CreatedBy of the PatientPregnancy 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PatientPregnancy 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Gravidity of the PatientPregnancy 
        /// </summary>
        public int? Gravidity { get; set; }
        /// <summary>
        /// Parity of the PatientPregnancy 
        /// </summary>
        public int? Parity { get; set; }
        /// <summary>
        /// Miscarriage of the PatientPregnancy 
        /// </summary>
        public int? Miscarriage { get; set; }
        /// <summary>
        /// Termination of the PatientPregnancy 
        /// </summary>
        public int? Termination { get; set; }

        /// <summary>
        /// EddDate of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EddDate { get; set; }

        /// <summary>
        /// LmpDate of the PatientPregnancy 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LmpDate { get; set; }
        /// <summary>
        /// Notes of the PatientPregnancy 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// PreferenceType of the PatientPregnancy 
        /// </summary>
        public int? PreferenceType { get; set; }
    }
}