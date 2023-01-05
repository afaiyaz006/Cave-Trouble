using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeedLowest = 0.005f;
    public float enemySpeedHigest = 0.08f;
    public AnimationClip animClip;
    private static float enemySpeed;
    public GameObject boom;
    
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
          
            ScoreKeeper.score += 1;
           
            Destroy(gameObject);
            
            Instantiate(boom, transform.position+new Vector3(0,1.5f,0), transform.rotation);
           
        }
        if (collision.gameObject.name == "player")
        {
            SceneManager.LoadScene(2);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }

}
