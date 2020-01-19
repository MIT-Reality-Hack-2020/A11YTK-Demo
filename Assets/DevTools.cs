using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField] private GameObject[] _controllers;
    [SerializeField] private Behaviour[] _editorGazeComponets;

    private void Start()
    {
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