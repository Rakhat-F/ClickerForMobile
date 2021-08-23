using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 20;
    public int maxSpeed = 10;
    public int minSpeed = 20;

    private void Start()
    {     
        rb = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(rotateUFO());
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector3(transform.up.x, 0, transform.up.z) * speed * Time.fixedDeltaTime);        
    }

    IEnumerator rotateUFO()
    {
        transform.rotation = Quaternion.Euler(Random.Range(-90, 90), 0, Random.Range(-90, 90));
        speed = Random.Range(minSpeed, maxSpeed);       
        yield return new WaitForSeconds(Random.Range(2, 5));
        StartCoroutine(rotateUFO());
    }
}
