using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGeneradorBalas : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timeToShoot;
    private float timeToShootLeft;

    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        TemporizadorDisparo();
    }

    void ShootBullet()
    {
        Instantiate(bulletPrefab,transform.position,transform.rotation);
    }

    void ResetTimer()
    {
        timeToShootLeft = timeToShoot;
    }

    void TemporizadorDisparo()
    {
        timeToShootLeft -= Time.deltaTime;

        if (timeToShootLeft <= 0)
        {
            ShootBullet();
            ResetTimer();
        }
    }
}
