﻿using System;

namespace Autofac.Benchmarks.Decorators.Scenario
{
    public class CommandHandlerDecoratorTwo : ICommandHandler
    {
        private readonly ICommandHandler _decorated;
        public CommandHandlerDecoratorTwo(ICommandHandler decorated)
        {
            _decorated = decorated;
        }
    }
}
