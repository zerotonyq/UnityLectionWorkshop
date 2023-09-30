
public interface IExecutable
{
    void Execute();
    void StopExecution();
    bool IsExecuting { get; set; }
}


