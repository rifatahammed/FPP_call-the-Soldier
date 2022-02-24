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
        if (col.collider.gameObject.layer == LayerMask.NameToLayer("2ndPlayer"))
        {
            Debug.Log("Touched a Box");
            transform.parent = col.transform;
        }

        if(col.transform.name == "2nd Player")
        {
            //transform.parent = col.transform;
            //Destroy(gameObject);
            Debug.Log("AAAA");
        }

        if (col.transform.name == "Box")
        {
            //transform.parent = col.transform;
            //Destroy(gameObject);
            Debug.Log("BBBB");
        }
    }
}
