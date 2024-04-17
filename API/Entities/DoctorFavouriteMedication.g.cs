using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a doctorfavouritemedication entity with essential details
    /// </summary>
    public class DoctorFavouriteMedication
    {
        /// <summary>
        /// TenantId of the DoctorFavouriteMedication 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DoctorFavouriteMedication 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the DoctorFavouriteMedication belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the DoctorFavouriteMedication belongs 
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("DoctorId")]
        public Doctor? DoctorId_Doctor { get; set; }
    }
}