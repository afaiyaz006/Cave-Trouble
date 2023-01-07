using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public float delay = 1.5f;
    private float timer;
    public int rate = 3;

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
            for (int i = 1; i <= rate; i++)
            {
                
                Instantiate(enemy, transform.position, transform.rotation);

            }

            timer -= delay;
        }
    }
}
