namespace Wifi_Passwords
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNetworkName = new System.Windows.Forms.Label();
            this.labelNetworkKey = new System.Windows.Forms.Label();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.WifiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WifiKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNetworkName
            // 
            this.labelNetworkName.AutoSize = true;
            this.labelNetworkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNetworkName.ForeColor = System.Drawing.Color.White;
            this.labelNetworkName.Location = new System.Drawing.Point(8, 9);
            this.labelNetworkName.Name = "labelNetworkName";
            this.labelNetworkName.Size = new System.Drawing.Size(222, 32);
            this.labelNetworkName.TabIndex = 1;
            this.labelNetworkName.Text = "Название сети";
            // 
            // labelNetworkKey
            // 
            this.labelNetworkKey.AutoSize = true;
            this.labelNetworkKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNetworkKey.ForeColor = System.Drawing.Color.White;
            this.labelNetworkKey.Location = new System.Drawing.Point(231, 9);
            this.labelNetworkKey.Name = "labelNetworkKey";
            this.labelNetworkKey.Size = new System.Drawing.Size(89, 32);
            this.labelNetworkKey.TabIndex = 2;
            this.labelNetworkKey.Text = "Ключ";
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AllowUserToResizeColumns = false;
            this.mainGrid.AllowUserToResizeRows = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.mainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.ColumnHeadersVisible = false;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WifiName,
            this.WifiKey});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.mainGrid.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.mainGrid.Location = new System.Drawing.Point(12, 32);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.ReadOnly = true;
            this.mainGrid.RowHeadersVisible = false;
            this.mainGrid.RowHeadersWidth = 72;
            this.mainGrid.Size = new System.Drawing.Size(273, 279);
            this.mainGrid.TabIndex = 3;
            // 
            // WifiName
            // 
            this.WifiName.HeaderText = "Название сети";
            this.WifiName.MinimumWidth = 9;
            this.WifiName.Name = "WifiName";
            this.WifiName.ReadOnly = true;
            this.WifiName.Width = 9;
            // 
            // WifiKey
            // 
            this.WifiKey.HeaderText = "Ключ";
            this.WifiKey.MinimumWidth = 9;
            this.WifiKey.Name = "WifiKey";
            this.WifiKey.ReadOnly = true;
            this.WifiKey.Width = 9;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(108, 41);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(126, 32);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "Ошибка";
            this.labelError.Visible = false;
            // 
            // labelErrorText
            // 
            this.labelErrorText.AutoSize = true;
            this.labelErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorText.ForeColor = System.Drawing.Color.White;
            this.labelErrorText.Location = new System.Drawing.Point(23, 70);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(207, 32);
            this.labelErrorText.TabIndex = 5;
            this.labelErrorText.Text = "Текст ошибки";
            this.labelErrorText.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(297, 323);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.labelNetworkKey);
            this.Controls.Add(this.labelNetworkName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Wifi_Passwords.Properties.Resources.wifi_symbol_in_a_circle_icon_icons_com_56446;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WI-FI Passwords";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNetworkName;
        private System.Windows.Forms.Label labelNetworkKey;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn WifiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WifiKey;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorText;
    }
}

