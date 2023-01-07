using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemy;
    public float delay = 1.5f;
    private float timer;
    public int rate = 3;
    private bool activate = false;
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
                
                Instantiate(enemy[0], transform.position, transform.rotation);

            }

            timer -= delay;
        }
        if ((ScoreKeeper.score+1)%5==0 && activate==false)
        {
            Instantiate(enemy[1], transform.position, transform.rotation);
            activate = true;
        }
        else if ((ScoreKeeper.score + 1) % 5 != 0 && activate==true)
        {
            activate = false;
        }
    }
}
