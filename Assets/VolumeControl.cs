using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class VolumeControl : MonoBehaviour {
    private UnityEngine.Video.VideoPlayer[] videoPlayers;

    public GameObject[] videoPlayerContiner;

    // Start is called before the first frame update
    void Start () {
        foreach (GameObject container in videoPlayerContiner) {
            var player = container.transform.FindChild ("")
        }

    }

    // Update is called once per frame
    void Update () {

    }
}