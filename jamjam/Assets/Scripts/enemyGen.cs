using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGen : MonoBehaviour
{
    public player myPlayer;

    private Transform targetPos;
    public GameManager gm;

    public GameObject projectile;
    public float timeBetweenShots;

    private float shotTime;
    public int num;
    public int health;

    void Start()
    {
        targetPos = GameObject.FindWithTag("Player").transform;
        myPlayer= GameObject.FindWithTag("Player").GetComponent<player>();
        gm= GameObject.FindWithTag("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = targetPos.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 180, Vector3.forward);
        transform.rotation = rotation;



        if (Time.time >= shotTime)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            shotTime = Time.time + timeBetweenShots + Random.Range(0,2);
        }



    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <=0)
        {
            myPlayer.point += 10;
            if (gm != null)
            {
                gm.spawnAvailability[num] = true;
            }
            
            Destroy(this.gameObject);
            
        }
        
    }

}
