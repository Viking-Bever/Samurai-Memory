using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Meny : MonoBehaviour
{
    // Tar dig till Spelet
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Avslutar spelet. 
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit(); 
    }

    // Tar dig till inställning (som inte finns) 
    public void Option()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
