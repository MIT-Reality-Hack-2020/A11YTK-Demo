using System.Collections;
using A11YTK;
using UnityEngine;

public class MockSubtitlesTV1 : MockSubtitles
{
    private SRT.Subtitle[] subtitles = new[]
    {
        new SRT.Subtitle
        {
            id = 1,
            startTime = 4.20,
            endTime = 5.38,
            text = "Uh ... no?"
        },
        new SRT.Subtitle
        {
            id = 2,
            startTime = 10.31,
            endTime = 11.45,
            text = "*laugh* Oh my god."
        },
        new SRT.Subtitle
        {
            id = 3,
            startTime = 18.59,
            endTime = 20.27,
            text = "Can they not understand us?"
        },
        new SRT.Subtitle
        {
            id = 4,
            startTime = 24.43,
            endTime = 25.16,
            text = "I think you're right!"
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