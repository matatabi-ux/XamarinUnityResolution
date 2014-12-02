#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using XamarinUnityResolution.Models;
using XamarinUnityResolution.Services;
using XamarinUnityResolution.ViewModels;
using XamarinUnityResolution.Views;

namespace XamarinUnityResolution.ViewModels
{
    /// <summary>
    /// 最初の画面の ViewModel
    /// </summary>
    public class TopPageViewModel : BindableBase
    {
        #region Privates

        /// <summary>
        /// ログ出力サービス
        /// </summary>
        private ILogger logger;

        /// <summary>
        /// リポジトリ
        /// </summary>
        private IPhotoRepository repository;

        /// <summary>
        /// 文字列読み上げサービス
        /// </summary>
        private ITextSpeechService speechService;

        #endregion //Privates

        #region Items プロパティ

        /// <summary>
        /// リストアイテム
        /// </summary>
        private IList<PhotoItem> items = new ObservableCollection<PhotoItem>();

        /// <summary>
        /// リストアイテム の取得と設定
        /// </summary>
        public IList<PhotoItem> Items
        {
            get { return this.items; }
            set { this.SetProperty<IList<PhotoItem>>(ref this.items, value); }
        }

        #endregion //Items プロパティ

        #region SelectedItem

        /// <summary>
        /// 選択アイテム
        /// </summary>
        private PhotoItem selectedItem = null;

        /// <summary>
        /// 選択アイテム の取得と設定
        /// </summary>
        public PhotoItem SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                this.SetProperty<PhotoItem>(ref this.selectedItem, value);
                if (this.selectedItem == null)
                {
                    return;
                }
                this.speechService.Speak(this.selectedItem.Title);
            }
        }

        #endregion //SelectedItem プロパティ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="logger">ログ出力サービス（DI コンテナにより自動注入される）</param>
        /// <param name="repository">リポジトリ（DI コンテナにより自動注入される）</param>
        /// <param name="speechService">文字列読み上げサービス（DI コンテナにより自動注入される）</param>
        public TopPageViewModel(ILogger logger, IPhotoRepository repository, ITextSpeechService speechService)
        {
            this.logger = logger;
            this.logger.WriteLog("ctor");

            this.repository = repository;
            this.repository.Load();

            this.Items.Clear();
            foreach (var photo in this.repository.Items)
            {
                this.Items.Add(photo);
            }

            this.speechService = speechService;
        }
    }
}
