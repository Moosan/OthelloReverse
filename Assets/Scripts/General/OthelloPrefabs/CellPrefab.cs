using UnityEngine;
using OthelloModel;
namespace General.OthelloPrefabs
{
    public class CellPrefab : MonoBehaviour
    {
        private CellPresenter CellPresenter;
        [SerializeField]
        private GameObject PiecePrefabGameObject;

        private PiecePrefab piecePrefab;
        private void Awake()
        {
            piecePrefab = 
                Instantiate(
                PiecePrefabGameObject,
                transform.position + Vector3.up * 0.2f,
                Quaternion.identity)
                .GetComponent<PiecePrefab>();
            piecePrefab.SetParent(transform);
        }
        public void Put()
        {
            piecePrefab.Activate();
        }
    }
}