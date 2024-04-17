using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patientpayor entity with essential details
    /// </summary>
    public class PatientPayor
    {
        /// <summary>
        /// Primary key for the PatientPayor 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the PatientPayor 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the PatientPayor 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the PatientPayor belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the ContactMember to which the PatientPayor belongs 
        /// </summary>
        public Guid? ContactMemberId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ContactMember
        /// </summary>
        [ForeignKey("ContactMemberId")]
        public ContactMember? ContactMemberId_ContactMember { get; set; }
        /// <summary>
        /// Default of the PatientPayor 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// CreatedBy of the PatientPayor 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PatientPayor 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PatientPayor 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PatientPayor 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}