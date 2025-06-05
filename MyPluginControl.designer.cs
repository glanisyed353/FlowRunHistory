﻿namespace MyXrmToolBoxTool1
{
    partial class PowerAutomateHistory
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerAutomateHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.getFlowsListButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.getFlowRunHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SessionFilterLbl = new System.Windows.Forms.ToolStripLabel();
            this.filterDateBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.filterStatusBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gridFlowExecutionHistory = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlowExecutionHistory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSeparator1,
            this.getFlowsListButton,
            this.toolStripSeparator1,
            this.getFlowRunHistoryButton,
            this.tsbClose,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.SessionFilterLbl,
            this.filterDateBox,
            this.toolStripSeparator5,
            this.filterStatusBox,
            this.toolStripSeparator3,
            this.toolStripLabel1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(2264, 39);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // getFlowsListButton
            // 
            this.getFlowsListButton.BackColor = System.Drawing.SystemColors.Window;
            this.getFlowsListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getFlowsListButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFlowsListButton.Image = ((System.Drawing.Image)(resources.GetObject("getFlowsListButton.Image")));
            this.getFlowsListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getFlowsListButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.getFlowsListButton.Margin = new System.Windows.Forms.Padding(5);
            this.getFlowsListButton.Name = "getFlowsListButton";
            this.getFlowsListButton.Size = new System.Drawing.Size(133, 29);
            this.getFlowsListButton.Text = "Load Flows";
            this.getFlowsListButton.Click += new System.EventHandler(this.GetPowerAutomateFlowsListButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // getFlowRunHistoryButton
            // 
            this.getFlowRunHistoryButton.BackColor = System.Drawing.SystemColors.Window;
            this.getFlowRunHistoryButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFlowRunHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("getFlowRunHistoryButton.Image")));
            this.getFlowRunHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getFlowRunHistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getFlowRunHistoryButton.Margin = new System.Windows.Forms.Padding(5);
            this.getFlowRunHistoryButton.Name = "getFlowRunHistoryButton";
            this.getFlowRunHistoryButton.Size = new System.Drawing.Size(175, 29);
            this.getFlowRunHistoryButton.Text = "Retrieve Session";
            this.getFlowRunHistoryButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbClose.BackColor = System.Drawing.SystemColors.Window;
            this.tsbClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbClose.Margin = new System.Windows.Forms.Padding(5);
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(159, 29);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(247, 36);
            this.toolStripLabel2.Text = "🛠️ Author: Shafi Muhammad SHAH";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // SessionFilterLbl
            // 
            this.SessionFilterLbl.BackColor = System.Drawing.SystemColors.Window;
            this.SessionFilterLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SessionFilterLbl.Image = ((System.Drawing.Image)(resources.GetObject("SessionFilterLbl.Image")));
            this.SessionFilterLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SessionFilterLbl.Name = "SessionFilterLbl";
            this.SessionFilterLbl.Size = new System.Drawing.Size(78, 36);
            this.SessionFilterLbl.Text = "Filter";
            // 
            // filterDateBox
            // 
            this.filterDateBox.BackColor = System.Drawing.SystemColors.Info;
            this.filterDateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDateBox.DropDownWidth = 121;
            this.filterDateBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.filterDateBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.filterDateBox.IntegralHeight = false;
            this.filterDateBox.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "Last 7 Days",
            "Last 15 Days",
            "Last 30 Days",
            "All Sessions"});
            this.filterDateBox.Name = "filterDateBox";
            this.filterDateBox.Size = new System.Drawing.Size(160, 39);
            this.filterDateBox.SelectedIndexChanged += new System.EventHandler(this.filterDateBox_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // filterStatusBox
            // 
            this.filterStatusBox.BackColor = System.Drawing.SystemColors.Info;
            this.filterStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterStatusBox.DropDownWidth = 121;
            this.filterStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.filterStatusBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.filterStatusBox.IntegralHeight = false;
            this.filterStatusBox.Items.AddRange(new object[] {
            "Successful",
            "Failed",
            "All"});
            this.filterStatusBox.Name = "filterStatusBox";
            this.filterStatusBox.Size = new System.Drawing.Size(160, 39);
            this.filterStatusBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(147, 36);
            this.toolStripLabel1.Text = "Total Sessions: 0";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 12);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(765, 1046);
            this.checkedListBox1.TabIndex = 16;
            // 
            // gridFlowExecutionHistory
            // 
            this.gridFlowExecutionHistory.AllowUserToAddRows = false;
            this.gridFlowExecutionHistory.AllowUserToDeleteRows = false;
            this.gridFlowExecutionHistory.AllowUserToResizeRows = false;
            this.gridFlowExecutionHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFlowExecutionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridFlowExecutionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFlowExecutionHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridFlowExecutionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFlowExecutionHistory.Location = new System.Drawing.Point(805, 12);
            this.gridFlowExecutionHistory.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gridFlowExecutionHistory.Name = "gridFlowExecutionHistory";
            this.gridFlowExecutionHistory.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFlowExecutionHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridFlowExecutionHistory.RowHeadersVisible = false;
            this.gridFlowExecutionHistory.RowHeadersWidth = 51;
            this.gridFlowExecutionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFlowExecutionHistory.ShowEditingIcon = false;
            this.gridFlowExecutionHistory.Size = new System.Drawing.Size(1446, 1063);
            this.gridFlowExecutionHistory.TabIndex = 17;
            this.gridFlowExecutionHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFlowExecutionHistory_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.gridFlowExecutionHistory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2264, 1087);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // PowerAutomateHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PowerAutomateHistory";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(2264, 1126);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlowExecutionHistory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton getFlowsListButton;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton getFlowRunHistoryButton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView gridFlowExecutionHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox filterStatusBox;
        private System.Windows.Forms.ToolStripLabel SessionFilterLbl;
        private System.Windows.Forms.ToolStripComboBox filterDateBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}
