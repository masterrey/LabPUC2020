using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DamageControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage()
    {
        Destroy(gameObject,3);
        GetComponent<IAWalk>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        
    }
}
