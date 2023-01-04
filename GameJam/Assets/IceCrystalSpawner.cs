using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCrystalSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject iceCrystal;
    public int amount = 5;
    void Start()
    {
        for(int i = 1; i <= amount; i++)
        {
            float randomXRange = Random.Range(-6.00f, 2.10f);

            float randomYRange = Random.Range(3.18f, 4.50f);
            Instantiate(iceCrystal, new Vector2(randomXRange, randomYRange), transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
