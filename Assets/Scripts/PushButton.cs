using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour {

    private void OnTriggerEnter (Collider other) {

        Debug.Log ("trigger enter");
        Renderer render = GetComponent<Renderer> ();
        render.material.color = Color.green;

        // if (other.gameObject.tag.Equals ("Controller")) {

        //     Debug.Log ("subtitles start");

        // }

    }

}