﻿using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class AddressDAO : EFRepositoryBase<Address, EFaturaDbContext>, IAddressDAO
    {
        public AddressDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
