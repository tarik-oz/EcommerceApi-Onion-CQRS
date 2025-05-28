using EcommerceApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApi.Application.Features.Auth.Exceptions
{
    public class RefreshTokenMustBeValidException : BaseException
    {
        public RefreshTokenMustBeValidException() : base("Gecersiz refresh token.") { }
    }
}
