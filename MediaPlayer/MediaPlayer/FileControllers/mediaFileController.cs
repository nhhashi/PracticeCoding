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
        /// getter用のファイル一覧
        /// </summary>
        private Dictionary<int, string> files = new Dictionary<int, string>();

        /// <summary>
        /// ファイル一覧の保持変数
        /// </summary>
        private Dictionary<int, string> fileNames = new Dictionary<int, string>();

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
        public Dictionary<int, string> getMusicFilePathes()
        {
            return files;
        }

        /// <summary>
        /// メディアファイルパス取得関数
        /// </summary>
        /// <remarks>
        /// メディアファイルを取得する関数
        /// </remarks>
        private Dictionary<int,string> readFilePathes()
        {
            int fileNum = 0;

            ///相対パスの取得をする
            string relativePathName = System.IO.Path.GetFullPath("..\\..\\Media\\music");

            ///musicフォルダ内の音楽ファイルを全て取得する
            string[] files = Directory.GetFiles(relativePathName);

            ///個々のファイル名を取得する
            foreach (string str in files)
            {
                fileNum++;

                fileNames.Add(fileNum, str);
            }

            return fileNames;
        }
    }
}
