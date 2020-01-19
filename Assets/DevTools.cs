using System;
using System.Collections;
using System.Collections.Generic;
using A11YTK;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class DevTools : MonoBehaviour
{
    [SerializeField] private GameObject[] _controllers;
    [SerializeField] private Behaviour[] _editorGazeComponets;
    [SerializeField] private VideoPlayer[] _videoPlayers;

    private float _currentVolume = 1;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("subtitles") == 1)
        {
            MockSubtitles.enabled = true;
            _currentVolume = 0;
        }
        else
        {
            MockSubtitles.enabled = false;
            _currentVolume = 1;
        }


        if (Application.isEditor)
        {
            foreach (var controller in _controllers)
            {
                controller.SetActive(false);
            }
        }
        else
        {
            foreach (var component in _editorGazeComponets)
            {
                component.enabled = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Oculus_CrossPlatform_Button_1"))
        {
            PlayerPrefs.SetFloat("subtitles", 1);

            SceneManager.LoadScene("A11YTk");
        }

        if (_currentVolume > 0)
        {
            _currentVolume = Mathf.Lerp(_currentVolume, 0, Time.deltaTime);
        }

        Debug.Log(_currentVolume);

        foreach (var videoPlayer in _videoPlayers)
        {
            videoPlayer.SetDirectAudioVolume(0, _currentVolume);
        }
    }
}