using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public void GameOver()
    {
        if (gameHasEnded == false)
        { 
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
         }

    }
    //5:04

    public void LevelComplete()
    {
        Debug.Log("Level Won!");
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
