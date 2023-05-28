using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public AudioSource audioplayer;
    // Tar dig till spelet igen
    public void StartaOm()
    {
        audioplayer.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // Tar dig till menyn. 
    public void Meny()
    {
        audioplayer.Play(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}