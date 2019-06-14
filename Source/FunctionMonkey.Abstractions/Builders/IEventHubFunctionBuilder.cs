﻿using AzureFromTheTrenches.Commanding.Abstractions;

namespace FunctionMonkey.Abstractions.Builders
{
    /// <summary>
    /// Provides an interface that allows commands to be mapped to event hubs
    /// </summary>
    public interface IEventHubFunctionBuilder<TCommandOuter> : IFunctionOptions<TCommandOuter, IEventHubFunctionBuilder<TCommandOuter>, IFunctionOptionsBuilder> where TCommandOuter : ICommand
    {
        /// <summary>
        /// Associate an event hub with a given command type
        /// </summary>
        /// <typeparam name="TCommand">The type of the command</typeparam>
        /// <param name="eventHubName">The name of the event hub</param>
        IEventHubFunctionBuilder<TCommand> EventHubFunction<TCommand>(string eventHubName) where TCommand : ICommand;
    }
}
