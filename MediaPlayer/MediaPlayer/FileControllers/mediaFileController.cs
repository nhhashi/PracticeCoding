using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.FileControllers
{
    class mediaFileController
    {
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> files = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> fileNames = new Dictionary<string, string>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public mediaFileController()
        {
            ///音楽ファイルの取得をする
            files = readFilePathes();
        }

        /// <summary>
        /// メディアファイルパス取得関数
        /// </summary>
        /// <remarks>
        /// 外部のクラスからメディアファイルを取得する関数
        /// </remarks>
        public Dictionary<string, string> getMusicFilePathes()
        {
            return files;
        }

        /// <summary>
        /// メディアファイルパス取得関数
        /// </summary>
        /// <remarks>
        /// メディアファイルを取得する関数
        /// </remarks>
        private Dictionary<string,string> readFilePathes()
        {
            string eachFileName = string.Empty;

            ///相対パスの取得をする
            string relativePathName = System.IO.Path.GetFullPath("..\\..\\Media\\music");

            ///musicフォルダ内の音楽ファイルを全て取得する
            string[] files = Directory.GetFiles(relativePathName);

            ///個々のファイル名を取得する
            foreach (string str in files)
            {
                string[] test = str.Split('\\');
                eachFileName = test[test.Length - 1];

                fileNames.Add(eachFileName, str);
            }

            return fileNames;
        }
    }
}
