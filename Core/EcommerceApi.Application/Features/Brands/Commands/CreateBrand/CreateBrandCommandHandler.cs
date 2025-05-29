using Bogus;
using EcommerceApi.Application.Bases;
using EcommerceApi.Application.Interfaces.AutoMapper;
using EcommerceApi.Application.Interfaces.UnitOfWorks;
using EcommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApi.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandHandler : BaseHandler, IRequestHandler<CreateBrandCommandRequest, Unit>
    {
        public CreateBrandCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            // Redis test data insertion
            //Faker faker = new("tr");
            //List<Brand> brands = new();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    brands.Add(new(faker.Commerce.Department(1)));
            //}

            //await unitOfWork.GetWriteRepository<Brand>().AddRangeAsync(brands);
            //await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
