using MediaPlayer.FileControllers;
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
        /// コントロール群
        /// </summary>
        public DataGridView fileNameDisplayDataGrid;     ///表示用データグリッド
        public Label selectedFileNameLabel;                          ///ラベル

        public MediaPlayer()
        {
            InitializeComponent();

        }
    }
}
