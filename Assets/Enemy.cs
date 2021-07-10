using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Do_Death()
    {
        Debug.Log("YOU ARE DEAD!");
        Destroy(this.gameObject);
    }
    
    private void Search_Enemy()
    {

    }
    private void Shoot_Enemy()
    {

    }
}
