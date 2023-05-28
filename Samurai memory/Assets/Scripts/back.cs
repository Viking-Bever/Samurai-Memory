using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public AudioSource audioPlayer;

    public void Back()
    {
        audioPlayer.Play(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
