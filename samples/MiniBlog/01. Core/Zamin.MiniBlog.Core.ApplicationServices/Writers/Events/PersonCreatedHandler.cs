﻿using Zamin.Core.ApplicationServices.Events;
using Zamin.MiniBlog.Core.Domain.Writers.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zamin.MiniBlog.Core.ApplicationServices.Writers.Events
{
    public class PersonCreatedHandler : IDomainEventHandler<PersonCreated>
    {
        public Task Handle(PersonCreated Event)
        {
            int a = 123;
            return Task.CompletedTask;
        }
    }
}
