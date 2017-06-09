﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Maszyna.Models;
using System.Drawing;

namespace Maszyna.Forms
{
    public partial class MainForm : Window, IObserver<TuringElement<List<String>>>
    {
        private TabPage _simulationTabPage = null;
        private TuringMachine _turingMachine = new TuringMachine();
        private const byte ReservedColumns = 1;
        private const byte TabPagesWithoutSimulationTab = 1;

        public MainForm() : base("Symulator Maszyny Turinga")
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HideSimulationTabPage();
            UpdateEmptySymbolInformationForGUI(null, null);
            UpdateTable();
            UpdateFirstStateColor();
            comboBoxHead.SelectedIndex = 0;
        }

        public void OnCompleted() { }

        public void OnError(Exception ex)
        {
            ProgramMessageBox.showError(ex.Message);
        }

        public void OnNext(TuringElement<List<String>> receivedElement)
        {
            if (receivedElement.Element == TuringMachineModifiedElements.EntrySymbols)
                _turingMachine.Symbols = receivedElement.Values;
            else if (receivedElement.Element == TuringMachineModifiedElements.FinalStates)
                _turingMachine.FinalStates = receivedElement.Values;
            TriggerConfigurationChanges(null, null);
        }

        private void FirstStateChanges(object sender, EventArgs e)
        {
            TriggerConfigurationChanges(sender, e);
            ResetFontForHeaders();
            UpdateFirstStateColor();
        }

        private void UpdateFirstStateColor()
        {
            int columnIndexToChange = ((int)numericUpDownFirstStateNumber.Value) + ReservedColumns;
            if (columnIndexToChange < dataGridViewTable.Columns.Count)
            {
                Font actualFont = dataGridViewTable.ColumnHeadersDefaultCellStyle.Font;
                dataGridViewTable.Columns[columnIndexToChange].HeaderCell.Style.Font = new Font(actualFont, FontStyle.Bold);
            }
        }

        private void ResetFontForHeaders()
        {
            foreach (DataGridViewColumn column in dataGridViewTable.Columns)
                column.HeaderCell.Style.Font = dataGridViewTable.ColumnHeadersDefaultCellStyle.Font;
        }

        private void StateNumbersChanged(object sender, EventArgs e)
        {
            SetMaximumAvailableBeginningStateNumber();
            TriggerConfigurationChanges(sender, e);
            UpdateTableColumns();
        }

        private void UpdateTable()
        {
            UpdateTableColumns();
            UpdateTableRows();
        }

        private void UpdateTableRows()
        {
            dataGridViewTable.Rows.Clear();
            if (_turingMachine.EmptySymbol!=' ')
                AddRowWithSymbol(_turingMachine.EmptySymbol);
            AddAvailableSymbolRows();
            dataGridViewTable.Refresh();
        }

        private void AddAvailableSymbolRows()
        {
            foreach (var symbol in _turingMachine.Symbols)
                AddRowWithSymbol(symbol[0]);
        }

        private void AddRowWithSymbol(char symbol)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridViewTable.Rows.Add(row);
            int lastRowIndex = dataGridViewTable.Rows.Count - 1;
            dataGridViewTable.Rows[lastRowIndex].Cells[0].Value = symbol;
        }

        private void UpdateTableColumns()
        {
            int demandedNumberOfColumns = (int)numericUpDownStateNumbers.Value;
            int actualNumberOfColumns = dataGridViewTable.Columns.Count - ReservedColumns;
            int columnsToManipulate = (int)Math.Abs(demandedNumberOfColumns - actualNumberOfColumns);
            if (actualNumberOfColumns > demandedNumberOfColumns)
                RemoveColumns(columnsToManipulate);
            else
                AddColumns(columnsToManipulate);
            dataGridViewTable.Refresh();
        }

        private void AddColumns(int columnsToAdd)
        {
            const byte MaxInputLengthForElement = 32;
            for (int i = 0; i < columnsToAdd; i++)
            {
                DataGridViewTextBoxColumn columnToAdd = new DataGridViewTextBoxColumn();
                columnToAdd.HeaderText = "q" + (dataGridViewTable.Columns.Count-1);
                columnToAdd.MaxInputLength = MaxInputLengthForElement;
                dataGridViewTable.Columns.Add(columnToAdd);
            }
        }

        private void RemoveColumns(int columnsToRemove)
        {
            for (int i = 1; i <= columnsToRemove; i++)
                dataGridViewTable.Columns.RemoveAt(dataGridViewTable.Columns.Count - i);
        }

        private void UpdateEmptySymbolInformationForGUI(object sender, EventArgs e)
        {
            String errorText = textBoxEmptySymbol.Text.Length != 1 ? "Brak symbolu" : null;
            errorProvider.SetError(textBoxEmptySymbol, errorText);
        }

        private void TriggerConfigurationChanges(object sender, EventArgs e)
        {
            UpdateTuringMachine();
            UpdateFormulation();
            UpdateTableRows();
            SetConfigurationStatus();
            UnlockOrLockTabWithSimulation();
        }

        private void UnlockOrLockTabWithSimulation()
        {
            bool isSimulationTabAdded = tabControl.TabPages.Count != TabPagesWithoutSimulationTab;
            if (ConfigModel.ShouldSimulationTabBeVisible(_turingMachine) && !isSimulationTabAdded)
            {
                _turingMachine.GenerateTransitionsFromPotential();
                tabControl.TabPages.Add(_simulationTabPage);
            }
            else
                HideSimulationTabPage();
        }

        private void UpdateTuringMachine()
        {
            char emptySymbol = textBoxEmptySymbol.Text.Length == 1 ? textBoxEmptySymbol.Text[0] : ' ';
            _turingMachine.EmptySymbol = emptySymbol;
            _turingMachine.NumberOfStates = (int)numericUpDownStateNumbers.Value;
            _turingMachine.FirstStateIndex = (int)numericUpDownFirstStateNumber.Value;
            _turingMachine.HeadPosition = comboBoxHead.SelectedText == "Lewa" ? 
                TuringHeadPosition.FirstSymbolFromLeft : TuringHeadPosition.FirstSymbolFromRight;
            _turingMachine.Symbols.Remove(_turingMachine.EmptySymbol.ToString());
        }

        private void UpdateFormulation()
        {
            labelFormalForInput.Text = ConfigModel.GenerateFormalSymbols(_turingMachine);
        }

        private void SetConfigurationStatus()
        {
            toolStripStatusLabelConfigStatus.Text = ConfigModel.GenerateConditionsToShowSimulationTab(_turingMachine);
        }

        private void ShowSimulationTabPage()
        {
            if (_simulationTabPage != null)
                tabControl.TabPages.Insert(1, _simulationTabPage);
        }

        private void HideSimulationTabPage()
        {
            _simulationTabPage = _simulationTabPage ?? tabPageSimulation;
            tabControl.TabPages.Remove(_simulationTabPage);
        }

        private void SetMaximumAvailableBeginningStateNumber()
        {
            const byte ShiftForStateNumberIndexing = 1;
            numericUpDownFirstStateNumber.Maximum = numericUpDownStateNumbers.Value - ShiftForStateNumberIndexing;
        }

        private void buttonEntrySymbols_Click(object sender, EventArgs e)
        {
            EntrySymbolForm symbolForm = new EntrySymbolForm(_turingMachine.Symbols);
            symbolForm.Show();
            symbolForm.Subscribe(this);
        }

        private void buttonFinalStates_Click(object sender, EventArgs e)
        {
            FinalStatesForm finalStatesForm = new FinalStatesForm(_turingMachine.FinalStates);
            finalStatesForm.Show();
            finalStatesForm.Subscribe(this);
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            if (!Validator.AreEntryDataForMachineValid(textBoxEnter.Text, _turingMachine))
                ProgramMessageBox.showError("Dane wejściowe zawierają niedopuszczalne symbole.");
            else if (textBoxEnter.Text.Length==0)
                ProgramMessageBox.showError("Taśma jest pusta.");
            else
            {
                ProgramResult result = _turingMachine.ExecuteProgram(textBoxEnter.Text);
                textBoxExit.Text = result.Tape;
                textBoxState.Text = result.FinishedStateSymbol;
            }
        }

        private List<PotentialTransition> generatePotentialTransitions()
        {
            List<PotentialTransition> potentialTransitions = new List<PotentialTransition>();
            foreach (DataGridViewRow row in dataGridViewTable.Rows)
            {
                for (int i = ReservedColumns; i < dataGridViewTable.Columns.Count; i++)
                {
                    String cellValue = getCellValue(row.Cells[i]);
                    String entrySymbol = getCellValue(row.Cells[0]);
                    char entrySymbolToPass = entrySymbol.Length == 1 ? entrySymbol[0] : ' ';
                    int actualStateNumber = i - ReservedColumns;
                    PotentialTransition potentialTransition = new PotentialTransition(cellValue, actualStateNumber, entrySymbolToPass);
                    potentialTransitions.Add(potentialTransition);
                }
            }
            return potentialTransitions;
        }

        private String getCellValue(DataGridViewCell cell)
        {
            return cell.Value == null ? "" : cell.Value.ToString();
        }

        private void UpdateStateTable(object sender, DataGridViewCellEventArgs e)
        {
            _turingMachine.PotentialTransitions = generatePotentialTransitions();
            SetConfigurationStatus();
            UnlockOrLockTabWithSimulation();
        }
    }
}
