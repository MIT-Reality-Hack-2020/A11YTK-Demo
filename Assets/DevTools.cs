using System;
using System.Collections;
using System.Collections.Generic;
using A11YTK;
using UnityEditor;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField] private GameObject[] _controllers;
    [SerializeField] private Behaviour[] _editorGazeComponets;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("subtitles") == 1)
        {
            MockSubtitles.enabled = true;
        }
        else
        {
            MockSubtitles.enabled = false;
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
}