using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        Health health = collider.GetComponent<Health>();
        if (health != null)
        {
            GetComponent<MeshRenderer>().enabled = false;
            health.Damage(-50);
            Debug.Log("Boom");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
