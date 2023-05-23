using TaskManager.Domain.States;

namespace TaskManager.Domain;

public class Task
{
    private readonly List<ISubscriber> _subscribers = new();
    private TaskState _state;

    public Task(string id, string name)
    {
        Id = id;
        Name = name;
        _state = new InBacklogState(this);
    }

    public string Id { get; }
    public string Name { get; }

    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void SetInProgress()
    {
        _state.SetInProgress();
    }

    public void SetToDo()
    {
        _state.SetToDo();
    }

    public void UnSubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    internal void ChangeState(TaskState state)
    {
        _state = state;
        NotifySubscribers();
    }

    private void NotifySubscribers()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(Name, _state.Name);
        }
    }
}
