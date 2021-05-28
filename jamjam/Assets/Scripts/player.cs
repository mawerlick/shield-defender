using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Post Update healt bar gösteren UI koymayı unuttum.-- Point gösteren ile aynı mantıkta çalışıyor ztn

    public gameoverscreen gmscreen;
    public int health;
    public int point;
    public AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(this.gameObject);
            gmscreen.Setup(point);
            if (aud.isPlaying)
            {
                aud.Stop();
            }
        }

    }



}
