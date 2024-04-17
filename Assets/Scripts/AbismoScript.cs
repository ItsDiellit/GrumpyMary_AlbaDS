using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AbismoScript : MonoBehaviour
{
    private AudioSource source;
    public AudioClip DeathSound;

    // Start is called before the first frame update
    void Start()
    {
    source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.gameObject.tag == "Player")
        {
        source.clip = DeathSound;
        source.Play();
            //SceneManager.LoadScene ("GameOver");
            Destroy(Collider.gameObject, 1f);
        }
    }

}
