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

namespace XamarinUnityResolution.Services
{
    /// <summary>
    /// 文字列読み上げサービスのインタフェース
    /// </summary>
    public interface ITextSpeechService
    {
        /// <summary>
        /// 文字列を読み上げます
        /// </summary>
        /// <param name="text">読み上げる文字列</param>
        void Speak(string text);
    }
}
