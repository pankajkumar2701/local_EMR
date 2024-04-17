using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a address entity with essential details
    /// </summary>
    public class Address
    {
        /// <summary>
        /// TenantId of the Address 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Address 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Address 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// AddressLine1 of the Address 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Address 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Address belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
        /// <summary>
        /// State of the Address 
        /// </summary>
        public string? State { get; set; }
        /// <summary>
        /// City of the Address 
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// PostalCode of the Address 
        /// </summary>
        public string? PostalCode { get; set; }
    }
}