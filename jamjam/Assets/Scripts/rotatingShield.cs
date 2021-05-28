using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingShield : MonoBehaviour
{

    public GameObject target;
    public float rotateSpeed ;
    private Transform targetPos;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rotateLeft();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rotateRight();
        }


    }

    void rotateLeft()
    {
       transform.RotateAround(targetPos.position, Vector3.forward, rotateSpeed * Time.deltaTime);
    }
    void rotateRight()
    {
        transform.RotateAround(targetPos.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }

}
