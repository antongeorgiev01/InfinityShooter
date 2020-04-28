using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{

    public GameObject EnemyBulletGO;
	// Use this for initialization
	void Start ()
    {
        Invoke("FireEnemyBullet", 1f);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FireEnemyBullet()
    {
        GameObject playersShip = GameObject.Find("PlayerGO");

        if (playersShip!=null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);

            bullet.transform.position = transform.position;

            Vector2 direction = playersShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullet>().SetDirection(direction);

        }
    }
}
