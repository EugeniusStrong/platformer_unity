using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Score Score;
    public GameObject OneStar;
    public GameObject TwoStars;
    public GameObject ThreeStars;
    public GameObject Text;
    public GameObject FinishImage;
    public AudioSource levelPassed;

    public MonoBehaviour[] ComponentsToDisable;

    public void FinishScreen()
    {

        if(Score.Coins >= 1)
        {
            OneStar.SetActive(true);
        }
        else
        {
            OneStar.SetActive(false);
        }
        if (Score.Coins >= 18)
        {
            TwoStars.SetActive(true);
        }
        else
        {
            TwoStars.SetActive(false);
        }
        if (Score.Coins >= 30)
        {
            ThreeStars.SetActive(true);
        }
        else
        {
            ThreeStars.SetActive(false);
        }
    }
    public void GameFinish()
    {
        for (int i = 0; i < ComponentsToDisable.Length; i++)
        {
            ComponentsToDisable[i].enabled = false;

        }
        Time.timeScale = 0.01f;
        Cursor.visible = true;
        GameObject.FindWithTag("Finish").SetActive(false);
        GameObject.FindWithTag("GameController").SetActive(false);
        levelPassed.Play();
        Text.SetActive(true);
        FinishImage.SetActive(true);
        
    }
}
