using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private AudioSource source;
    public AudioClip ObjectSound;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
   void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.gameObject.tag == "Player")

        {
           source.clip = ObjectSound;
           source.Play();
           Destroy(gameObject, 0.4f);

        }
        
    }
}
