namespace RADassignmentFour
{
    partial class OrderForm
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
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UpperLeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatFormTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.RightSideTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.YourPriveTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.LeftTableLayoutPanel.SuspendLayout();
            this.UpperLeftTableLayoutPanel.SuspendLayout();
            this.RightSideTableLayoutPanel.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(634, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Event);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Event);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainTableLayout.Controls.Add(this.SystemComponentsGroupBox, 0, 0);
            this.MainTableLayout.Controls.Add(this.RightSideTableLayoutPanel, 1, 0);
            this.MainTableLayout.Location = new System.Drawing.Point(13, 28);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(609, 327);
            this.MainTableLayout.TabIndex = 1;
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.LeftTableLayoutPanel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(328, 321);
            this.SystemComponentsGroupBox.TabIndex = 0;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Info";
            // 
            // LeftTableLayoutPanel
            // 
            this.LeftTableLayoutPanel.ColumnCount = 1;
            this.LeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftTableLayoutPanel.Controls.Add(this.UpperLeftTableLayoutPanel, 0, 0);
            this.LeftTableLayoutPanel.Location = new System.Drawing.Point(8, 19);
            this.LeftTableLayoutPanel.Name = "LeftTableLayoutPanel";
            this.LeftTableLayoutPanel.RowCount = 2;
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.LeftTableLayoutPanel.Size = new System.Drawing.Size(314, 296);
            this.LeftTableLayoutPanel.TabIndex = 1;
            // 
            // UpperLeftTableLayoutPanel
            // 
            this.UpperLeftTableLayoutPanel.ColumnCount = 4;
            this.UpperLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.UpperLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.UpperLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ConditionLabel, 0, 0);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ManufacturerLabel, 0, 1);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.PlatformLabel, 2, 0);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ModelLabel, 2, 1);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ConditionTextBox, 1, 0);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ManufacturerTextBox, 1, 1);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.PlatFormTextBox, 3, 0);
            this.UpperLeftTableLayoutPanel.Controls.Add(this.ModelTextBox, 3, 1);
            this.UpperLeftTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.UpperLeftTableLayoutPanel.Name = "UpperLeftTableLayoutPanel";
            this.UpperLeftTableLayoutPanel.RowCount = 2;
            this.UpperLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpperLeftTableLayoutPanel.Size = new System.Drawing.Size(308, 66);
            this.UpperLeftTableLayoutPanel.TabIndex = 0;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(3, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ConditionLabel.Size = new System.Drawing.Size(51, 18);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 33);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 18);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(167, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PlatformLabel.Size = new System.Drawing.Size(45, 18);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(167, 33);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ModelLabel.Size = new System.Drawing.Size(39, 18);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model ";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(83, 3);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(78, 20);
            this.ConditionTextBox.TabIndex = 4;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(83, 36);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(78, 20);
            this.ManufacturerTextBox.TabIndex = 5;
            // 
            // PlatFormTextBox
            // 
            this.PlatFormTextBox.Location = new System.Drawing.Point(227, 3);
            this.PlatFormTextBox.Name = "PlatFormTextBox";
            this.PlatFormTextBox.Size = new System.Drawing.Size(78, 20);
            this.PlatFormTextBox.TabIndex = 6;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(227, 36);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(78, 20);
            this.ModelTextBox.TabIndex = 7;
            // 
            // RightSideTableLayoutPanel
            // 
            this.RightSideTableLayoutPanel.ColumnCount = 1;
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSideTableLayoutPanel.Controls.Add(this.PriceGroupBox, 0, 1);
            this.RightSideTableLayoutPanel.Controls.Add(this.ProductPictureBox, 0, 0);
            this.RightSideTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.RightSideTableLayoutPanel.Location = new System.Drawing.Point(337, 3);
            this.RightSideTableLayoutPanel.Name = "RightSideTableLayoutPanel";
            this.RightSideTableLayoutPanel.RowCount = 3;
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(269, 321);
            this.RightSideTableLayoutPanel.TabIndex = 1;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.YourPriveTableLayoutPanel);
            this.PriceGroupBox.Location = new System.Drawing.Point(3, 172);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(263, 101);
            this.PriceGroupBox.TabIndex = 0;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // YourPriveTableLayoutPanel
            // 
            this.YourPriveTableLayoutPanel.ColumnCount = 2;
            this.YourPriveTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.YourPriveTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.YourPriveTableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.YourPriveTableLayoutPanel.Name = "YourPriveTableLayoutPanel";
            this.YourPriveTableLayoutPanel.RowCount = 3;
            this.YourPriveTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriveTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriveTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriveTableLayoutPanel.Size = new System.Drawing.Size(251, 76);
            this.YourPriveTableLayoutPanel.TabIndex = 0;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(168, 163);
            this.ProductPictureBox.TabIndex = 1;
            this.ProductPictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.BackButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cancelbutton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.FinishButton, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 33);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 27);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "BackButton";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.back_Event);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(88, 3);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(79, 27);
            this.Cancelbutton.TabIndex = 0;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Exit_Event);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(173, 3);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(79, 27);
            this.FinishButton.TabIndex = 0;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 367);
            this.ControlBox = false;
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.LeftTableLayoutPanel.ResumeLayout(false);
            this.UpperLeftTableLayoutPanel.ResumeLayout(false);
            this.UpperLeftTableLayoutPanel.PerformLayout();
            this.RightSideTableLayoutPanel.ResumeLayout(false);
            this.PriceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TableLayoutPanel LeftTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel UpperLeftTableLayoutPanel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatFormTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TableLayoutPanel RightSideTableLayoutPanel;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.TableLayoutPanel YourPriveTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button FinishButton;
    }
}