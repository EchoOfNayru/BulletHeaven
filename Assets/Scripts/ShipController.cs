using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public GameObject bullet;
    public float timeBetweenBullets;
    public int shootLevel;
    public float levelTwoSpread;
    public float levelThreeRotation;

    bool isShooting;
    float shootTimer;

    void Start()
    {
        shootTimer = 0;
        shootLevel = 1;
    }

    void FixedUpdate()
    {
        isShooting = false;
        shootTimer += Time.deltaTime; 

        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        if (Input.GetMouseButton(0))
        {
            isShooting = true;
        }
        //level 1
        if (isShooting && shootTimer >= timeBetweenBullets && shootLevel == 1)
        {
            Vector3 shootDir = transform.right;
            GameObject tempBullet = Instantiate(bullet);
            tempBullet.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBullet.GetComponent<BulletController>().dir = shootDir;
        }
        //level2
        if (isShooting && shootTimer >= timeBetweenBullets && shootLevel == 2)
        {
            Vector3 shootDir = transform.right;
            GameObject tempBullet1 = Instantiate(bullet);
            tempBullet1.transform.position = transform.position + new Vector3(-levelTwoSpread, 0, 0.1f);
            tempBullet1.GetComponent<BulletController>().dir = shootDir;
            GameObject tempBullet2 = Instantiate(bullet);
            tempBullet2.transform.position = transform.position + new Vector3(levelTwoSpread, 0, 0.1f);
            tempBullet2.GetComponent<BulletController>().dir = shootDir;
        }
        //level3
        if (isShooting && shootTimer >= timeBetweenBullets && shootLevel == 3)
        {
            Vector3 shootDir = transform.right;
            GameObject tempBullet1 = Instantiate(bullet);
            tempBullet1.transform.position = transform.position + new Vector3(-levelTwoSpread, 0, 0.1f);
            tempBullet1.GetComponent<BulletController>().dir = shootDir;
            GameObject tempBullet2 = Instantiate(bullet);
            tempBullet2.transform.position = transform.position + new Vector3(levelTwoSpread, 0, 0.1f);
            tempBullet2.GetComponent<BulletController>().dir = shootDir;
            GameObject tempBullet3 = Instantiate(bullet);
            tempBullet3.transform.position = transform.position + new Vector3(-levelTwoSpread, 0, 0.1f);
            tempBullet3.transform.rotation *= Quaternion.AngleAxis(levelThreeRotation, Vector3.forward);
            shootDir = Quaternion.AngleAxis(levelThreeRotation, Vector3.forward) * shootDir;
            tempBullet3.GetComponent<BulletController>().dir = shootDir;
            GameObject tempBullet4 = Instantiate(bullet);
            tempBullet4.transform.position = transform.position + new Vector3(levelTwoSpread, 0, 0.1f);
            tempBullet4.transform.rotation *= Quaternion.AngleAxis(-levelThreeRotation, Vector3.forward);
            shootDir = Quaternion.AngleAxis(-levelThreeRotation * 2, Vector3.forward) * shootDir;
            tempBullet4.GetComponent<BulletController>().dir = shootDir;
        }
    }
}
