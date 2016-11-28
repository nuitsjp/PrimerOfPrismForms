using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace TypeSafeNavigation
{
    /// <summary>
    /// 画面遷移を表すクラス
    /// </summary>
    public class Navigation
    {
        /// <summary>
        /// 画面遷移先
        /// </summary>
        private readonly NavigateDestination _destination;
        /// <summary>
        /// 画面遷移時のパラメーター
        /// </summary>
        private readonly NavigationParameters _parameters;

        /// <summary>
        /// 画面遷移先のみを指定してインスタンスを初期化する
        /// </summary>
        /// <param name="destination"></param>
        public Navigation(NavigateDestination destination)
            : this(destination, new NavigationParameters())
        {
        }

        /// <summary>
        /// 画面遷移先とクエリー文字列状のパラメーターを指定しインスタンスを初期化する
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="query"></param>
        public Navigation(NavigateDestination destination, string query)
            : this(destination, new NavigationParameters(query))
        {
        }

        /// <summary>
        /// 画面遷移先と遷移パラメーターを指定してインスタンスを初期化する
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="parameters"></param>
        public Navigation(NavigateDestination destination, NavigationParameters parameters)
        {
            _destination = destination;
            _parameters = parameters;
        }

        /// <summary>
        /// 遷移パラメーターを取得・設定する
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public object this[string param]
        {
            get { return _parameters[param]; }
            set { _parameters[param] = value; }
        }

        /// <summary>
        /// Prismの画面遷移指定に適用可能な文字列へ変換する
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _destination.ToString() + _parameters.ToString();
        }
    }
}
