using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 0;
    public float scaleFactor = 0.05f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.3f)
        {

            Destroy(gameObject);
            timer -= 0.3f;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "enemy")
        {

            /*Vector2 objectScale = collision.gameObject.transform.localScale;
            objectScale.y += 2.0f;
            collision.gameObject.transform.localScale = objectScale;*/
            collision.gameObject.transform.position += new Vector3(0, 1, 0) * scaleFactor/2;
            collision.gameObject.transform.localScale += new Vector3(0, 1, 0) * scaleFactor;
            Destroy(gameObject);
        }


    }
}
