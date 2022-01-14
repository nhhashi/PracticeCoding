using MediaPlayer.FileControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MediaPlayer.MediaPlayerWindows
{
    class MediaPlayerViewController
    {
        /// <summary>
        /// MediaPlayerウインドウのインスタンス変数
        /// </summary>
        private MediaPlayer _MediaPlayer;

        /// <summary>
        /// mediaFileControllerのインスタンス変数
        /// </summary>
        private mediaFileController musicFileController;

        /// <summary>
        /// 連番、メディアパス
        /// </summary>
        private Dictionary<int, string> files = new Dictionary<int, string>();

        /// <summary>
        /// メディア名
        /// </summary>
        private List<string> mediaFileName = new List<string>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mediaPlayer"></param>
        public MediaPlayerViewController(MediaPlayer mediaPlayer)
        {
            _MediaPlayer = mediaPlayer;

            musicFileController = new mediaFileController();

            ///ファイルパスの取得をする
            files = musicFileController.getMusicFilePathes();
            extractMediaFileName();

            ///データグリッドに追加する
            displayFileNameOnDataGrid();
        }

        /// <summary>
        /// ファイル名取得関数
        /// </summary>
        private void extractMediaFileName()
        {
            string eachFileName = string.Empty;
            int i = 0;

            ///ファイル名を取得する
            foreach (KeyValuePair<int, string> keyValue in files)
            {
                i++;

                string[] str = keyValue.Value.Split('\\');
                eachFileName = str[str.Length - 1];

                mediaFileName.Add(eachFileName);
            }
        }

        /// <summary>
        /// メディアデータ表示関数
        /// </summary>
        private void displayFileNameOnDataGrid()
        {
            ///データグリッドに名前の追加をする
            foreach(string str in mediaFileName)
            {
                MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.Rows.Add(str);
            }
        }

        /// <summary>
        /// メディア再生関数
        /// </summary>
        private void mediaPlay()
        {
        }

        /// <summary>
        /// メディア停止関数
        /// </summary>
        private void mediaStop()
        {
        }

        /// <summary>
        /// 選択中のファイル名の表示関数
        /// </summary>
        private void dislpaySelectedFileNameOnLabel()
        {
        }

        /// <summary>
        /// 次ファイルの選択関数
        /// </summary>
        private void selectNextFile()
        {
        }

        /// <summary>
        /// 前ファイルの選択関数
        /// </summary>
        private void selectpreviousFile()
        {
        }
    }
}
