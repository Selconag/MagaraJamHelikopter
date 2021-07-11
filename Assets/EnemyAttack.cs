using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EnemyAttack : MonoBehaviour
{
    private bool m_HitIsEnable = false;
    [SerializeField] protected float m_HitTimer = 0.7f;
    [SerializeField] protected bool m_HitEnemy = true;
    [SerializeField] protected Player m_Player;
    private void Update()
    {
        if(m_Player != null && m_HitEnemy)
        {
            //Hit enemy
            m_Player.Take_Damage();
            m_HitEnemy = false;
        }
        else if (m_Player != null && !m_HitIsEnable)
        {
            Hit_Player();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Player = other.gameObject.GetComponent<Player>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        m_Player = null;
    }
    private async void Hit_Player()
    {
        if (!m_HitEnemy)
        {
            await Task.Delay(1000);
            m_HitEnemy = true;
            m_HitIsEnable = false;
        }
       
    }
}
