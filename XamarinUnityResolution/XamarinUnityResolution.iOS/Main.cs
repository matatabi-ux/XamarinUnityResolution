using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using XamarinUnityResolution.iOS.Services;
using XamarinUnityResolution.Services;

namespace XamarinUnityResolution.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // 文字列読み上げサービスを DI コンテナに登録
            App.Container.RegisterType<ITextSpeechService, TextSpeechService>(new ContainerControlledLifetimeManager());

            // アプリケーション起動処理
            App.Current.OnLaunchApplication();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
