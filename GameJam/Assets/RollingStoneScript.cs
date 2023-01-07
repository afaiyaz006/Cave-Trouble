using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RollingStoneScript : MonoBehaviour
{
    public float enemySpeedLowest = 0.005f;
    public float enemySpeedHigest = 0.08f;
    private static float enemySpeed;
    void Start()
    {
        enemySpeed = Random.Range(enemySpeedLowest, enemySpeedHigest);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 enemyPos = transform.position;
        enemyPos.x -= enemySpeed;
        transform.position = enemyPos;

        transform.localEulerAngles += new Vector3(0f, 0f, 0.5f);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (collision.gameObject.name == "player")
        {
            SceneManager.LoadScene(3);
        }

    }
}
