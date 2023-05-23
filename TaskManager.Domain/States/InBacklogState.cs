namespace TaskManager.Domain.States;

internal class InBacklogState : TaskState
{
    public InBacklogState(Task task) : base(task)
    {
    }

    public override string Name { get; } = "Backlog";

    public override void SetInProgress()
    {
        throw new Exception();
    }

    public override void SetToDo()
    {
        throw new Exception();
    }
}