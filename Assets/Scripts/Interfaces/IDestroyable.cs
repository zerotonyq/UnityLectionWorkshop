using UnityEngine.Events;

public interface IDestroyable
{
    public UnityAction<bool> DestroyAction { get; set; }
    public void Destroy();
}
