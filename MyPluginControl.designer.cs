namespace MyXrmToolBoxTool1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(1698, 38);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 38);
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
            this.getFlowsListButton.Size = new System.Drawing.Size(225, 28);
            this.getFlowsListButton.Text = "Load Power Automate Flows";
            this.getFlowsListButton.Click += new System.EventHandler(this.GetPowerAutomateFlowsListButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
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
            this.getFlowRunHistoryButton.Size = new System.Drawing.Size(240, 28);
            this.getFlowRunHistoryButton.Text = "Retrieve Selected Flow Session";
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
            this.tsbClose.Size = new System.Drawing.Size(131, 28);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(195, 35);
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
            this.SessionFilterLbl.Size = new System.Drawing.Size(66, 35);
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
            this.filterDateBox.Size = new System.Drawing.Size(121, 38);
            this.filterDateBox.SelectedIndexChanged += new System.EventHandler(this.filterDateBox_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
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
            this.filterStatusBox.Size = new System.Drawing.Size(121, 38);
            this.filterStatusBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 35);
            this.toolStripLabel1.Text = "Total Sessions: 0";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 10);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(574, 857);
            this.checkedListBox1.TabIndex = 16;
            // 
            // gridFlowExecutionHistory
            // 
            this.gridFlowExecutionHistory.AllowUserToAddRows = false;
            this.gridFlowExecutionHistory.AllowUserToDeleteRows = false;
            this.gridFlowExecutionHistory.AllowUserToResizeRows = false;
            this.gridFlowExecutionHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFlowExecutionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFlowExecutionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFlowExecutionHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridFlowExecutionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFlowExecutionHistory.Location = new System.Drawing.Point(604, 10);
            this.gridFlowExecutionHistory.Margin = new System.Windows.Forms.Padding(10);
            this.gridFlowExecutionHistory.Name = "gridFlowExecutionHistory";
            this.gridFlowExecutionHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFlowExecutionHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFlowExecutionHistory.RowHeadersVisible = false;
            this.gridFlowExecutionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFlowExecutionHistory.ShowEditingIcon = false;
            this.gridFlowExecutionHistory.Size = new System.Drawing.Size(1084, 857);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1698, 877);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // PowerAutomateHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PowerAutomateHistory";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1698, 915);
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
