using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private AudioSource bgmusic;
    [SerializeField]
    public  AudioSource enemyDestroyed;
    void Start()
    {
        bgmusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
