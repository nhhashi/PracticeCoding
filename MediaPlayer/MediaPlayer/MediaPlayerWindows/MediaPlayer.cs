using MediaPlayer.MediaPlayerWindows;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class MediaPlayer : Form
    {
        /// MediaPlayerインスタンス
        public static MediaPlayer mediaPlayer;

        /// コントロール群
        public DataGridView fileNameDisplayDataGrid;     ///表示用データグリッド
        public Label selectedFileNameLabel;                          ///ラベル

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MediaPlayer()
        {
            InitializeComponent();

            mediaPlayer = this;

            ///コントロールを格納する
            fileNameDisplayDataGrid = FileNameDisplayDataGrid;
            selectedFileNameLabel = SelectedFileName;

            ///MediaPlayerViewControllerインスタンスを生成する
            MediaPlayerViewController _MediaPlayerViewController = new MediaPlayerViewController(this);
        }
    }
}
