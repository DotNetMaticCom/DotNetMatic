﻿using Application.Services.Repositories;
using Domain.Entities;
using DotNetMatic.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class EmailAuthenticatorRepository
    : EfRepositoryBase<EmailAuthenticator, Guid, BaseDbContext>,
        IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context)
        : base(context) { }
}
