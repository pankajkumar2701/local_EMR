using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a paymentmode entity with essential details
    /// </summary>
    public class PaymentMode
    {
        /// <summary>
        /// TenantId of the PaymentMode 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PaymentMode 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the PaymentMode 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Default of the PaymentMode 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// OnlineDefault of the PaymentMode 
        /// </summary>
        public bool? OnlineDefault { get; set; }
    }
}