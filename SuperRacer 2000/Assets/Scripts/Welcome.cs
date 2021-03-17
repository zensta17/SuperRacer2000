using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{

    private void Start()
    {
        SaveSystem.path = Application.persistentDataPath + "/player.fun";
        if (!File.Exists(SaveSystem.path))
        {
            PlayerData data = new PlayerData(0, 0);
            SaveSystem.SavePlayer(data);
        }
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void ShopScript()
    {
        SceneManager.LoadScene("ShopScene");
    }
}

