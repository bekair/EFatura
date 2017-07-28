﻿using EFatura.Core.EntityBase;
using EFatura.Entities.OtherEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.Entities.Domain
{
    [Table("CORPORATE_BILLS")]
    public class CorporateBill : Bill
    {
        [Column("CORPORATE_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }


    }
}
