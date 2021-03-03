using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public void Quit()
    {
        
        Debug.Log("moin aus quit");
        SceneManager.LoadScene("MenuScene");

    }

    public void ButtonRed()
    {
        Debug.Log("Auswahl: Rot");
    }

    public void ButtonBlue()
    {
        Debug.Log("Auswahl: Blau");
    }

    public void ButtonPink()
    {
        Debug.Log("Auswahl: Pink");
    }

    public void ButtonCyan()
    {
        Debug.Log("Auswahl: Cyan");
    }



}

