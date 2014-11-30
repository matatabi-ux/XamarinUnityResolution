﻿#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using Prism.Mvvm.Interfaces;
using Xamarin.Forms;
using XamarinUnityResolution.Models;
using XamarinUnityResolution.Services;
using XamarinUnityResolution.Views;
using Microsoft.Practices.Prism.PubSubEvents;

namespace XamarinUnityResolution
{
    /// <summary>
    /// 共通 アプリケーションクラス
    /// </summary>
    public class App
    {
        /// <summary>
        /// アプリケーションクラス参照
        /// </summary>
        public static readonly App Current;

        /// <summary>
        /// アプリ内で管理するモジュールのコンテナ
        /// </summary>
        public static readonly UnityContainer Container = new UnityContainer();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        static App()
        {
            Current = new App();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private App()
            : base()
        {
            // Prism.Mvvm.Xamarin アセンブリを読み込み可能にするおまじない
            var autoWired = ViewModelLocator.AutoWireViewModelProperty.DefaultValue;
        }

        /// <summary>
        /// アプリケーション起動処理
        /// </summary>
        public void OnLaunchApplication()
        {
            // ログ出力サービスを DI コンテナに登録
            Container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());

            // EventAggregator の生成に UnityContainer を使います
            Container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());

            // Model を DI コンテナに登録
            Container.RegisterType<IPhotoRepository, PhotoRepository>(new ContainerControlledLifetimeManager());

            // ViewModel をインスタンス化するデフォルトメソッドを指定します
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => Container.Resolve(type));

            // 画面遷移サービスの生成方法を注入します
            Container.RegisterType<INavigationService, NavigationService>(new ContainerControlledLifetimeManager());

            // Page クラスの生成に UnityContainer を使います
            NavigationService.SetPageFactiory(type => Container.Resolve(type));
            NavigationService.SetRootPage(new NavigationPage(new TopPage()));
        }

        /// <summary>
        /// メイン画面を取得します
        /// </summary>
        /// <returns>メイン画面</returns>
        public static Page GetMainPage()
        {
            return NavigationService.RootPage;
        }
    }
}
