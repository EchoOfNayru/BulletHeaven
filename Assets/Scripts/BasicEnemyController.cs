using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyController : MonoBehaviour {

    public float speed;
    public float timeBetweenShots = 0.25f;
    public GameObject bullet;

    BulletController bulletCheck;
    float shootTimer;

	// Use this for initialization
	void Start () {
        shootTimer = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position += new Vector3(0, -speed, 0);

        shootTimer += Time.deltaTime;
        if (shootTimer >= timeBetweenShots)
        {
            Vector3 shootDir = transform.up;
            
            GameObject tempBulletUP = Instantiate(bullet);
            tempBulletUP.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletUP.transform.rotation *= Quaternion.AngleAxis(0, Vector3.forward);
            shootDir = Quaternion.AngleAxis(0, Vector3.forward) * shootDir;
            tempBulletUP.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletUPLeft = Instantiate(bullet);
            tempBulletUPLeft.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletUPLeft.transform.rotation *= Quaternion.AngleAxis(45, Vector3.forward);
            shootDir = Quaternion.AngleAxis(45, Vector3.forward) * shootDir;
            tempBulletUPLeft.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletLeft = Instantiate(bullet);
            tempBulletLeft.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletLeft.transform.rotation *= Quaternion.AngleAxis(90, Vector3.forward);
            shootDir = Quaternion.AngleAxis(90, Vector3.forward) * shootDir;
            tempBulletLeft.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletDownLeft = Instantiate(bullet);
            tempBulletDownLeft.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletDownLeft.transform.rotation *= Quaternion.AngleAxis(135, Vector3.forward);
            shootDir = Quaternion.AngleAxis(135, Vector3.forward) * shootDir;
            tempBulletDownLeft.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletDown = Instantiate(bullet);
            tempBulletDown.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletDown.transform.rotation *= Quaternion.AngleAxis(180, Vector3.forward);
            shootDir = Quaternion.AngleAxis(180, Vector3.forward) * shootDir;
            tempBulletDown.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletDownRight = Instantiate(bullet);
            tempBulletDownRight.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletDownRight.transform.rotation *= Quaternion.AngleAxis(225, Vector3.forward);
            shootDir = Quaternion.AngleAxis(225, Vector3.forward) * shootDir;
            tempBulletDownRight.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletRight = Instantiate(bullet);
            tempBulletRight.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletRight.transform.rotation *= Quaternion.AngleAxis(270, Vector3.forward);
            shootDir = Quaternion.AngleAxis(270, Vector3.forward) * shootDir;
            tempBulletRight.GetComponent<EnemyBulletController>().dir = shootDir;

            GameObject tempBulletUPRight = Instantiate(bullet);
            tempBulletUPRight.transform.position = transform.position + new Vector3(0, 0, 0.1f);
            tempBulletUPRight.transform.rotation *= Quaternion.AngleAxis(315, Vector3.forward);
            shootDir = Quaternion.AngleAxis(315, Vector3.forward) * shootDir;
            tempBulletUPRight.GetComponent<EnemyBulletController>().dir = shootDir;

            shootTimer = 0;

            //GameObject tempBullet3 = Instantiate(bullet);
            //tempBullet3.transform.position = transform.position + new Vector3(-levelTwoSpread, 0, 0.1f);
            //tempBullet3.transform.rotation *= Quaternion.AngleAxis(levelThreeRotation, Vector3.forward);
            //shootDir = Quaternion.AngleAxis(levelThreeRotation, Vector3.forward) * shootDir;
            //tempBullet3.GetComponent<BulletController>().dir = shootDir;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        bulletCheck = other.GetComponent<BulletController>();
        if (bulletCheck != null)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
