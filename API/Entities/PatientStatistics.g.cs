using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientstatistics entity with essential details
    /// </summary>
    public class PatientStatistics
    {
        /// <summary>
        /// TenantId of the PatientStatistics 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PatientStatistics 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the PatientStatistics 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientStatistics belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// VisitCount of the PatientStatistics 
        /// </summary>
        public int? VisitCount { get; set; }
        /// <summary>
        /// CreatedBy of the PatientStatistics 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PatientStatistics 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PatientStatistics 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PatientStatistics 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// ApponumericmentCount of the PatientStatistics 
        /// </summary>
        public int? ApponumericmentCount { get; set; }
        /// <summary>
        /// PatientCount of the PatientStatistics 
        /// </summary>
        public int? PatientCount { get; set; }
    }
}