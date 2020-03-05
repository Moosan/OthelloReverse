using UnityEngine;
namespace General.PrefabSystem
{
    public abstract class BasePrefabFactory<TPrefab,TParam>:MonoBehaviour
        where TParam : BasePrefabParam
        where TPrefab : BasePrefab<TParam>
    {
        [SerializeField]
        private GameObject prefabGameObject;
        protected virtual void Awake()
        {
            if(prefabGameObject == null)
            {
                Debug.LogError("FactoryError:"+ this.GetType() + "に" + nameof(TPrefab) +"が設定されていません");
            }
        }
        public TPrefab Create(TParam param,Vector3 pos,Quaternion rot,Transform parent = null)
        {
            var prefab = Instantiate(prefabGameObject,pos,rot).GetComponent<TPrefab>();
            if(parent != null)
            {
                prefab.transform.parent = parent;
            }
            if(prefab == null)
            {
                Debug.LogError("FactoryError:PrefabGameObjectに" + nameof(TPrefab) + "がアタッチされていません");
            }
            if(param == null)
            {
                Debug.LogError("FactoryError:" + nameof(TParam) + "がNullです");
            }
            prefab.Initialize(param);
            return prefab;
        }
        public TPrefab Create(TParam param)
        {
            return Create(param,Vector3.zero);
        }
        public TPrefab Create(TParam param,Vector3 pos)
        {
            return Create(param, pos, Quaternion.identity);
        }

    }
}