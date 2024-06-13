using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuManager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject nextTwo;
    public GameObject nextThree;
    public GameObject nextFour;
    public GameObject nextFive;
    public GameObject start;

    public GameObject slideOne;
    public GameObject slideTwo;
    public GameObject slideThree;
    public GameObject slideFour;
    public GameObject slideFive;

    public void TutorialStart()
    {
        slideOne.SetActive(true);
        tutorial.SetActive(false);
        nextTwo.SetActive(true);
    }

    public void ShowTwo()
    {
        slideTwo.SetActive(true);
        nextThree.SetActive(true);
        slideOne.SetActive(false);
        nextTwo.SetActive(false);
    }

    public void ShowThree()
    {
        slideThree.SetActive(true);
        nextFour.SetActive(true);
        slideTwo.SetActive(false);
        nextThree.SetActive(false);
    }

    public void ShowFour()
    {
        slideFour.SetActive(true);
        nextFive.SetActive(true);
        slideThree.SetActive(false);
        nextFour.SetActive(false);
    }

    public void ShowFive()
    {
        slideFive.SetActive(true);
        nextFive.SetActive(false);
        slideFour.SetActive(false);
        start.SetActive(true);
    }

    public void StartGame()
    {
       SceneManager.LoadScene("mainScene");
    }
}
