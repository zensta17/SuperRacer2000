using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] public Material Material;

    public bool redColorBought = false;
    public bool blueColorBought = false;
    public bool magentaColorBought = false;
    public bool cyanColorBought = false;

    public int kosten = 5;



    public static double coins;
    public Text CoinsAnzahl;

    void Start()
    {
        Debug.Log(coins);
        CoinsAnzahl.text = Math.Truncate(coins).ToString();
    }
    public void Quit()
    {
        Debug.Log("moin aus quit");
        SceneManager.LoadScene("MenuScene"); 
    }

    public void ButtonRed()
    {
        Debug.Log("Auswahl: Rot");

        if ((coins >= kosten) && (redColorBought == false))
        {
            Material.color = Color.red;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
            redColorBought = true;

        }
    }

    public void ButtonBlue()
    {
        Debug.Log("Auswahl: Blau");

        if ((coins >= kosten) && (blueColorBought == false))
        {
            Material.color = Color.blue;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
            blueColorBought = true;
        }
    }

    public void ButtonMagenta()
    {
        Debug.Log("Auswahl: Magenta");
        if ((coins >= kosten) && (magentaColorBought == false))
        {
            Material.color = Color.magenta;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
            magentaColorBought = true;
        }
    }
    public void ButtonCyan()
    {
        Debug.Log("Auswahl: Cyan");
        if ((coins >= kosten) && (cyanColorBought == false))
        {
            Material.color = Color.cyan;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
            cyanColorBought = true;
        }
    }
}

