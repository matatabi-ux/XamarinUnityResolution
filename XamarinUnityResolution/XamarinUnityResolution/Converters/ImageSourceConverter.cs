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
using Xamarin.Forms;

namespace XamarinUnityResolution.Converters
{
    /// <summary>
    /// 画像パスの文字列を ImageSource に変換する Converter
    /// </summary>
    public class ImageSourceConverter : IValueConverter
    {
        #region IValueConverter

        /// <summary>
        /// 画像パスの文字列を ImageSource に変換します
        /// </summary>
        /// <param name="value">画像パスの文字列</param>
        /// <param name="targetType">変換後の型</param>
        /// <param name="parameter">パラメータ</param>
        /// <param name="culture">対象カルチャ</param>
        /// <returns>ImageSource</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is string))
            {
                return default(ImageSource);
            }

            return ImageSource.FromResource(value.ToString());
        }

        /// <summary>
        /// ImageSource を画像パスの文字列に変換します
        /// </summary>
        /// <param name="value">画像パスの文字列</param>
        /// <param name="targetType">変換後の型</param>
        /// <param name="parameter">パラメータ</param>
        /// <param name="culture">対象カルチャ</param>
        /// <returns>画像パスの文字列</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion //IValueConverter
    }
}