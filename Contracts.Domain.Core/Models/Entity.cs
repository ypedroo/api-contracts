﻿using System;

namespace Contracts.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
