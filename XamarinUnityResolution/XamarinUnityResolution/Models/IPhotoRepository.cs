using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinUnityResolution.Models
{
    /// <summary>
    /// 写真リポジトリのインタフェース
    /// </summary>
    public interface IPhotoRepository
    {
        /// <summary>
        /// 写真アイテム
        /// </summary>
        IList<PhotoItem> Items { get; }

        /// <summary>
        /// データ読み込み
        /// </summary>
        void Load();
    }
}
