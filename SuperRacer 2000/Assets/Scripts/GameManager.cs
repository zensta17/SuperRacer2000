using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float delay = 0.3f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Shop.coins += Score.score / 5;

            PlayerData data = SaveSystem.LoadPlayer();
            if(Score.score > data.score)
            {
                PlayerData d = new PlayerData(Shop.coins, Score.score);
                SaveSystem.SavePlayer(d);
            }
            else
            {
                PlayerData d = new PlayerData(Shop.coins, data.score);
                SaveSystem.SavePlayer(d);
            }

            Invoke("Restart",delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
