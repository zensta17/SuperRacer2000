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
            Invoke("Restart",delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
