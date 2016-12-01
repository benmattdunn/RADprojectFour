namespace RADassignmentFour
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectMainTableLayoutPanel.SuspendLayout();
            this.SelectionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectMainTableLayoutPanel
            // 
            this.SelectMainTableLayoutPanel.ColumnCount = 1;
            this.SelectMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectMainTableLayoutPanel.Controls.Add(this.SelectionTableLayoutPanel, 0, 2);
            this.SelectMainTableLayoutPanel.Controls.Add(this.ProductDataGridView, 0, 1);
            this.SelectMainTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.SelectMainTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.SelectMainTableLayoutPanel.Name = "SelectMainTableLayoutPanel";
            this.SelectMainTableLayoutPanel.RowCount = 3;
            this.SelectMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SelectMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectMainTableLayoutPanel.Size = new System.Drawing.Size(714, 387);
            this.SelectMainTableLayoutPanel.TabIndex = 0;
            // 
            // SelectionTableLayoutPanel
            // 
            this.SelectionTableLayoutPanel.ColumnCount = 4;
            this.SelectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTableLayoutPanel.Controls.Add(this.YourSelectionLabel, 0, 1);
            this.SelectionTableLayoutPanel.Controls.Add(this.SelectionTextBox, 1, 1);
            this.SelectionTableLayoutPanel.Controls.Add(this.CancelButton, 2, 1);
            this.SelectionTableLayoutPanel.Controls.Add(this.NextButton, 3, 1);
            this.SelectionTableLayoutPanel.Location = new System.Drawing.Point(3, 340);
            this.SelectionTableLayoutPanel.Name = "SelectionTableLayoutPanel";
            this.SelectionTableLayoutPanel.RowCount = 3;
            this.SelectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.SelectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.SelectionTableLayoutPanel.Size = new System.Drawing.Size(708, 44);
            this.SelectionTableLayoutPanel.TabIndex = 0;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(3, 5);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.YourSelectionLabel.Size = new System.Drawing.Size(76, 23);
            this.YourSelectionLabel.TabIndex = 0;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.Location = new System.Drawing.Point(103, 13);
            this.SelectionTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.ReadOnly = true;
            this.SelectionTextBox.Size = new System.Drawing.Size(402, 20);
            this.SelectionTextBox.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(511, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 28);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(611, 8);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 33);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.Size = new System.Drawing.Size(708, 301);
            this.ProductDataGridView.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(268, 20);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Dollar Computers HardWare List";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 412);
            this.ControlBox = false;
            this.Controls.Add(this.SelectMainTableLayoutPanel);
            this.Name = "SelectionForm";
            this.Text = "Selection Your Computer";
            this.SelectMainTableLayoutPanel.ResumeLayout(false);
            this.SelectMainTableLayoutPanel.PerformLayout();
            this.SelectionTableLayoutPanel.ResumeLayout(false);
            this.SelectionTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SelectMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel SelectionTableLayoutPanel;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label TitleLabel;
    }
}