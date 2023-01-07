using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] hearts;
    public static int health = 30;
    void Start()
    {
        health = 30;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (health < 0)
        {
            SceneManager.LoadScene(3);
        }
        if (health>=0 && health < 10)
        {
            hearts[0].SetActive(false);
            SceneManager.LoadScene(3);
        }
        else if (health>=10 && health < 20)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(false);
            //Destroy(hearts[1]);
        }
        else if (health>=20 && health < 30)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(true);
            hearts[2].SetActive(false);
            //Destroy(hearts[2]);
        }
        else
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(true);
            hearts[2].SetActive(true);

        }


    }
}
