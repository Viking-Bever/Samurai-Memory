using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Meny : MonoBehaviour
{

    public AudioSource audioPlayer; 
    // Tar dig till Spelet
    public void PlayGame()
    {
        audioPlayer.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Avslutar spelet. 
    public void QuitGame()
    {
        audioPlayer.Play();
        Debug.Log("Quit");
        Application.Quit(); 
    }

    // Tar dig till inställning (som inte finns) 
    public void Option()
    {
        audioPlayer.Play(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
