using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{ 
    public void Play()
    {
        SceneManager.LoadScene("");
    }

    public void SwipeMenu()
    {
        SceneManager.LoadScene("Swipe Menu");
    }
   
}
