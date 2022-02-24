using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWhenCollide : MonoBehaviour
{

    [SerializeField] private LayerMask PickupMask;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.gameObject.layer == LayerMask.NameToLayer("Pickup"))
        {
            Debug.Log("Touched a Box");
           
               
            
            transform.parent = col.transform;
        }
    }
}
