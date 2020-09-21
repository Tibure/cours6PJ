using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiControl : MonoBehaviour, Damageable
{
    private GameObject player;
    private Rigidbody myRigidBody;
    public void TakeDamage(int Damage)
    {
        Die();
    }

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 100 * Time.deltaTime));
        
    }



    private void Die()
    {
        Destroy(gameObject);
    }
}
