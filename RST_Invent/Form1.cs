using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace RST_Invest
{
    public partial class Form1 : Form
    {
        private Validator _validator;
        private struct Guides
        {
            // all guides in percentage
            public static int Top = 5;
            public static int LeftMiddle = 25;
            public static int RightMiddle = 75;
            public static int Shift = 2;
            public static int GridWidth = 44;
            public static int InputWidth = 30;
            public static int NameColumn = 70;
            public static int ButtonSpace = 10;
            
        }
        public Form1()
        {
            var currentExePath = AppDomain.CurrentDomain.BaseDirectory;
            _validator = new Validator(string.Concat(currentExePath,"nomenclature.json"));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeFlex();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeFlex();
        }

        private void ResizeFlex()
        {
            int level1;
            int level2;
            int level3;
            int level4;
            double level5;
            var leftMiddle = ClientRectangle.Width * Guides.LeftMiddle / 100;
            var rightMiddle = ClientRectangle.Width * Guides.RightMiddle / 100;
            //Acceptacne lable
            var left = leftMiddle - AcceptanceInputLabel.Width / 2;
            level1 = ClientRectangle.Height * Guides.Top / 100;            
            AcceptanceInputLabel.Location = new Point(left,level1);
            //Acceptance input
            AcceptanceInputTextBox.Width = ClientRectangle.Width * Guides.InputWidth / 100;
            left = leftMiddle - AcceptanceInputTextBox.Width / 2;
            level2 = ShiftRelate(AcceptanceInputLabel);            
            AcceptanceInputTextBox.Location= new Point(left,level2);
            //Acceptance grid label
            left = leftMiddle - AcceptanceGridLabel.Width / 2;
            level3 = ShiftRelate(AcceptanceInputTextBox);            
            AcceptanceGridLabel.Location = new Point(left,level3);
            //Acceptance Grid            
            AcceptanceDataGrid.Width = ClientRectangle.Width * Guides.GridWidth / 100;            
            AcceptanceDataGrid.Columns[0].Width = AcceptanceDataGrid.ClientSize.Width * Guides.NameColumn / 100;
            var dd = AcceptanceDataGrid.ClientSize.Width;
            AcceptanceDataGrid.Columns[1].Width = AcceptanceDataGrid.ClientSize.Width - AcceptanceDataGrid.Columns[0].Width;
            left = leftMiddle - AcceptanceDataGrid.Width / 2;
            level4 = ShiftRelate(AcceptanceGridLabel);
            AcceptanceDataGrid.Location = new Point(left, level4);
            level5 = ClientRectangle.Height - ClientRectangle.Height * ((double)Guides.ButtonSpace / (double)100); ;
            AcceptanceDataGrid.Height = (int)level5 - level4;


            //Shipping input lable
            left = rightMiddle - ShipmentInputLabel.Width / 2;            
            ShipmentInputLabel.Location = new Point(left,level1);
            // Shipping input
            ShipmentTextBox.Width = AcceptanceInputTextBox.Width;
            left = rightMiddle - ShipmentTextBox.Width/2;
            ShipmentTextBox.Location = new Point(left,level2);
            // Shipment grid label
            left = rightMiddle - ShipmentGridLabel.Width;
            ShipmentGridLabel.Location = new Point(left,level3);
            // Shipment grid
            ShipmentDataGrid.Width = AcceptanceDataGrid.Width;
            ShipmentDataGrid.Columns[0].Width = AcceptanceDataGrid.Columns[0].Width;
            ShipmentDataGrid.Columns[1].Width = AcceptanceDataGrid.Columns[1].Width;
            left = rightMiddle - ShipmentDataGrid.Width / 2;
            ShipmentDataGrid.Location = new Point(left,level4);
            ShipmentDataGrid.Height = AcceptanceDataGrid.Height;

            //buttom
            var butLevel = AcceptanceDataGrid.Location.Y + AcceptanceDataGrid.Height + (ClientRectangle.Height * Guides.Shift / 100);
            ResetButton.Location = new Point(AcceptanceDataGrid.Location.X, butLevel);

            //Calculate down shif relating  `ctrl`
            int ShiftRelate(Control ctrl)
            {
                return ctrl.Location.Y + ctrl.Height + (ClientRectangle.Height * Guides.Shift / 100);
            }
        }     

        private void ReduceInGrid(DataGridView grid, string key)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    var value = row.Cells[0].Value;
                    if (value != null && value.Equals(key))
                    {
                        var countCell = grid.Rows[row.Index].Cells[1];
                        var count = Int32.Parse(countCell.Value.ToString()!);
                        if (count == 1)
                        {
                            grid.Rows.Remove(row);
                            return;
                        }
                        else
                        {                            
                            count--;
                            countCell.Value = count;
                            return;
                        }
                    }                                    
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"error in `ReduceInGrid` method {ex.Message}");
            }
        }
        private void IncreaseInGrid(DataGridView grid, string key)
        {
            try
            {                
                foreach (DataGridViewRow row in grid.Rows)
                {
                    var value = row.Cells[0].Value;                    
                    if (value != null && value.Equals(key))
                    {
                        var countCell = grid.Rows[row.Index].Cells[1];
                        var count = Int32.Parse(countCell.Value.ToString()!);
                        count++;
                        countCell.Value = count;
                        return;
                    }                    
                }
                grid.Rows.Add(key, 1);                
            }
            catch (Exception ex) 
            {
                Console.Error.WriteLine($"error in `IncreaseInGrid` method {ex.Message}");
            }                    
        }

        private void AcceptanceInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                // Suppress the key press (to disable sound)
                e.SuppressKeyPress = true;

                var list = textBox.Text.Split(" ").ToList();
                textBox.Text = string.Empty;
                foreach (var item in list)
                {
                    if (_validator.Validate(item))
                    {
                        IncreaseInGrid(AcceptanceDataGrid, item);
                        ReduceInGrid(ShipmentDataGrid, item);
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            AcceptanceDataGrid.Rows.Clear();
            ShipmentDataGrid.Rows.Clear();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int selectionStart = textBox.SelectionStart; // Save cursor position
            textBox.Text = textBox.Text.ToUpper(); // Convert text to uppercase
            textBox.SelectionStart = selectionStart; // Restore cursor position
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suppress the key press
                e.SuppressKeyPress = true;
            }
        }
        private void ShipmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                // Suppress the key press (to disable sound)
                e.SuppressKeyPress = true;

                var list = textBox.Text.Split(" ").ToList();
                textBox.Text = string.Empty;
                foreach (var item in list)
                {
                    if (_validator.Validate(item))
                    {
                        IncreaseInGrid(ShipmentDataGrid, item);
                        ReduceInGrid(AcceptanceDataGrid, item);
                    }
                }
            }                      
        }
    }
}
