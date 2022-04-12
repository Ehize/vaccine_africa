using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    void Start()
    {
        characters[1].SetActive(false);
        characters[2].SetActive(false);
        characters[3].SetActive(false);
    }

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {

        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }

    public void DefaultStart()
    {
        PlayerPrefs.SetInt("selectedCharacter", 0);
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }

}
