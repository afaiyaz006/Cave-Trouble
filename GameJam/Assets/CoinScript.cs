using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float fallSpeed;
 
    void FixedUpdate()
    {
        Vector2 coinPosition = transform.position;
        coinPosition.y -= fallSpeed;
        transform.position =coinPosition;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        //hae hae onek modularize korte partam, who cares
        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "player" && gameObject.tag=="coin-5")
        {
     
            ScoreKeeper.score += 5;
            Destroy(gameObject);

        }
        else if (collision.gameObject.name == "player" && gameObject.tag == "coin-10")
        {
            
            ScoreKeeper.score += 10;
            Destroy(gameObject);

        }
        else if (collision.gameObject.name == "player" && gameObject.tag == "coin-15")
        {
            
            ScoreKeeper.score += 15;
            Destroy(gameObject);
            

        }
        else if (collision.gameObject.name == "player")
        {
            if (gameObject.tag == "coin-5_negetive")
            {
                if(ScoreKeeper.score>=5) ScoreKeeper.score -= 5;
                Destroy(gameObject);


            }
            else if (gameObject.tag == "coin-10_negetive")
            {
                if(ScoreKeeper.score>=10) ScoreKeeper.score -= 10;
                Destroy(gameObject);


            }
            else if (gameObject.tag == "coin-15_negetive")
            {
                if(ScoreKeeper.score>=15) ScoreKeeper.score -= 15;
                Destroy(gameObject);


            }
        }
    }
}
