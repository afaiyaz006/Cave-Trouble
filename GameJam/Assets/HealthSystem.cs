using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] hearts;
    public static int health = 30;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (health>=0 && health < 10)
        {
            Destroy(hearts[0]);
        }
        else if (health>=10 && health < 20)
        {
            Destroy(hearts[1]);
        }
        else if (health>=20 && health < 30)
        {
            Destroy(hearts[2]);
        }
    }
}
