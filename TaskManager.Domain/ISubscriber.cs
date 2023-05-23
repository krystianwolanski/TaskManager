namespace TaskManager.Domain;

public interface ISubscriber
{
    void Update(string taskName, string newState);
}