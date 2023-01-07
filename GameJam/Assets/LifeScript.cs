using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public float fallSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    void FixedUpdate()
    {
        Vector2 rockPosition = transform.position;
        rockPosition.y -= fallSpeed;
        transform.position = rockPosition;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "player")
        {


            if (HealthSystem.health < 30)
            {
                HealthSystem.health += 10;
            }
            

            Destroy(gameObject);

        }
    }
}
