using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    public float fallSpeed = 0.1f;
    public GameObject crack;
  
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
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
            
            PlayerScript.poundedByRock += 1;
            HealthSystem.health -= 10;
            Instantiate(crack, transform.position, transform.rotation);
           
            Destroy(gameObject);
            
        }
    }
}
