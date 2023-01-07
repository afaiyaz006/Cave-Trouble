using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCrystalSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] iceCrystalsPosition;
    public GameObject iceCrystal;
    public int amount = 15;
    void Start()
    {
        for(int i = 1; i <= amount; i++)
        {
            int randomPos = Random.Range(0,iceCrystalsPosition.Length-1);
            Instantiate(iceCrystal, iceCrystalsPosition[randomPos].transform.position, transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
