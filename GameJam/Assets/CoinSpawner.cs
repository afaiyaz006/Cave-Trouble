using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float delay = 10;
    private float timer;
    public GameObject[] coins;

    void Start()
    {

    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            Vector2 randomPos = new Vector2(Random.Range(-6.94f, 5.00f), 3.9f);
            Instantiate(coins[Random.Range(0,coins.Length)], randomPos, transform.rotation);
            timer -= delay;
        }

    }
}
