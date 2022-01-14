using MediaPlayer.FileControllers;
using MediaPlayer.MediaPlayerWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class MediaPlayer : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public static MediaPlayer mediaPlayer;

        /// <summary>
        /// コントロール群
        /// </summary>
        public DataGridView fileNameDisplayDataGrid;     ///表示用データグリッド
        public Label selectedFileNameLabel;                          ///ラベル

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MediaPlayer()
        {
            InitializeComponent();

            ///
            mediaPlayer = this;

            ///コントロールを格納する
            fileNameDisplayDataGrid = FileNameDisplayDataGrid;
            selectedFileNameLabel = SelectedFileName;

            ///MediaPlayerViewControllerインスタンスを生成する
            MediaPlayerViewController _MediaPlayerViewController = new MediaPlayerViewController(this);
        }
    }
}
