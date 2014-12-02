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

namespace XamarinUnityResolution.Models
{
    /// <summary>
    /// 写真リポジトリ
    /// </summary>
    public class PhotoRepository : IPhotoRepository
    {
        /// <summary>
        /// 写真アイテム
        /// </summary>
        public IList<PhotoItem> Items { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PhotoRepository()
        {
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        public void Load()
        {
            this.Items = new List<PhotoItem>()
            {
                new PhotoItem(0, "アビシニアン", @"XamarinUnityResolution.Assets.cat01.png"), 
                new PhotoItem(1, "アメリカンカール", @"XamarinUnityResolution.Assets.cat02.png"), 
                new PhotoItem(2, "アメリカンショートヘア", @"XamarinUnityResolution.Assets.cat03.png"), 
                new PhotoItem(3, "アメリカンボブテイル", @"XamarinUnityResolution.Assets.cat04.png"), 
                new PhotoItem(4, "アメリカンワイヤーヘア", @"XamarinUnityResolution.Assets.cat05.png"), 
                new PhotoItem(5, "エキゾチックショートヘア", @"XamarinUnityResolution.Assets.cat06.png"), 
                new PhotoItem(6, "エジプシャンマウ", @"XamarinUnityResolution.Assets.cat07.png"), 
                new PhotoItem(7, "オシキャット", @"XamarinUnityResolution.Assets.cat08.png"), 
                new PhotoItem(8, "オリエンタルショートヘア", @"XamarinUnityResolution.Assets.cat09.png"), 
                new PhotoItem(9, "サイベリアン", @"XamarinUnityResolution.Assets.cat10.png"), 
                new PhotoItem(10, "ジャパニーズボブテイル", @"XamarinUnityResolution.Assets.cat11.png"), 
                new PhotoItem(11, "シャム", @"XamarinUnityResolution.Assets.cat12.png"), 
                new PhotoItem(12, "ターキッシュアンゴラ", @"XamarinUnityResolution.Assets.cat13.png"), 
                new PhotoItem(13, "ノルウェージャンフォレストキャット", @"XamarinUnityResolution.Assets.cat14.png"), 
                new PhotoItem(14, "ペルシャ", @"XamarinUnityResolution.Assets.cat15.png"), 
                new PhotoItem(15, "メインクーン", @"XamarinUnityResolution.Assets.cat16.png"), 
                new PhotoItem(16, "ラグドール", @"XamarinUnityResolution.Assets.cat17.png"), 
                new PhotoItem(17, "マンチカン", @"XamarinUnityResolution.Assets.cat18.png"), 
                new PhotoItem(18, "ブリティッシュショートヘア", @"XamarinUnityResolution.Assets.cat19.png"), 
                new PhotoItem(19, "スコティッシュフォールド", @"XamarinUnityResolution.Assets.cat20.png"), 
            };
        }
    }
}
