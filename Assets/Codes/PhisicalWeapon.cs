using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhisicalWeapon : MonoBehaviour
{

    public AudioSource weaponsnd;
    public AudioClip[] clips;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SendMessage("Damage", SendMessageOptions.DontRequireReceiver);
        weaponsnd.PlayOneShot(clips[Random.Range(0, clips.Length)]);
    }

    
}
