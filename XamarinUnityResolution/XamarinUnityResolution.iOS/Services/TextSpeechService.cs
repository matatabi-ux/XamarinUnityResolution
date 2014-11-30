#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using MonoTouch.AVFoundation;
using XamarinUnityResolution.Services;

namespace XamarinUnityResolution.iOS.Services
{
    /// <summary>
    /// 文字列読み上げサービス
    /// </summary>    
    public class TextSpeechService : ITextSpeechService
    {
        /// <summary>
        /// 文字列を読み上げます
        /// </summary>
        /// <param name="text">読み上げる文字列</param>
        public void Speak(string text)
        {
            var synthesizer = new AVSpeechSynthesizer();

            synthesizer.SpeakUtterance(
                new AVSpeechUtterance(text)
                {
                    Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                    Voice = AVSpeechSynthesisVoice.FromLanguage("ja-JP"),
                    Volume = 0.5f,
                    PitchMultiplier = 1.0f
                });
        }
    }
}
