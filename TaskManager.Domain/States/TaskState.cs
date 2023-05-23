namespace TaskManager.Domain.States;

internal abstract class TaskState
{
    protected Task _task;

    protected TaskState(Task task)
    {
        _task = task;
    }

    public abstract string Name { get; }

    public abstract void SetInProgress();

    public abstract void SetToDo();
}