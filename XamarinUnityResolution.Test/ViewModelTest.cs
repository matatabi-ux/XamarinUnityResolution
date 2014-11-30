#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using XamarinUnityResolution.Models;
using XamarinUnityResolution.Services;
using XamarinUnityResolution.ViewModels;

namespace XamarinUnityResolution.Test
{
    /// <summary>
    /// ViewModel 単体テストコード
    /// </summary>
    [TestClass]
    public class ViewModelTest
    {
        #region Test Initilize & Cleanup

        /// <summary>
        /// クラス初期化処理
        /// </summary>
        [ClassInitialize]
        public static void ClassInitilize(TestContext context)
        {
        }

        /// <summary>
        /// １テストケース初期化処理
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
        }

        /// <summary>
        /// １テストケース終了処理
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
        }

        /// <summary>
        /// クラス終了処理
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        #endregion //Test Initilize & Cleanup

        /// <summary>
        /// TopViewModel のインスタンス生成テスト
        /// </summary>
        [TestMethod]
        [TestCategory("ViewModel")]
        public void TestMethod1()
        {
            try
            {
                var logger = new TestLogger();
                var repository = new PhotoRepository();
                var target = new TopPageViewModel(logger, null, repository, null);

                // ログ出力確認
                Assert.IsTrue(logger.LoggedList.First().EndsWith(@"\TopPageViewModel.cs .ctor ctor"));

                // 読み込みアイテム確認
                Assert.IsTrue(target.Items.SequenceEqual(repository.Items));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
    }
}
