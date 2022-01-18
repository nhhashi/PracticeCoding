using MediaPlayer.DataModel;
using MediaPlayer.FileControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer.MediaPlayerWindows
{
    class MediaPlayerViewController
    {
        /// MediaPlayerウインドウのインスタンス変数
        private MediaPlayer _mediaPlayer;

        /// mediaFileControllerのインスタンス変数
        private mediaFileController musicFileController;

        /// 連番、メディアパス
        private Dictionary<int, string> files = new Dictionary<int, string>();

        /// メディア名
        private List<string> mediaFileName = new List<string>();

        /// コントロール群
        private List<Control> controls = new List<Control>();

        /// 選択しているデータグリッドのファイルの選択番号
        private int selectecMediaFileIndex = 0;

        /// 再生状態
        mediaPlayState playState = mediaPlayState.STOP;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mediaPlayer">[in]MediaPlayerインスタンス</param>
        public MediaPlayerViewController(MediaPlayer mediaPlayer)
        {
            ///フォーr無の読み込み
            this._mediaPlayer = mediaPlayer;

            ///メディアファイルの読み込み
            musicFileController = new mediaFileController();

            ///ファイルパスの取得をする
            files = musicFileController.getMusicFilePathes();
            extractMediaFileName();

            ///データグリッドに追加する
            displayFileNameOnDataGrid();

            ///MediaPlayerウィンドウ内のコントロールからパネルを取得する
            Control panel = _mediaPlayer.Controls[0];

            ///パネル内のコントロールを全て取得する
            foreach (Control child in panel.Controls)
            {
                controls.Add(child);
            }

            ///イベントハンドラー設定
            ///データグリッド
            _mediaPlayer.fileNameDisplayDataGrid.Click += new EventHandler(dataGrid_MouseUp);
            ///再生ボタン群
            controls[(int)mediaControls.PREVIOUS].Click += new EventHandler(PreviousButton_Click);　　//次ボタン
            controls[(int)mediaControls.NEXT].Click += new EventHandler(NextButton_Click);    //前ボタン
            controls[(int)mediaControls.PLAYSTOP].Click += new EventHandler(mediaPlayButton_Click);    //前ボタン

            ///コントロールの表示設定
            controls[(int)mediaControls.PREVIOUS].Text = "◀◀";
            controls[(int)mediaControls.NEXT].Text = "▶▶";
            controls[(int)mediaControls.PLAYSTOP].Text = "▶";
        }

        /// <summary>
        /// ファイル名取得関数
        /// </summary>
        private void extractMediaFileName()
        {
            string eachFileName = string.Empty;
            int i = 0;

            ///パスの中からメディアファイル名を取得する
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
            foreach (string str in mediaFileName)
            {
                MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.Rows.Add(str);
            }
        }

        /// <summary>
        /// データグリッドクリックイベント関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_MouseUp(object sender, EventArgs e)
        {
            ///選択行の番号を取得する
            selectecMediaFileIndex = MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.CurrentRow.Index;

            ///選択ファイル名の表をする
            displaySelectedFileName(_mediaPlayer.fileNameDisplayDataGrid.Rows[selectecMediaFileIndex].Cells[0].Value.ToString());
        }

        /// <summary>
        /// 再生ボタン関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaPlayButton_Click(object sender, EventArgs e)
        {
            ///再生状態の判定をする
            if (playState == mediaPlayState.STOP)
            {
                mediaPlay();
            }
            else if (playState == mediaPlayState.PLAY)
            {
                mediaStop();
            }
        }

        /// <summary>
        /// メディア再生関数
        /// </summary>
        private void mediaPlay()
        {
            ///音楽の再生を実施する
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = files[selectecMediaFileIndex];
            player.controls.play();

            ///停止マークの表示をする
            controls[(int)mediaControls.PLAYSTOP].Text = "▮▮";

            ///再生する
            playState = mediaPlayState.PLAY;
        }

        /// <summary>
        /// メディア停止関数
        /// </summary>
        private void mediaStop()
        {
            ///音楽の停止を実施する
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = files[selectecMediaFileIndex];
            player.controls.stop();

            ///再生マークの表示をする
            controls[(int)mediaControls.PLAYSTOP].Text = "▶";

            ///停止する
            playState = mediaPlayState.STOP;
        }

        /// <summary>
        /// 次ファイルの選択関数
        /// </summary>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ///選択番号をカウントダウンする
            selectecMediaFileIndex++;

            ///データグリッド列の下限に達した場合
            if (selectecMediaFileIndex >= mediaFileName.Count)
            {
                selectecMediaFileIndex--;
                return;
            }

            ///次ファイルのデータグリッドを選択する
            MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.CurrentRow.Selected = false;
            MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.Rows[selectecMediaFileIndex].Selected = true;

            ///選択ファイル名の表をする
            displaySelectedFileName(_mediaPlayer.fileNameDisplayDataGrid.Rows[selectecMediaFileIndex].Cells[0].Value.ToString());
        }

        /// <summary>
        /// 前ファイルの選択関数
        /// </summary>
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            ///選択番号をカウントダウンする
            selectecMediaFileIndex--;

            ///データグリッド列の上限に達した場合
            if (selectecMediaFileIndex < 0)
            {
                selectecMediaFileIndex++;
                return;
            }

            ///前ファイルのデータグリッドを選択する
            MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.CurrentRow.Selected = false;
            MediaPlayer.mediaPlayer.fileNameDisplayDataGrid.Rows[selectecMediaFileIndex].Selected = true;

            ///選択ファイル名の表をする
            displaySelectedFileName(_mediaPlayer.fileNameDisplayDataGrid.Rows[selectecMediaFileIndex].Cells[0].Value.ToString());
        }

        /// <summary>
        /// 選択ファイル名を表示関数
        /// </summary>
        /// <param name="selectedFfileName">[in]</param>
        private void displaySelectedFileName(string selectedFfileName)
        {
            ///ファイル名の表示をする
            MediaPlayer.mediaPlayer.selectedFileNameLabel.Text = selectedFfileName;
        }
    }
}
