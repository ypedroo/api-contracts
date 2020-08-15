using System;

namespace Contracts.Domain.Models
{
    public sealed class Contract
    {
        public byte[] File { get; set; }
        public DateTime RequestedAt { get; set; }
        public int Part { get; set; }
    }
}