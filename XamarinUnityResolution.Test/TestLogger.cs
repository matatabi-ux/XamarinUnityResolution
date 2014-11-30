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
    /// ログ出力サービスのテスト用スタブ
    /// </summary>
    public class TestLogger : ILogger
    {
        /// <summary>
        /// 出力ログ情報リスト
        /// </summary>
        public List<string> LoggedList { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TestLogger()
        {
            this.LoggedList = new List<string>();
        }

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
            this.LoggedList.Add(string.Format("{0} {1} {2}", filePath, name, message));
        }
    }
}