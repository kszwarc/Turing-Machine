﻿namespace Maszyna.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorkerProgram = new System.ComponentModel.BackgroundWorker();
            this.timerForProgram = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogForConfig = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogForConfig = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.pictureBoxActualSymbol = new System.Windows.Forms.PictureBox();
            this.pictureBoxActualState = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownExecutionTime = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBoxManualTable = new System.Windows.Forms.CheckBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.dataGridViewTable = new Maszyna.Forms.DataGridViewWithPaste();
            this.Symbols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHead = new System.Windows.Forms.Label();
            this.comboBoxHead = new System.Windows.Forms.ComboBox();
            this.buttonFinalStates = new System.Windows.Forms.Button();
            this.labelFinalStates = new System.Windows.Forms.Label();
            this.buttonEntrySymbols = new System.Windows.Forms.Button();
            this.labelEntrySymbols = new System.Windows.Forms.Label();
            this.labelFormalForInput = new System.Windows.Forms.Label();
            this.labelFormal = new System.Windows.Forms.Label();
            this.statusStripConfig = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConfigStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDownFirstStateNumber = new System.Windows.Forms.NumericUpDown();
            this.labelBeginningState = new System.Windows.Forms.Label();
            this.numericUpDownStateNumbers = new System.Windows.Forms.NumericUpDown();
            this.labelStateNumbers = new System.Windows.Forms.Label();
            this.textBoxEmptySymbol = new System.Windows.Forms.TextBox();
            this.labelEmptySymbol = new System.Windows.Forms.Label();
            this.tabPageSimulation = new System.Windows.Forms.TabPage();
            this.richTextBoxExit = new System.Windows.Forms.RichTextBox();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.dataGridViewActualTuring = new Maszyna.Forms.DataGridViewWithPaste();
            this.buttonStepNextWithTape = new System.Windows.Forms.Button();
            this.buttonStepNext = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActualSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActualState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecutionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.statusStripConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstStateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStateNumbers)).BeginInit();
            this.tabPageSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActualTuring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorkerProgram
            // 
            this.backgroundWorkerProgram.WorkerReportsProgress = true;
            this.backgroundWorkerProgram.WorkerSupportsCancellation = true;
            this.backgroundWorkerProgram.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProgram_DoWork);
            this.backgroundWorkerProgram.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerProgram_ProgressChanged);
            // 
            // timerForProgram
            // 
            this.timerForProgram.Interval = 10000;
            this.timerForProgram.Tick += new System.EventHandler(this.timerForProgram_Tick);
            // 
            // openFileDialogForConfig
            // 
            this.openFileDialogForConfig.FileName = "Algorytm.dat";
            this.openFileDialogForConfig.Filter = "Data File | *.dat|All files|*.*";
            // 
            // saveFileDialogForConfig
            // 
            this.saveFileDialogForConfig.FileName = "Algorytm.dat";
            this.saveFileDialogForConfig.Filter = "Data File | *.dat|All files|*.*";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoad,
            this.toolStripButtonSave});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(911, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "Wczytaj konfigurację";
            this.toolStripButtonLoad.ToolTipText = "Wczytaj konfigurację (ctrl+o)";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Zapisz konfigurację";
            this.toolStripButtonSave.ToolTipText = "Zapisz konfigurację (ctrl+s)";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageConfig);
            this.tabControl.Controls.Add(this.tabPageSimulation);
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(908, 580);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.AutoScroll = true;
            this.tabPageConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageConfig.Controls.Add(this.pictureBoxActualSymbol);
            this.tabPageConfig.Controls.Add(this.pictureBoxActualState);
            this.tabPageConfig.Controls.Add(this.label2);
            this.tabPageConfig.Controls.Add(this.label1);
            this.tabPageConfig.Controls.Add(this.numericUpDownExecutionTime);
            this.tabPageConfig.Controls.Add(this.labelTime);
            this.tabPageConfig.Controls.Add(this.checkBoxManualTable);
            this.tabPageConfig.Controls.Add(this.labelTable);
            this.tabPageConfig.Controls.Add(this.dataGridViewTable);
            this.tabPageConfig.Controls.Add(this.labelHead);
            this.tabPageConfig.Controls.Add(this.comboBoxHead);
            this.tabPageConfig.Controls.Add(this.buttonFinalStates);
            this.tabPageConfig.Controls.Add(this.labelFinalStates);
            this.tabPageConfig.Controls.Add(this.buttonEntrySymbols);
            this.tabPageConfig.Controls.Add(this.labelEntrySymbols);
            this.tabPageConfig.Controls.Add(this.labelFormalForInput);
            this.tabPageConfig.Controls.Add(this.labelFormal);
            this.tabPageConfig.Controls.Add(this.statusStripConfig);
            this.tabPageConfig.Controls.Add(this.numericUpDownFirstStateNumber);
            this.tabPageConfig.Controls.Add(this.labelBeginningState);
            this.tabPageConfig.Controls.Add(this.numericUpDownStateNumbers);
            this.tabPageConfig.Controls.Add(this.labelStateNumbers);
            this.tabPageConfig.Controls.Add(this.textBoxEmptySymbol);
            this.tabPageConfig.Controls.Add(this.labelEmptySymbol);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(900, 554);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Konfiguracja maszyny";
            // 
            // pictureBoxActualSymbol
            // 
            this.pictureBoxActualSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxActualSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxActualSymbol.Location = new System.Drawing.Point(333, 256);
            this.pictureBoxActualSymbol.Name = "pictureBoxActualSymbol";
            this.pictureBoxActualSymbol.Size = new System.Drawing.Size(71, 15);
            this.pictureBoxActualSymbol.TabIndex = 11122;
            this.pictureBoxActualSymbol.TabStop = false;
            this.pictureBoxActualSymbol.Click += new System.EventHandler(this.pictureBoxActualSymbol_Click);
            // 
            // pictureBoxActualState
            // 
            this.pictureBoxActualState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxActualState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxActualState.Location = new System.Drawing.Point(333, 231);
            this.pictureBoxActualState.Name = "pictureBoxActualState";
            this.pictureBoxActualState.Size = new System.Drawing.Size(71, 15);
            this.pictureBoxActualState.TabIndex = 11121;
            this.pictureBoxActualState.TabStop = false;
            this.pictureBoxActualState.Click += new System.EventHandler(this.pictureBoxActualState_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(167, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 11120;
            this.label2.Text = "Kolor aktualnego symbolu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(164, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 11119;
            this.label1.Text = "Kolor aktualnego przejścia:";
            // 
            // numericUpDownExecutionTime
            // 
            this.numericUpDownExecutionTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownExecutionTime.Location = new System.Drawing.Point(334, 195);
            this.numericUpDownExecutionTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownExecutionTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExecutionTime.Name = "numericUpDownExecutionTime";
            this.numericUpDownExecutionTime.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownExecutionTime.TabIndex = 7;
            this.numericUpDownExecutionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownExecutionTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(153, 187);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(164, 30);
            this.labelTime.TabIndex = 11118;
            this.labelTime.Text = "Maksymalny czas wykonania\r\nprogramu [ms]:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxManualTable
            // 
            this.checkBoxManualTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxManualTable.AutoSize = true;
            this.checkBoxManualTable.Location = new System.Drawing.Point(382, 290);
            this.checkBoxManualTable.Name = "checkBoxManualTable";
            this.checkBoxManualTable.Size = new System.Drawing.Size(154, 17);
            this.checkBoxManualTable.TabIndex = 8;
            this.checkBoxManualTable.Text = "Ręczny zapis tabeli stanów";
            this.checkBoxManualTable.UseVisualStyleBackColor = true;
            this.checkBoxManualTable.CheckedChanged += new System.EventHandler(this.checkBoxManualTable_CheckedChanged);
            // 
            // labelTable
            // 
            this.labelTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTable.Location = new System.Drawing.Point(235, 310);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(431, 15);
            this.labelTable.TabIndex = 11116;
            this.labelTable.Text = "Format zapisu w tabeli stanów: stan/symbol/kierunek (L, P, -) lub stan końcowy";
            this.labelTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTable.Visible = false;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbols});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTable.Location = new System.Drawing.Point(3, 330);
            this.dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTable.Size = new System.Drawing.Size(894, 196);
            this.dataGridViewTable.TabIndex = 11115;
            this.dataGridViewTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellClick);
            this.dataGridViewTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateStateTable);
            // 
            // Symbols
            // 
            this.Symbols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symbols.HeaderText = "Σ\\Q";
            this.Symbols.MaxInputLength = 1;
            this.Symbols.Name = "Symbols";
            this.Symbols.ReadOnly = true;
            // 
            // labelHead
            // 
            this.labelHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHead.Location = new System.Drawing.Point(202, 165);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(115, 15);
            this.labelHead.TabIndex = 11114;
            this.labelHead.Text = "Lokalizacja głowicy:";
            // 
            // comboBoxHead
            // 
            this.comboBoxHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHead.FormattingEnabled = true;
            this.comboBoxHead.Items.AddRange(new object[] {
            "Lewa",
            "Prawa"});
            this.comboBoxHead.Location = new System.Drawing.Point(333, 164);
            this.comboBoxHead.Name = "comboBoxHead";
            this.comboBoxHead.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHead.TabIndex = 6;
            this.comboBoxHead.SelectedIndexChanged += new System.EventHandler(this.HeadConfigurationUpdate);
            // 
            // buttonFinalStates
            // 
            this.buttonFinalStates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFinalStates.Location = new System.Drawing.Point(333, 135);
            this.buttonFinalStates.Name = "buttonFinalStates";
            this.buttonFinalStates.Size = new System.Drawing.Size(71, 23);
            this.buttonFinalStates.TabIndex = 5;
            this.buttonFinalStates.Text = "Dodaj";
            this.buttonFinalStates.UseVisualStyleBackColor = true;
            this.buttonFinalStates.Click += new System.EventHandler(this.buttonFinalStates_Click);
            // 
            // labelFinalStates
            // 
            this.labelFinalStates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFinalStates.AutoSize = true;
            this.labelFinalStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFinalStates.Location = new System.Drawing.Point(225, 138);
            this.labelFinalStates.Name = "labelFinalStates";
            this.labelFinalStates.Size = new System.Drawing.Size(92, 15);
            this.labelFinalStates.TabIndex = 11113;
            this.labelFinalStates.Text = "Stany końcowe:";
            // 
            // buttonEntrySymbols
            // 
            this.buttonEntrySymbols.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEntrySymbols.Location = new System.Drawing.Point(334, 48);
            this.buttonEntrySymbols.Name = "buttonEntrySymbols";
            this.buttonEntrySymbols.Size = new System.Drawing.Size(70, 23);
            this.buttonEntrySymbols.TabIndex = 2;
            this.buttonEntrySymbols.Text = "Dodaj";
            this.buttonEntrySymbols.UseVisualStyleBackColor = true;
            this.buttonEntrySymbols.Click += new System.EventHandler(this.buttonEntrySymbols_Click);
            // 
            // labelEntrySymbols
            // 
            this.labelEntrySymbols.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEntrySymbols.AutoSize = true;
            this.labelEntrySymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEntrySymbols.Location = new System.Drawing.Point(199, 51);
            this.labelEntrySymbols.Name = "labelEntrySymbols";
            this.labelEntrySymbols.Size = new System.Drawing.Size(118, 15);
            this.labelEntrySymbols.TabIndex = 9;
            this.labelEntrySymbols.Text = "Symbole wejściowe:";
            // 
            // labelFormalForInput
            // 
            this.labelFormalForInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFormalForInput.AutoSize = true;
            this.labelFormalForInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFormalForInput.Location = new System.Drawing.Point(535, 61);
            this.labelFormalForInput.Name = "labelFormalForInput";
            this.labelFormalForInput.Size = new System.Drawing.Size(0, 15);
            this.labelFormalForInput.TabIndex = 8;
            // 
            // labelFormal
            // 
            this.labelFormal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFormal.AutoSize = true;
            this.labelFormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFormal.Location = new System.Drawing.Point(535, 34);
            this.labelFormal.Name = "labelFormal";
            this.labelFormal.Size = new System.Drawing.Size(109, 15);
            this.labelFormal.TabIndex = 7;
            this.labelFormal.Text = "M=<Q,Σ,Γ,δ,q,B,F>";
            // 
            // statusStripConfig
            // 
            this.statusStripConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConfigStatus});
            this.statusStripConfig.Location = new System.Drawing.Point(3, 529);
            this.statusStripConfig.Name = "statusStripConfig";
            this.statusStripConfig.Size = new System.Drawing.Size(894, 22);
            this.statusStripConfig.TabIndex = 6;
            // 
            // toolStripStatusLabelConfigStatus
            // 
            this.toolStripStatusLabelConfigStatus.Name = "toolStripStatusLabelConfigStatus";
            this.toolStripStatusLabelConfigStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // numericUpDownFirstStateNumber
            // 
            this.numericUpDownFirstStateNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownFirstStateNumber.Location = new System.Drawing.Point(333, 109);
            this.numericUpDownFirstStateNumber.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownFirstStateNumber.Name = "numericUpDownFirstStateNumber";
            this.numericUpDownFirstStateNumber.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownFirstStateNumber.TabIndex = 4;
            this.numericUpDownFirstStateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFirstStateNumber.ValueChanged += new System.EventHandler(this.FirstStateChanges);
            // 
            // labelBeginningState
            // 
            this.labelBeginningState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBeginningState.AutoSize = true;
            this.labelBeginningState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeginningState.Location = new System.Drawing.Point(217, 109);
            this.labelBeginningState.Name = "labelBeginningState";
            this.labelBeginningState.Size = new System.Drawing.Size(101, 15);
            this.labelBeginningState.TabIndex = 4;
            this.labelBeginningState.Text = "Stan początkowy:";
            // 
            // numericUpDownStateNumbers
            // 
            this.numericUpDownStateNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownStateNumbers.Location = new System.Drawing.Point(333, 77);
            this.numericUpDownStateNumbers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStateNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStateNumbers.Name = "numericUpDownStateNumbers";
            this.numericUpDownStateNumbers.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownStateNumbers.TabIndex = 3;
            this.numericUpDownStateNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownStateNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStateNumbers.ValueChanged += new System.EventHandler(this.StateNumbersChanged);
            // 
            // labelStateNumbers
            // 
            this.labelStateNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStateNumbers.AutoSize = true;
            this.labelStateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStateNumbers.Location = new System.Drawing.Point(231, 77);
            this.labelStateNumbers.Name = "labelStateNumbers";
            this.labelStateNumbers.Size = new System.Drawing.Size(88, 15);
            this.labelStateNumbers.TabIndex = 2;
            this.labelStateNumbers.Text = "Liczba stanów:";
            // 
            // textBoxEmptySymbol
            // 
            this.textBoxEmptySymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmptySymbol.Location = new System.Drawing.Point(334, 22);
            this.textBoxEmptySymbol.MaxLength = 1;
            this.textBoxEmptySymbol.Name = "textBoxEmptySymbol";
            this.textBoxEmptySymbol.Size = new System.Drawing.Size(70, 20);
            this.textBoxEmptySymbol.TabIndex = 1;
            this.textBoxEmptySymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmptySymbol.TextChanged += new System.EventHandler(this.TriggerConfigurationChanges);
            this.textBoxEmptySymbol.Leave += new System.EventHandler(this.UpdateEmptySymbolInformationForGUI);
            // 
            // labelEmptySymbol
            // 
            this.labelEmptySymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmptySymbol.AutoSize = true;
            this.labelEmptySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmptySymbol.Location = new System.Drawing.Point(235, 23);
            this.labelEmptySymbol.Name = "labelEmptySymbol";
            this.labelEmptySymbol.Size = new System.Drawing.Size(82, 15);
            this.labelEmptySymbol.TabIndex = 11111;
            this.labelEmptySymbol.Text = "Symbol pusty:";
            // 
            // tabPageSimulation
            // 
            this.tabPageSimulation.AutoScroll = true;
            this.tabPageSimulation.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSimulation.Controls.Add(this.richTextBoxExit);
            this.tabPageSimulation.Controls.Add(this.textBoxEnter);
            this.tabPageSimulation.Controls.Add(this.dataGridViewActualTuring);
            this.tabPageSimulation.Controls.Add(this.buttonStepNextWithTape);
            this.tabPageSimulation.Controls.Add(this.buttonStepNext);
            this.tabPageSimulation.Controls.Add(this.labelState);
            this.tabPageSimulation.Controls.Add(this.textBoxState);
            this.tabPageSimulation.Controls.Add(this.buttonSimulate);
            this.tabPageSimulation.Controls.Add(this.labelExit);
            this.tabPageSimulation.Controls.Add(this.labelEnter);
            this.tabPageSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSimulation.Name = "tabPageSimulation";
            this.tabPageSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimulation.Size = new System.Drawing.Size(900, 554);
            this.tabPageSimulation.TabIndex = 1;
            this.tabPageSimulation.Text = "Symulacja";
            // 
            // richTextBoxExit
            // 
            this.richTextBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxExit.Location = new System.Drawing.Point(8, 94);
            this.richTextBoxExit.Name = "richTextBoxExit";
            this.richTextBoxExit.ReadOnly = true;
            this.richTextBoxExit.Size = new System.Drawing.Size(886, 20);
            this.richTextBoxExit.TabIndex = 2;
            this.richTextBoxExit.Text = "";
            this.richTextBoxExit.TextChanged += new System.EventHandler(this.richTextBoxExit_TextChanged);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnter.Location = new System.Drawing.Point(8, 40);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(886, 20);
            this.textBoxEnter.TabIndex = 1;
            this.textBoxEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewActualTuring
            // 
            this.dataGridViewActualTuring.AllowUserToAddRows = false;
            this.dataGridViewActualTuring.AllowUserToDeleteRows = false;
            this.dataGridViewActualTuring.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActualTuring.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewActualTuring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActualTuring.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewActualTuring.Location = new System.Drawing.Point(0, 279);
            this.dataGridViewActualTuring.Name = "dataGridViewActualTuring";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActualTuring.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewActualTuring.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewActualTuring.Size = new System.Drawing.Size(902, 275);
            this.dataGridViewActualTuring.TabIndex = 11;
            // 
            // buttonStepNextWithTape
            // 
            this.buttonStepNextWithTape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStepNextWithTape.Location = new System.Drawing.Point(520, 208);
            this.buttonStepNextWithTape.Name = "buttonStepNextWithTape";
            this.buttonStepNextWithTape.Size = new System.Drawing.Size(75, 56);
            this.buttonStepNextWithTape.TabIndex = 10;
            this.buttonStepNextWithTape.Text = "Pojedynczy krok z nową taśmą";
            this.buttonStepNextWithTape.UseVisualStyleBackColor = true;
            this.buttonStepNextWithTape.Click += new System.EventHandler(this.buttonStepNextWithTape_Click);
            // 
            // buttonStepNext
            // 
            this.buttonStepNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStepNext.Enabled = false;
            this.buttonStepNext.Location = new System.Drawing.Point(413, 208);
            this.buttonStepNext.Name = "buttonStepNext";
            this.buttonStepNext.Size = new System.Drawing.Size(75, 56);
            this.buttonStepNext.TabIndex = 9;
            this.buttonStepNext.Text = "Pojedynczy krok";
            this.buttonStepNext.UseVisualStyleBackColor = true;
            this.buttonStepNext.Click += new System.EventHandler(this.buttonStepNext_Click);
            // 
            // labelState
            // 
            this.labelState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.259F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelState.Location = new System.Drawing.Point(409, 170);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(82, 15);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "Stan końcowy";
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxState.Location = new System.Drawing.Point(413, 147);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(75, 20);
            this.textBoxState.TabIndex = 2;
            this.textBoxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSimulate.Location = new System.Drawing.Point(310, 208);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(75, 56);
            this.buttonSimulate.TabIndex = 8;
            this.buttonSimulate.Text = "Wykonaj cały program";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // labelExit
            // 
            this.labelExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.259F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExit.Location = new System.Drawing.Point(398, 117);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(103, 15);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "Taśma wyjściowa";
            // 
            // labelEnter
            // 
            this.labelEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.259F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnter.Location = new System.Drawing.Point(397, 63);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(105, 15);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "Taśma wejściowa";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 612);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActualSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActualState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecutionTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.statusStripConfig.ResumeLayout(false);
            this.statusStripConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstStateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStateNumbers)).EndInit();
            this.tabPageSimulation.ResumeLayout(false);
            this.tabPageSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActualTuring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageSimulation;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstStateNumber;
        private System.Windows.Forms.Label labelBeginningState;
        private System.Windows.Forms.NumericUpDown numericUpDownStateNumbers;
        private System.Windows.Forms.Label labelStateNumbers;
        private System.Windows.Forms.TextBox textBoxEmptySymbol;
        private System.Windows.Forms.Label labelEmptySymbol;
        private System.Windows.Forms.StatusStrip statusStripConfig;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConfigStatus;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelFormalForInput;
        private System.Windows.Forms.Label labelFormal;
        private System.Windows.Forms.Button buttonFinalStates;
        private System.Windows.Forms.Label labelFinalStates;
        private System.Windows.Forms.Button buttonEntrySymbols;
        private System.Windows.Forms.Label labelEntrySymbols;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.ComboBox comboBoxHead;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbols;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonStepNext;
        private System.Windows.Forms.CheckBox checkBoxManualTable;
        private DataGridViewWithPaste dataGridViewTable;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgram;
        private System.Windows.Forms.Timer timerForProgram;
        private System.Windows.Forms.Button buttonStepNextWithTape;
        private System.Windows.Forms.NumericUpDown numericUpDownExecutionTime;
        private System.Windows.Forms.Label labelTime;
        private DataGridViewWithPaste dataGridViewActualTuring;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogForConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialogForConfig;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.RichTextBox richTextBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxActualSymbol;
        private System.Windows.Forms.PictureBox pictureBoxActualState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

