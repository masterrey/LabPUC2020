using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Srine : MonoBehaviour
{
   
    public bool backtoworld = false;
    public string srinetoload;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            if (backtoworld)
            {
                SceneManager.LoadScene("MainScene");

            }
            else
            {
                CommomStatus.lastPosition = other.transform.position-Vector3.forward*2;
                SceneManager.LoadScene(srinetoload);
            }
            
        }
       
    }
}
