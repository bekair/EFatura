﻿using EFatura.Entities.OtherEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.Domain
{
    [Table("INDIVIDUALS")]
    public class Individual : Customer
    {
        //TCKNAttribute YAZ!!
        [Column("INDIVIDUAL_ID_NUMBER")]
        [MaxLength(11)]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("NAME")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("SURNAME")]
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Column("GENDER")]
        [Required]
        public Gender Gender { get; set; }

        [Column("DATE_OF_BIRTH")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column("MOBILE_PHONE")]
        [Required]
        [MaxLength(20)]
        public string MobilePhone { get; set; }

        [Column("JOB_PHONE")]
        [MaxLength(20)]
        public string JobPhone { get; set; }

        [Column("EMAIL")]
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("WEB_SITE")]
        [MaxLength(100)]
        public string WebSite { get; set; }

        [Column("IS_WORKING")]
        [Required]
        public WorkingStatus IsWorking { get; set; }

        [Column("COMPANY_ID_FOREIGN")]
        public long? CompanyID { get; set; } //NOT REQUIRED 'Foreign Key'

        //Navigation Property
        public Company Company { get; set; }

        //Always will be 'Individual'
        [Column("CUSTOMER_TYPE")]
        [Required]
        public override CustomerType CustomerType
        {
            get => base.CustomerType;
            set => base.CustomerType = CustomerType.Individual;
        }

    }
}
