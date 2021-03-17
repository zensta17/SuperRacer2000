using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static double coins;
    public Text CoinsAnzahl;
    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        coins = data.coins;
        CoinsAnzahl.text = Math.Truncate(data.coins).ToString();
    }
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

