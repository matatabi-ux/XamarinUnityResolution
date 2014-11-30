#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Phone.Speech.Synthesis;
using XamarinUnityResolution.Services;

namespace XamarinUnityResolution.WinPhone.Services
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
        public async void Speak(string text)
        {
            var synthesizer = new SpeechSynthesizer();
            await synthesizer.SpeakTextAsync(text);
        }
    }
}
