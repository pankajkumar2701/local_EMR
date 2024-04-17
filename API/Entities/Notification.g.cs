using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a notification entity with essential details
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// TenantId of the Notification 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Notification 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the Notification 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Appointment to which the Notification belongs 
        /// </summary>
        public Guid? AppointmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Appointment
        /// </summary>
        [ForeignKey("AppointmentId")]
        public Appointment? AppointmentId_Appointment { get; set; }

        /// <summary>
        /// DueDate of the Notification 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Dismiss of the Notification 
        /// </summary>
        public bool? Dismiss { get; set; }
    }
}