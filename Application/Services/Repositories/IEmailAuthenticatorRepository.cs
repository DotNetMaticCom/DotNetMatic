using Domain.Entities;
using DotNetMatic.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IEmailAuthenticatorRepository
    : IAsyncRepository<EmailAuthenticator, Guid>,
        IRepository<EmailAuthenticator, Guid> { }
