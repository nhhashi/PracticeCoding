
namespace MediaPlayer
{
    partial class MediaPlayer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameDisplayDataGrid = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectedFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FileNameDisplayDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameDisplayDataGrid
            // 
            this.FileNameDisplayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileNameDisplayDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName});
            this.FileNameDisplayDataGrid.Location = new System.Drawing.Point(12, 68);
            this.FileNameDisplayDataGrid.Name = "FileNameDisplayDataGrid";
            this.FileNameDisplayDataGrid.RowHeadersVisible = false;
            this.FileNameDisplayDataGrid.RowTemplate.Height = 21;
            this.FileNameDisplayDataGrid.Size = new System.Drawing.Size(360, 247);
            this.FileNameDisplayDataGrid.TabIndex = 0;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "名前";
            this.fileName.Name = "fileName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SelectedFileName);
            this.panel1.Location = new System.Drawing.Point(12, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 117);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.Location = new System.Drawing.Point(34, 15);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(35, 12);
            this.SelectedFileName.TabIndex = 0;
            this.SelectedFileName.Text = "label1";
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileNameDisplayDataGrid);
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.FileNameDisplayDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FileNameDisplayDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SelectedFileName;
    }
}

