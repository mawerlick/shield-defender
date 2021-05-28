using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject x;
    private GameObject y;
    public player myPlayer;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    public bool[] spawnAvailability;

    private int enemyLimit;
    private float spawnTime;
    public float timeBetweenSpawn;


    public int randSpawn;

    void Start()
    {

        spawnTime = timeBetweenSpawn;
        enemyLimit = 6;

        spawnAvailability = new bool[spawnPoints.Length];

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnAvailability[i] = true;
        }
        // StartCoroutine(vola());
    }

    void Update()
    {
        //int counter = 30;
      
        //gittikçe hızlanma kısmını yapamadım update ile ilgili bir sorun oluyor
        /*
        if (myPlayer.point > counter)
        {          
            if (spawnTime > 3)
            {
                spawnTime--;
            }

            Debug.Log("Başarılı " + spawnTime + " " + enemyLimit);
            counter += 50;
        }*/

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = timeBetweenSpawn;
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }

    }


    // Update is called once per frame
    private void Spawn()
    {

        randSpawn = Random.Range(0, spawnPoints.Length);
        int randEnemy = Random.Range(0, enemyPrefabs.Length);

        if (spawnAvailability[randSpawn])
        {


            x = Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawn].position, transform.rotation);
            spawnAvailability[randSpawn] = false;
            enemyGen x1 = x.GetComponent<enemyGen>();
            x1.num = randSpawn;

        }

    }
    IEnumerator vola()
    {
        Spawn();
        yield return new WaitForSeconds(2.0f);


    }


}
