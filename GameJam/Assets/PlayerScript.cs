using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public GameObject scalebullet;
    public GameObject bulletSpawn;
    public float playerSpeed = 10f;
    private bool is_jumping = false;
    public float fireRate = 0.1f;
    private float nextFire = 0.0f;
    public static float playerXpos;
    public static int poundedByRock = 0;
    void Start()
    {

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B) && Time.time > nextFire)
        {
            GameObject bulletObject = Instantiate(scalebullet, bulletSpawn.transform.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(3000f, 0));
            nextFire = Time.time + fireRate;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !is_jumping)
        {
            /*
            Rigidbody2D  rigidbody2d = GetComponent<Rigidbody2D>();
            //rigidbody2d.velocity = transform.right * 10.0f;
            float direction = transform.right.x > 0 ? 1.0f : -1.0f;
            float vx = direction * 6f;
            float vy = 20.0f * Mathf.Sin((20.0f * Mathf.PI) / 180);
            rigidbody2d.velocity = new Vector2(vx, vy);*/
            Rigidbody2D rigidbody2d = GetComponent<Rigidbody2D>();
            rigidbody2d.AddForce(new Vector2(0, 300.0f));
        }
        playerXpos = transform.position.x;
        if (poundedByRock == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (!is_jumping)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector2 playerPos = transform.position;
            playerPos.x += horizontal * playerSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            is_jumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            is_jumping = true;
        }
    }
}
