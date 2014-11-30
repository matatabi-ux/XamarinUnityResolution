#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinUnityResolution.Services
{
    /// <summary>
    /// ログ出力サービスのインタフェース
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// ログを出力します
        /// </summary>
        /// <param name="message">出力メッセージ</param>
        /// <param name="filePath">呼び出し元ファイルパス</param>
        /// <param name="name">呼び出し元メンバー名称</param>
        /// <param name="line">呼び出し元行番号</param>
        public void WriteLog(string message, [CallerFilePath] string filePath = null, [CallerMemberName] string name = null,
            [CallerLineNumber] int line = -1)
        {
            Debug.WriteLine(string.Format("{0} {1}({2:D}) {3} {4}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), filePath, line, name, message));
        }
    }
}