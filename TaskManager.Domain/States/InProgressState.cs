namespace TaskManager.Domain.States;

internal class InProgressState : TaskState
{
    public InProgressState(Task task) : base(task)
    {
    }

    public override string Name { get; } = "InProgress";

    public override void SetInProgress()
    {
        throw new Exception();
    }

    public override void SetToDo()
    {
        _task.ChangeState(new ToDoState(_task));
    }
}