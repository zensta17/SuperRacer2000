using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] public Material Material;

    

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
      

        if (coins >= kosten)
        {
            Material.color = Color.red;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
        }

       
    }


    public void ButtonBlue()
    {
        Debug.Log("Auswahl: Blau");
       

        if (coins >= kosten)
        {
            Material.color = Color.blue;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString(); 
        } 
    }


    public void ButtonMagenta()
    {
        Debug.Log("Auswahl: Magenta");
        

        if (coins >= kosten)
        {
            Material.color = Color.magenta;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
            
        }

      
    }

    public void ButtonCyan()
    {
        Debug.Log("Auswahl: Cyan");
        

        if (coins >= kosten)
        {
            Material.color = Color.cyan;
            coins = coins - kosten;
            CoinsAnzahl.text = Math.Truncate(coins).ToString();
           
        }
    }
}

