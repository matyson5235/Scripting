using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    Vector3 newPosition;

    void Start()
    {
        health = health + level;
        print("Health = " + health);
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }

}
