public class AutoController : BaseController<ExecutableBehaviour>
{
    private void Update()
    {
        if (executable.IsExecuting || !executable)
            return;
        RequestExecution();
    }
}