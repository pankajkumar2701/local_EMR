using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a appointmentservice entity with essential details
    /// </summary>
    public class AppointmentService
    {
        /// <summary>
        /// Primary key for the AppointmentService 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the AppointmentService 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Foreign key referencing the Appointment to which the AppointmentService belongs 
        /// </summary>
        public Guid? AppointmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Appointment
        /// </summary>
        [ForeignKey("AppointmentId")]
        public Appointment? AppointmentId_Appointment { get; set; }

        /// <summary>
        /// Required field ServiceName of the AppointmentService 
        /// </summary>
        [Required]
        public string ServiceName { get; set; }
        /// <summary>
        /// Price of the AppointmentService 
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the AppointmentService belongs 
        /// </summary>
        public Guid? Service { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("Service")]
        public Product? Service_Product { get; set; }
    }
}