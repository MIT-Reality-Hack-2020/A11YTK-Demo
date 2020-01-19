using System.Collections;
using A11YTK;
using UnityEngine;

public class MockSubtitlesTV2 : MockSubtitles
{
    private SRT.Subtitle[] subtitles =
    {
        new SRT.Subtitle
        {
            id = 1,
            startTime = 0.45,
            endTime = 3.36,
            text = "Hey! Do you know why Pirates don't like Virtual Reality?"
        },
        new SRT.Subtitle
        {
            id = 2,
            startTime = 6.09,
            endTime = 10.32,
            text = "Because they prefer ARRRRRR!!!! **laughs**"
        },
        new SRT.Subtitle
        {
            id = 3,
            startTime = 21.30,
            endTime = 23.39,
            text = "Wait - maybe they don't have subtitles on?"
        }
    };

    private int _currentSubtitleIndex = 0;

    private IEnumerator Start()
    {
        while (!_videoPlayer.isPlaying)
        {
            yield return null;
        }

        var elapsedTime = 0f;

        while (_currentSubtitleIndex < subtitles.Length)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= subtitles[_currentSubtitleIndex].endTime)
            {
                HideText();
                _currentSubtitleIndex += 1;
            }
            else if (elapsedTime >= subtitles[_currentSubtitleIndex].startTime)
            {
                ShowText();
                SetText(subtitles[_currentSubtitleIndex].text);
            }

            yield return null;
        }

        HideText();
    }
}