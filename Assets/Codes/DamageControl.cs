using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DamageControl : MonoBehaviour
{
    public int lifes = 3;
    public IAWalk iawalk;
  
    public void GetDamage()
    {
        iawalk.currentState = IAWalk.IaState.Dying;
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Projectiles"))
        {
            lifes--;
            iawalk.currentState = IAWalk.IaState.Damage;
        }
        if (collision.collider.CompareTag("WeaponDroped"))
        {
            lifes--;
            iawalk.currentState = IAWalk.IaState.Damage;
        }
        if (lifes < 0)
        {
            iawalk.currentState = IAWalk.IaState.Dying;
          
        }
    }

    
}
