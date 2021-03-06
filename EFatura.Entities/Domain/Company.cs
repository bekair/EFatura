﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;
using EFatura.Entities.OtherEntities;

namespace EFatura.Entities.Domain
{
    [Table("COMPANIES")]
    public class Company : Customer
    {
        [Column("COMPANY_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("COMPANY_NAME")]
        [Required]
        [StringLength(150)]
        public string CompanyName { get; set; }

        [Column("TRADE_REGISTER_NO")]
        [Required]
        [StringLength(20)] //???? INDEFINITE LENGTH ????
        public string TradeRegisterNo { get; set; } //TradeRegisterNo => Ticari Sicil Numarası

        [Column("MERNIS_NO")]
        [Required]
        [StringLength(20)] //???? INDEFINITE LENGTH ????
        public string MernisNo { get; set; }

        [Column("TAX_OFFICE")]
        [Required]
        [StringLength(100)]
        public string TaxOffice { get; set; } //TaxOffice => Vergi Dairesi

        [Column("PHONE_NUMBER")]
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column("FAX_NUMBER")]
        [Required]
        [StringLength(20)]
        public string FaxNumber { get; set; }

        [Column("WEB_SITE")]
        [MaxLength(100)]
        public string WebSite { get; set; }

        //Navigation Property
        public IEnumerable<Individual> Employees { get; set; }

        //Always will be 'Company'
        [Column("CUSTOMER_TYPE")]
        [Required]
        public override CustomerType CustomerType
        {
            get => base.CustomerType;
            set => base.CustomerType = CustomerType.Company;
        }

    }
}
