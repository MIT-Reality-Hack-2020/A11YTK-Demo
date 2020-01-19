using System.Collections;
using System.Collections.Generic;
using A11YTK;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushButton : MonoBehaviour
{
    [SerializeField] private SubtitleOptionsReference _subtitleOptionsReference;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;

        if (other.gameObject.tag.Equals("Controller"))
        {
            MockSubtitles.enabled = true;
        }
    }
}