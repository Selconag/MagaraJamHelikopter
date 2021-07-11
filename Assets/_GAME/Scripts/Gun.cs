using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected Camera FpsCamera;
    private GameObject m_Bullet;
    private Rigidbody m_BulletRigid;
    [SerializeField] Vector3 m_ExplosionVector;
    [SerializeField] Vector3 m_BulletSpawnPosition;
    [SerializeField] ForceMode m_BulletForceMode;
    [SerializeField] float m_BulletForceAmount = 1000f;
    [SerializeField] protected Vector3 m_ThrowVector;
    [SerializeField] protected float m_WeaponRange = 300;



    // Start is called before the first frame update
    void Start()
    {
        //Not used for now
        //m_Bullet = Resources.Load<GameObject>("Ball");
        //m_BulletRigid = m_Bullet.GetComponent<Rigidbody>();
        FpsCamera = this.gameObject.transform.GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(FpsCamera.transform.position, FpsCamera.transform.forward, out hit, m_WeaponRange))
            {
                //GameObject Bullet = Instantiate(m_Bullet, m_BulletSpawnPosition, this.gameObject.transform.rotation);
                //Rigidbody m_BulletRigid= Bullet.GetComponent<Rigidbody>();
                if (hit.distance <= m_WeaponRange)
                {
                    Enemy m_Enemy = hit.transform.gameObject.GetComponent<Enemy>();
                    if (m_Enemy != null)
                    {
                        //Make it look like a death on enemy
                        m_Enemy.Take_Damage();
                    }
                }
                else
                {
                    //Do nothing
                }

            }
            
            



        }
    }
}
//Can be used for later parts
//m_Bullet.GetComponent<Rigidbody>().AddForce(Bullet.transform.forward * m_BulletForceAmount);
//Bullet.GetComponent<Rigidbody>().AddExplosionForce(m_BulletForceAmount, Vector3.forward, 1, 1f, m_BulletForceMode);
//Bullet.GetComponent<Rigidbody>().AddExplosionForce(m_BulletForceAmount, Vector3.down, 100, 0, m_BulletForceMode);
//Bullet.GetComponent<Rigidbody>().AddForce(m_ExplosionVector, m_BulletForceMode);
//Destroy(Bullet, 3f);