using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Story");
    }
    public void Character()

    {
        SceneManager.LoadScene("");
    }


    public void SwipeMenu()
    {
        SceneManager.LoadScene("Swipe Menu");
    }

    public void Yes()
    {
        SceneManager.LoadScene("Game Guide");
    }
    public void No()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void NextTutorial(GameObject controls)
    {
        controls.SetActive(true);
    }
    public void ShowRewards(GameObject rewards)
    {
        rewards.SetActive(true);
    }
}

