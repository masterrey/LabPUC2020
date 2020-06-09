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
                StartCoroutine(MyLoadScene("MainScene"));

            }
            else
            {
                CommomStatus.lastPosition = other.transform.position-Vector3.forward*2;
                StartCoroutine(MyLoadScene(srinetoload));
            }
            
        }
       
    }

    IEnumerator MyLoadScene(string load)
    {
        Camera.main.SendMessage("CallFadeOut");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(load);
    }
}
