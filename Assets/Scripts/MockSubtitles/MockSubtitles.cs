using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class MockSubtitles : MonoBehaviour
{
    public static bool enabled = false;

    [SerializeField] protected Camera _mainCamera;
    [SerializeField] protected Canvas _canvas;
    [SerializeField] protected TextMeshProUGUI _textMesh;
    [SerializeField] protected VideoPlayer _videoPlayer;

    private void Awake()
    {
        HideText();
    }

    protected void ShowText()
    {
        _canvas.enabled = true;
    }

    protected void SetText(string value)
    {
        var valueSizeDelta = _textMesh.GetPreferredValues(value);

        _canvas.GetComponent<RectTransform>().sizeDelta = valueSizeDelta;

        _textMesh.text = value;
    }

    protected void HideText()
    {
        _canvas.enabled = false;
    }

    private void Update()
    {
        // _canvas.GetComponent<RectTransform>().LookAt(_mainCamera.transform);
    }
}