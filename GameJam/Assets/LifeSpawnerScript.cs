using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawnerScript : MonoBehaviour
{
    public float delay = 10;
    private float timer;
    public GameObject lifeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            Vector2 randomPos = new Vector2(Random.Range(-6.94f,5.00f), 3.9f);
            Instantiate(lifeObject, randomPos, transform.rotation);
            timer -= delay;
        }

    }
}
