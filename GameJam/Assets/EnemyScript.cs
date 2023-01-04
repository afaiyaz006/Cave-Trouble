using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeedLowest = 0.005f;
    public float enemySpeedHigest = 0.08f;
    private static float enemySpeed;
    void Start()
    {
        enemySpeed = Random.Range(enemySpeedLowest, enemySpeedHigest);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemy Speed is: " + enemySpeed);
        Vector2 enemyPos = transform.position;
        enemyPos.x -= enemySpeed;
        transform.position = enemyPos;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "IceCrystal")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "player")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }

}
