namespace TaskManager.Domain;

public class User : ISubscriber
{
    public User(string firstName)
    {
        FirstName = firstName;
    }

    public string FirstName { get; set; }

    public void Update(string taskName, string newState)
    {
        Console.WriteLine($"{FirstName} zadanie o nazwie {taskName} zmieni³o status na: {newState}");
    }
}