using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void onCollisionEnter2D(Collision2D col) 
    {
        // target is hit
        if(col.gameObject.tag == "Bullet")
        {
            Debug.Log("Target was Hit!");
            
            // calling AddScore method
            ScoreBehaviour.AddScore();
            
            // play sound
            source.Play();
            
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}