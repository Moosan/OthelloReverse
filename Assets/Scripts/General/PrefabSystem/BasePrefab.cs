using UnityEngine;
namespace General.PrefabSystem
{
    public abstract class BasePrefab<TParam> : MonoBehaviour where TParam : BasePrefabParam
    {
        private bool Initialized { get; set; } = false;
        protected TParam MyParam;
        public void Initialize(TParam param)
        {
            MyParam = param;
            Initialized = true;
        }
        protected virtual void Start()
        {
            if (!Initialized)
            {
                Debug.LogError("PrefabがInitializeされていません");
                return;
            }
        }
    }


    public abstract class BasePrefabParam
    {

    }
}