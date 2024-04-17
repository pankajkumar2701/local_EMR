using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a tokenmanagement entity with essential details
    /// </summary>
    public class TokenManagement
    {
        /// <summary>
        /// TenantId of the TokenManagement 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the TokenManagement 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the TokenManagement 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// TokenDate of the TokenManagement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? TokenDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the TokenManagement belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the TokenManagement belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
        /// <summary>
        /// TokenNumber of the TokenManagement 
        /// </summary>
        public int? TokenNumber { get; set; }
        /// <summary>
        /// PatientArrivalStatus of the TokenManagement 
        /// </summary>
        public int? PatientArrivalStatus { get; set; }
        /// <summary>
        /// CreatedBy of the TokenManagement 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the TokenManagement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the TokenManagement 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the TokenManagement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the TokenManagement belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the DayVisit to which the TokenManagement belongs 
        /// </summary>
        public Guid? DayVisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DayVisit
        /// </summary>
        [ForeignKey("DayVisitId")]
        public DayVisit? DayVisitId_DayVisit { get; set; }
    }
}