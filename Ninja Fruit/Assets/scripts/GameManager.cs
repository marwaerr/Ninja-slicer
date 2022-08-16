
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    bool gameHasEnded = false;
    public float restartdelay = 2f;
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    public void Endgame(int r)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverScreen.Setup(r);
           
        }
       
    } 
   public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
