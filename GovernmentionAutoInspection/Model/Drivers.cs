namespace GovernmentionAutoInspection.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(256)]
        public string LastName { get; set; }

        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(256)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(4)]
        public string PassportSerial { get; set; }

        [Required]
        [StringLength(6)]
        public string PassportNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Address { get; set; }

        [Required]
        [StringLength(256)]
        public string AddressLife { get; set; }

        [StringLength(256)]
        public string Company { get; set; }

        [StringLength(256)]
        public string JobName { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(1024)]
        public string Photo { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }
    }
}
