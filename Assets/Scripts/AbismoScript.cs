using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AbismoScript : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.gameObject.tag == "Player")
        {
        PlayerMovement playerScript = Collider.gameObject.GetComponent<PlayerMovement>();
         
          //playerScript.Death();

          if(playerScript.isDeath == false)
          {
            
            playerScript.StartCoroutine("Die");
            }
        }
    }

}
