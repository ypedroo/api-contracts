using System;
using Contracts.Domain.Core.Commands;
using Contracts.Domain.Models;
using Flunt.Validations;

namespace Contracts.Domain.Commands
{
    public class CreatePartCommand : CommandBase
    {
        public Guid Id { get; set; }
        public PartInformation Part { get; set; }

        public override void Validate() => AddNotifications(new Contract()
            .IsNotEmpty(Id, nameof(Id), $"{nameof(Id)} can't be empty")
            .IsNotNullOrEmpty(Part.Cpf, nameof(Part.Cpf), $"{nameof(Part.Cpf)} can't be empty")
            .HasMaxLen(Part.FistName, 40, "First Name", "First Name cant be that long")
            .HasMaxLen(Part.LastName, 3, "Last Name", "Last Name cant be that long")
            );
    }
}
