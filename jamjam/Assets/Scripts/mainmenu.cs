using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    
    public void single()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    public void multi()
    {
        SceneManager.LoadScene("MultiPlayer");
    }

    public void quit()
    {
        Application.Quit();
    }

}
