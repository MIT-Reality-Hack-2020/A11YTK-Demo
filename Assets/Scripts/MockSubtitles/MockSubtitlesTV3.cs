using System.Collections;
using A11YTK;
using UnityEngine;

public class MockSubtitlesTV3 : MockSubtitles
{
    private SRT.Subtitle[] subtitles =
    {
        new SRT.Subtitle
        {
            id = 1,
            startTime = 11.56,
            endTime = 14.08,
            text = "I told you we shouldn't have invited him."
        },
        new SRT.Subtitle
        {
            id = 2,
            startTime = 16.23,
            endTime = 17.36,
            text = "Wait, who is that?"
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
                Debug.Log(MockSubtitles.enabled);

                if (MockSubtitles.enabled)
                {
                    ShowText();
                }

                SetText(subtitles[_currentSubtitleIndex].text);
            }

            yield return null;
        }

        HideText();
    }
}