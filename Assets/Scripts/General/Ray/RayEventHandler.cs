using UnityEngine.Events;
using UnityEngine;
namespace General.RaySystem
{
    public class RayEventHandler : MonoBehaviour, IRayReciever
    {
        public UnityEvent UnityEvent;
        public void Recieve()
        {
            UnityEvent.Invoke();
        }
    }
}
