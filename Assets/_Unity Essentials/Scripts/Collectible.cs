using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float speed = 5f;
    public GameObject OnCollectEffect;
    void Start()
    {

    }

    void Update()
    {
        float rotation = speed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(OnCollectEffect, transform.position, transform.rotation);
        }
        
    }
}
