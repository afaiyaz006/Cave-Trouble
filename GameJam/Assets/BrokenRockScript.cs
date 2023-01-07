using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenRockScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private AudioSource rockExplodeSound;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 0.5f);
    }
}
