namespace Atc.Cosmos.EventStore.Cqrs.Testing;

public interface ICommandGiven<in TCommand>
    where TCommand : ICommand
{
    ICommandWhen<TCommand> GivenEvents(
        Func<Task<object[]>> eventsFactory);
}