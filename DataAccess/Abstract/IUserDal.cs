﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities.Concret;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
