using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected int Health = 20;
    

    public void Take_Damage()
    {
        if(Health > 0)
        {
            Health = Health - 10;
        }
        else
        {
            //Die
            Destroy(this);
            Debug.Log("YOU DIED!");
        }
        
    }

   
}
