
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float restartDeley = 1f;

    public GameObject completelevelUI;

    internal void Complitelevel()
    {
        throw new NotImplementedException();
    }

    public void Completelevel()
    {
        completelevelUI.SetActive(true);
    }

   
    public void EndGame()
    {
        if (GameHasEnded == false)
        {

            GameHasEnded = true;
            Debug.Log("Game over!");
            Invoke("Restart", restartDeley);

        }
        

    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
