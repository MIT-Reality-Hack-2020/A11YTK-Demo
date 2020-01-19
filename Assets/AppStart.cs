using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppStart : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetFloat("subtitles", 0);

        SceneManager.LoadScene("A11YTK");
    }
}