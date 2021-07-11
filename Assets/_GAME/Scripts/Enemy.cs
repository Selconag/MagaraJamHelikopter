using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int Health = 20;
    private Vector3 m_TargetPosition;
    private Transform m_TargetTransform;
    private Player m_Player;
    [SerializeField] protected float m_EnemySpeed = 1f;

    private void Update()
    {
        //If Player is seen
        if(m_Player != null)
        {
            //Get Player Location and Transform
            m_TargetTransform = m_Player.gameObject.transform;
            m_TargetPosition = m_TargetTransform.position;
            //Go to player
            transform.Translate(m_TargetPosition * Time.deltaTime * m_EnemySpeed);
            //Calculate Angle with trygonometry
            //float m_X, m_Z, m_Y;
            //m_X = this.gameObject.transform.position.x - m_TargetPosition.x;
            //m_Z = this.gameObject.transform.position.z - m_TargetPosition.z;
            //m_Y = Mathf.Atan(m_Z / m_X);
            
            //Quaternion m_NewRotation = new Quaternion(this.gameObject.transform.transform.rotation.x, m_Y, this.gameObject.transform.transform.rotation.z,0);
            //this.gameObject.transform.rotation = m_NewRotation;
            transform.LookAt(m_TargetTransform);
        }
        else
        {
            m_TargetTransform = null;
            m_TargetPosition = this.gameObject.transform.position;
        }
        //


    }
    private void Do_Death()
    {
        Debug.Log("YOU ARE DEAD!");
        Destroy(this.gameObject);
    }
    public void Take_Damage()
    {
        if(Health > 0)
        {
            Health = Health - 10;

        }
        else
        {
            Do_Death();
        }

    }
    
    private void Search_Enemy()
    {

    }
    private void Shoot_Enemy()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Player = other.gameObject.GetComponent<Player>();

        }
    }


}
