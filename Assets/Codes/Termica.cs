using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Termica : MonoBehaviour
{
    Rigidbody rdb;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.GetComponentInParent<Rigidbody>() != null)
        {

            rdb = other.GetComponentInParent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {

        if (rdb)
        {
            rdb.AddForce(Vector3.up * 1000);
        }


    }

    private void OnTriggerExit(Collider other)
    {
        rdb = null;

    }


}

