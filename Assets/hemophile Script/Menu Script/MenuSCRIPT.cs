using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuSCRIPT : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("testScene");
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}


