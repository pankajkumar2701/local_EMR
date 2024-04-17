using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a doctorinvestigation entity with essential details
    /// </summary>
    public class DoctorInvestigation
    {
        /// <summary>
        /// TenantId of the DoctorInvestigation 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DoctorInvestigation 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Sequence of the DoctorInvestigation 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// InvestigationProfile of the DoctorInvestigation 
        /// </summary>
        public bool? InvestigationProfile { get; set; }
        /// <summary>
        /// Favourite of the DoctorInvestigation 
        /// </summary>
        public bool? Favourite { get; set; }
        /// <summary>
        /// IsDeleted of the DoctorInvestigation 
        /// </summary>
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// Foreign key referencing the Investigation to which the DoctorInvestigation belongs 
        /// </summary>
        public Guid? InvestigationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Investigation
        /// </summary>
        [ForeignKey("InvestigationId")]
        public Investigation? InvestigationId_Investigation { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the DoctorInvestigation belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
    }
}