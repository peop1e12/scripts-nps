using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public float speed = 5.0f;  // Скорость движения
    // Start is called before the first frame update
    void Start()
    {
        int level = 1;
        int health = 1;
        health += level;
        print("health");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
