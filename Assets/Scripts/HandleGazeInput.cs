using System.Collections;
using System.Collections.Generic;
using A11YTK;
using UnityEngine;

public class HandleGazeInput : MonoBehaviour {
    public Camera viewCamera;
    public LayerMask hitMask;
    [SerializeField] private Material highlightedMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Ray ray = new Ray (viewCamera.transform.position, viewCamera.transform.rotation * Vector3.forward);
        RaycastHit hit;

        if (_selection != null) {
            var selectionRenderer = _selection.GetComponent<Renderer> ();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        if (Physics.Raycast (ray, out hit, Mathf.Infinity, hitMask)) {
            Debug.Log ("I WORK");
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer> ();
            if (selectionRenderer != null) {
                selectionRenderer.material = highlightedMaterial;
            }

            _selection = selection;

            if (Input.GetKeyDown (KeyCode.Space)) {
                var component = hit.collider.gameObject.GetComponent<SubtitleController> ();
                if (component != null) {

                    component.PlayOneShot ();
                    Debug.Log ("I REALLY WORK");

                }
            }
        }
    }
}