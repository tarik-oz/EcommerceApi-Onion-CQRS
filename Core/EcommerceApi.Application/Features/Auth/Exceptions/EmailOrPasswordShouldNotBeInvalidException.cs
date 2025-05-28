using EcommerceApi.Application.Bases;

namespace EcommerceApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Kullanici adi veya sifre hatali.") { }
    }
}
