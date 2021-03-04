using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
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

