using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a location entity with essential details
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Primary key for the Location 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Location 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Code of the Location 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the Location 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// CountryCode of the Location 
        /// </summary>
        public int? CountryCode { get; set; }
        /// <summary>
        /// MobileNumber of the Location 
        /// </summary>
        public string? MobileNumber { get; set; }
        /// <summary>
        /// EmailAddress of the Location 
        /// </summary>
        public string? EmailAddress { get; set; }
        /// <summary>
        /// AddressLine1 of the Location 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Location 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the Location 
        /// </summary>
        public string? StateId { get; set; }
        /// <summary>
        /// CityId of the Location 
        /// </summary>
        public string? CityId { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Location belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
        /// <summary>
        /// PostalCode of the Location 
        /// </summary>
        public string? PostalCode { get; set; }
    }
}