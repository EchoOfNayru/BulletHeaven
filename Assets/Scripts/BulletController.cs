using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;
    public float timeToStale;

    float staleTimer;
    public Vector3 dir;
    void Start()
    {
        staleTimer = 0;
        dir *= speed;
    }

    void FixedUpdate()
    {
        staleTimer += Time.deltaTime;
        if (staleTimer > timeToStale)
        {
            Destroy(gameObject);
        }

        
        transform.position += dir;
        //transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
    }
}
