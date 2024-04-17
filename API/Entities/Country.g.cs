using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a country entity with essential details
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Primary key for the Country 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the Country 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the Country 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Currency to which the Country belongs 
        /// </summary>
        public Guid? CurrencyId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Currency
        /// </summary>
        [ForeignKey("CurrencyId")]
        public Currency? CurrencyId_Currency { get; set; }
        /// <summary>
        /// Foreign key referencing the Language to which the Country belongs 
        /// </summary>
        public Guid? LanguageId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Language
        /// </summary>
        [ForeignKey("LanguageId")]
        public Language? LanguageId_Language { get; set; }
        /// <summary>
        /// Timezone of the Country 
        /// </summary>
        public string? Timezone { get; set; }
        /// <summary>
        /// IsoCode of the Country 
        /// </summary>
        public string? IsoCode { get; set; }
        /// <summary>
        /// Nationality of the Country 
        /// </summary>
        public string? Nationality { get; set; }
    }
}