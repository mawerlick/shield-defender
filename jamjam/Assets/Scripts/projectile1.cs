using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile1 : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public int damage;
    public bool isShieldTouch= false;
    void Start()
    {
        Destroy(gameObject, lifeTime);
           
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        
  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Enemy")
        {
            if (isShieldTouch)
            {
                other.GetComponent<enemyGen>().TakeDamage(damage);
                Destroy(gameObject);
            }
            
        }
        else if (other.tag == "Shield")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            isShieldTouch = true;
            speed = -speed;
        }

        else if (other.tag == "Player")
        {
            other.GetComponent<player>().TakeDamage(damage);
            Destroy(gameObject);
            // move to game over screen and print point
        }

    }
}
