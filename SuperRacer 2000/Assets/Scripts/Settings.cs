using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("moin aus quit");
        SceneManager.LoadScene("MenuScene");
        
    }

}
