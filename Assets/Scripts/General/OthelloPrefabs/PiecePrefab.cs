using UnityEngine;
namespace General.OthelloPrefabs
{
    public class PiecePrefab : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.SetActive(false);
        }
        public void Revercce()
        {
            transform.Rotate(Vector3.forward * 180);
        }
        public void Activate()
        {
            if (gameObject.activeSelf) return;
            gameObject.SetActive(true);
        }
        public void SetParent(Transform parent)
        {
            transform.parent = parent;
        }
    }
}