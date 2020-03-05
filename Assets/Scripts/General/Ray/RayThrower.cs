using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace General.RaySystem
{
    public class RayThrower : MonoBehaviour
    {
        private Camera gameCamera;
        private void Awake()
        {
            gameCamera = GetComponent<Camera>();
        }
        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Throw();
            }
        }
        public void Throw()
        {
            RaycastHit hit;
            Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                var receiver = objectHit.GetComponent<IRayReciever>();
                receiver?.Recieve();
            }
        }
    }
}