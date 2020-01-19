using System.Text.RegularExpressions;
using UnityEngine;

namespace A11YTK
{

    public static class SRT
    {

        public struct Subtitle
        {

            public int id;

            public double startTime;

            public double endTime;

            public string text;

        }

        public static Subtitle[] ParseFromContents(string contents)
        {

            Debug.Log(contents);

            var subtitles = Regex.Split(contents, @"(?:^|\n)([0-9]+)(?:\n)", RegexOptions.Multiline);

            Debug.Log(subtitles[0]);

            return new Subtitle[] { };

        }

    }

}
