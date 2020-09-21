using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody myRigidBody;
    public int lifeSpan = 3;
    public int bulletDamage = 1;
    public int bulletSpeed = 1;
    private float timeLeftToLive;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        timeLeftToLive = lifeSpan;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position += transform.forward * Time.deltaTime * bulletSpeed;
        myRigidBody.MovePosition(position);
    }


    private void OnTriggerEnter(Collider other)
    {
        Damageable damageableObject = other.GetComponent<Damageable>();
        if (damageableObject != null)
        {
            damageableObject.TakeDamage(1);
        }
    }
}
