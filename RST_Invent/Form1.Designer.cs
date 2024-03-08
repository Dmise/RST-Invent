





namespace RST_Invest
{
    partial class Form1
    {
        private Button ResetButton;
        private Label AcceptanceInputLabel;
        private Label ShipmentInputLabel;
        private DataGridView AcceptanceDataGrid;
        private DataGridView ShipmentDataGrid;
        private DataGridViewTextBoxColumn ItemNameColumn;        
        private DataGridViewTextBoxColumn CountColumn;
        private DataGridViewTextBoxColumn ShipmnetItemNameColumn;
        private DataGridViewTextBoxColumn ShipmnetItemCountColumn;
        private TextBox AcceptanceInputTextBox;
        private TextBox ShipmentTextBox;
        private Label AcceptanceGridLabel;
        private Label ShipmentGridLabel;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AcceptanceInputLabel = new Label();
            AcceptanceInputTextBox = new TextBox();
            AcceptanceGridLabel = new Label();
            AcceptanceDataGrid = new DataGridView();
            ItemNameColumn = new DataGridViewTextBoxColumn();
            CountColumn = new DataGridViewTextBoxColumn();
            ShipmentInputLabel = new Label();
            ShipmentTextBox = new TextBox();
            ShipmentGridLabel = new Label();
            ShipmentDataGrid = new DataGridView();
            ShipmnetItemNameColumn = new DataGridViewTextBoxColumn();
            ShipmnetItemCountColumn = new DataGridViewTextBoxColumn();
            ResetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AcceptanceDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // AcceptanceInputLabel
            // 
            AcceptanceInputLabel.AutoSize = true;
            AcceptanceInputLabel.Location = new Point(100, 29);
            AcceptanceInputLabel.Name = "AcceptanceInputLabel";
            AcceptanceInputLabel.Size = new Size(232, 20);
            AcceptanceInputLabel.TabIndex = 1;
            AcceptanceInputLabel.Text = "Поле ввода данных для приема";
            // 
            // AcceptanceInputTextBox
            // 
            AcceptanceInputTextBox.Location = new Point(100, 67);
            AcceptanceInputTextBox.Name = "AcceptanceInputTextBox";
            AcceptanceInputTextBox.Size = new Size(229, 27);
            AcceptanceInputTextBox.TabIndex = 5;
            AcceptanceInputTextBox.KeyDown += AcceptanceInputTextBox_KeyDown;
            AcceptanceInputTextBox.TextChanged += TextBox_TextChanged;
            // 
            // AcceptanceGridLabel
            // 
            AcceptanceGridLabel.AutoSize = true;
            AcceptanceGridLabel.Location = new Point(100, 100);
            AcceptanceGridLabel.Name = "AcceptanceGridLabel";
            AcceptanceGridLabel.Size = new Size(60, 20);
            AcceptanceGridLabel.TabIndex = 7;
            AcceptanceGridLabel.Text = "ПРИЕМ";
            // 
            // AcceptanceDataGrid
            // 
            AcceptanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AcceptanceDataGrid.Columns.AddRange(new DataGridViewColumn[] { ItemNameColumn, CountColumn });
            AcceptanceDataGrid.Location = new Point(31, 123);
            AcceptanceDataGrid.Name = "AcceptanceDataGrid";
            AcceptanceDataGrid.RowHeadersVisible = false;
            AcceptanceDataGrid.RowHeadersWidth = 51;
            AcceptanceDataGrid.ScrollBars = ScrollBars.Vertical;
            AcceptanceDataGrid.Size = new Size(400, 200);
            AcceptanceDataGrid.TabIndex = 3;
            // 
            // ItemNameColumn
            // 
            ItemNameColumn.HeaderText = "Наименование";
            ItemNameColumn.MinimumWidth = 6;
            ItemNameColumn.Name = "ItemNameColumn";
            ItemNameColumn.Width = 125;
            // 
            // CountColumn
            // 
            CountColumn.HeaderText = "Количество";
            CountColumn.MinimumWidth = 6;
            CountColumn.Name = "CountColumn";
            CountColumn.Width = 125;
            // 
            // ShipmentInputLabel
            // 
            ShipmentInputLabel.AutoSize = true;
            ShipmentInputLabel.Location = new Point(533, 20);
            ShipmentInputLabel.Name = "ShipmentInputLabel";
            ShipmentInputLabel.Size = new Size(238, 20);
            ShipmentInputLabel.TabIndex = 2;
            ShipmentInputLabel.Text = "Поле ввода данных для отгрузки";
            // 
            // ShipmentTextBox
            // 
            ShipmentTextBox.Location = new Point(533, 61);
            ShipmentTextBox.Name = "ShipmentTextBox";
            ShipmentTextBox.Size = new Size(196, 27);
            ShipmentTextBox.TabIndex = 5;
            ShipmentTextBox.KeyDown += ShipmentTextBox_KeyDown;
            ShipmentTextBox.TextChanged += TextBox_TextChanged;
            // 
            // ShipmentGridLabel
            // 
            ShipmentGridLabel.AutoSize = true;
            ShipmentGridLabel.Location = new Point(582, 100);
            ShipmentGridLabel.Name = "ShipmentGridLabel";
            ShipmentGridLabel.Size = new Size(79, 20);
            ShipmentGridLabel.TabIndex = 2;
            ShipmentGridLabel.Text = "ОТГРУЗКА";
            // 
            // ShipmentDataGrid
            // 
            ShipmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShipmentDataGrid.Columns.AddRange(new DataGridViewColumn[] { ShipmnetItemNameColumn, ShipmnetItemCountColumn });
            ShipmentDataGrid.Location = new Point(460, 123);
            ShipmentDataGrid.Name = "ShipmentDataGrid";
            ShipmentDataGrid.RowHeadersVisible = false;
            ShipmentDataGrid.RowHeadersWidth = 51;
            ShipmentDataGrid.ScrollBars = ScrollBars.Vertical;
            ShipmentDataGrid.Size = new Size(400, 200);
            ShipmentDataGrid.TabIndex = 6;
            // 
            // ShipmnetItemNameColumn
            // 
            ShipmnetItemNameColumn.HeaderText = "Наименование";
            ShipmnetItemNameColumn.MinimumWidth = 6;
            ShipmnetItemNameColumn.Name = "ShipmnetItemNameColumn";
            ShipmnetItemNameColumn.Width = 125;
            // 
            // ShipmnetItemCountColumn
            // 
            ShipmnetItemCountColumn.HeaderText = "Количество";
            ShipmnetItemCountColumn.MinimumWidth = 6;
            ShipmnetItemCountColumn.Name = "ShipmnetItemCountColumn";
            ShipmnetItemCountColumn.Width = 125;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(31, 329);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 0;
            ResetButton.Text = "Очистить";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 400);
            Controls.Add(ShipmentDataGrid);
            Controls.Add(AcceptanceInputTextBox);
            Controls.Add(ShipmentTextBox);
            Controls.Add(AcceptanceDataGrid);
            Controls.Add(ShipmentGridLabel);
            Controls.Add(ShipmentInputLabel);
            Controls.Add(AcceptanceGridLabel);
            Controls.Add(AcceptanceInputLabel);
            Controls.Add(ResetButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Справочник номенклатуры";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)AcceptanceDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
