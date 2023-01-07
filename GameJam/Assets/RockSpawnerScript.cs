using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawnerScript : MonoBehaviour
{
    public float delay = 6;
    private float timer;
    public GameObject rock;
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
            Vector2 randomPos = new Vector2(PlayerScript.playerXpos, 3.9f);
            Instantiate(rock, randomPos, transform.rotation);
            timer -= delay;
        }

    }
}
