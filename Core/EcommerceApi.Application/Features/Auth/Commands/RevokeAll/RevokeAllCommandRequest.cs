﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApi.Application.Features.Auth.Commands.RevokeAll
{
    public class RevokeAllCommandRequest : IRequest<Unit>
    {
    }
}
