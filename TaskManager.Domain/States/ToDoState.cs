namespace TaskManager.Domain.States;

internal class ToDoState : TaskState
{
    public ToDoState(Task task) : base(task)
    {
    }

    public override string Name { get; } = "ToDo";

    public override void SetInProgress()
    {
        throw new Exception();
    }

    public override void SetToDo()
    {
        throw new Exception();
    }
}