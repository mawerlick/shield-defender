using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;




public class gameoverscreen : MonoBehaviour
{

    public TextMeshProUGUI text;


    public void Setup(int score)
    {
        gameObject.SetActive(true);
        text.text = "YOUR SCORE: " + score.ToString();

    }


    public void restart1()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    public void restart2()
    {
        SceneManager.LoadScene("MultiPlayer");
    }


    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
    }


}
