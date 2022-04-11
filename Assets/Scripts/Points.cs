using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField] private int points;
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI notEnoughPointsText;
    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Points:" + points;
    }

    // Update is called once per frame
    void Update()
    {
        CalculatePoint();
    }
    void CalculatePoint()
    {
        if (points < 100)
        {
            notEnoughPointsText.gameObject.SetActive(true);

        }
    }
}
