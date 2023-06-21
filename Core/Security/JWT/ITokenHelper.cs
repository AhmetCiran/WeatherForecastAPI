using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concret;

namespace Core.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> OperationClaim);
    }
}
