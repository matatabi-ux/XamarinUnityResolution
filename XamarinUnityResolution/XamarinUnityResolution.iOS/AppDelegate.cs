﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;

namespace XamarinUnityResolution.iOS
{
    /// <summary>
    /// アプリケーション代理クラス
    /// </summary>
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        /// <summary>
        /// ウィンドウ
        /// </summary>
        protected UIWindow window;

        /// <summary>
        /// 起動完了時の処理
        /// </summary>
        /// <param name="app">アプリケーション</param>
        /// <param name="options">オプション指定</param>
        /// <returns></returns>
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            window = new UIWindow(UIScreen.MainScreen.Bounds);

            window.RootViewController = App.GetMainPage().CreateViewController();

            window.MakeKeyAndVisible();

            return true;
        }
    }
}
