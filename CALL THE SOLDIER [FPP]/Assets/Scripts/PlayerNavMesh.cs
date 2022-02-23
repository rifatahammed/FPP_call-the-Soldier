using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{   
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;

    //=================
    public Camera cam;
    //=================
    private void Awake() {
       navMeshAgent = GetComponent<NavMeshAgent>();
   }

   private void Update() {
        //=================
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
    //=================
    // navMeshAgent.destination = movePositionTransform.position;
    //================
}
//}
