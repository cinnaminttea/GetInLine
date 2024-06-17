using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreB; 
    public TMP_Text BlackScoreText;
    public GameObject BlackWinPanel;

    public static int ScoreW;
    public TMP_Text WhiteScoreText;
    public GameObject WhiteWinPanel;

    // Start is called before the first frame update
    void Start()
    {
        ScoreB = 0;
        ScoreW = 0;
    }

    void Update()
    {
        if (ScoreB >= 6)
        {
            BlackWinPanel.SetActive(true);
        }

        if (ScoreW >= 6)
        {
            WhiteWinPanel.SetActive(true);
        }
    }

    public void AddScoreB()
    {
        ScoreB = ScoreB + 1;
        BlackScoreText.text = ScoreB.ToString();
    }

    public void AddScoreW()
    {
        ScoreW = ScoreW + 1;
        WhiteScoreText.text = ScoreW.ToString();
    }
}
