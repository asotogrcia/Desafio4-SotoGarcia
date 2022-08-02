using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBala : MonoBehaviour
{
    public float speedBullet = 3f;
    public Vector3 directionBala = new Vector3(0.0f,0.0f,0.0f);
    public float damageBullet = 0.0f;
    public float bulletLifeTime = 4f;
    private float bulletLifeTimeLeft;
    private bool scaleMultiplier = true;

    void Start()
    {
        ResetBulletTimer();
    }

    // Update is called once per frame
    void Update()
    {
        BulletProyection();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ScaleMultiplier();
        }
        BulletTimer();
    }


    void ResetBulletTimer()
    {
        bulletLifeTimeLeft = bulletLifeTime;
    }

    void BulletTimer()
    {
        bulletLifeTimeLeft -= Time.deltaTime;

        if (bulletLifeTimeLeft <= 0)
        {
            Destroy(gameObject);
            ResetBulletTimer();
        }
    }

    void ScaleMultiplier()
    {
        if (scaleMultiplier)
        {
            scaleMultiplier = false;
            transform.localScale *= 2;
            Invoke("ScaleCooldown",0.8f);
        }
    }

    void ScaleCooldown()
    {
        scaleMultiplier = true;
    }

    void BulletProyection()
    {
        transform.Translate(directionBala * speedBullet * Time.deltaTime);
    }

}
