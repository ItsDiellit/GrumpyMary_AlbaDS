using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

   
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("nivel 1");
    }
}
