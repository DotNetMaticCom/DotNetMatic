namespace Domain.Entities;

public class EmailAuthenticator : DotNetMatic.Core.Security.Entities.EmailAuthenticator<Guid>
{
    public virtual User User { get; set; } = default!;
}
