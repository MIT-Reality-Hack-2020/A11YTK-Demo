using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager
public class ResetScene : MonoBehaviour {
    // Start is called before the first frame updatefunction Start () {

    private void Update () {
        if (Input.GetKeyDown ("r")) { //If you press R
            SceneManager.LoadScene ("A11YTK"); //Load scene called Game

        }
    }

}