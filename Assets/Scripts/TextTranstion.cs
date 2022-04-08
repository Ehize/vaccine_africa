using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTranstion : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            StartCoroutine(NextSlide());
        
    }
    IEnumerator NextSlide()
    {
        yield return new WaitForSeconds(5);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);
    
        yield return new WaitForSeconds(7);
        scene2.SetActive(true);
        yield return new WaitForSeconds(6);
        scene3.SetActive(true);
        yield return new WaitForSeconds(6);
        scene4.SetActive(true);
    }
   
}
