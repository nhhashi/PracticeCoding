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
        /// メディア名、メディアパス
        /// </summary>
        private Dictionary<string, string> files = new Dictionary<string, string>();

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
        }

        /// <summary>
        /// メディアデータ表示関数
        /// </summary>
        private void displayFileNameOnDataGrid()
        {
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
