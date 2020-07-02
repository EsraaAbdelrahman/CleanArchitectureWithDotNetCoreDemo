using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus :IMediatorHandler
    {

        private readonly IMediator mediator;

        public InMemoryBus(IMediator _mediator)
        {
            mediator = _mediator;
        }

        public Task SendCommand<T> (T command) where T: Command
        {
            return mediator.Send(command);
        }

    }
}
