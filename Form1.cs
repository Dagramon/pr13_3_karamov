﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract13_3_karamov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;
        private DataGridViewColumn dataGridViewColumn5 = null;
        private DataGridViewColumn dataGridViewColumn6 = null;
        private SortedDictionary<int, Computer> Computers = new SortedDictionary<int, Computer>();
        private List<int> numbers = new List<int>();
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.Columns.Add(getDataGridViewColumn6());
            dataGridView1.AutoResizeColumns();
        }
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (int i in Computers.Keys)
            {
                Computer computer = Computers[i];
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell6 = new
                DataGridViewTextBoxCell();
                cell1.ValueType = typeof(int);
                cell1.Value = computer.Number;
                cell2.ValueType = typeof(string);
                cell2.Value = computer.Name;
                cell3.ValueType = typeof(string);
                cell3.Value = computer.System;
                cell4.ValueType = typeof(string);
                cell4.Value = computer.CPU;
                cell5.ValueType = typeof(string);
                cell5.Value = computer.GPU;
                cell6.ValueType = typeof(int);
                cell6.Value = computer.OZU;
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                dataGridView1.Rows.Add(row);
            }
        }
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Номер";
                dataGridViewColumn1.ValueType = typeof(int);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Имя пользователя";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Система";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }
        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Процессор";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn4;
        }
        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Видеокарта";
                dataGridViewColumn5.ValueType = typeof(string);
                dataGridViewColumn5.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn5;
        }
        private DataGridViewColumn getDataGridViewColumn6()
        {
            if (dataGridViewColumn6 == null)
            {
                dataGridViewColumn6 = new DataGridViewTextBoxColumn();
                dataGridViewColumn6.Name = "";
                dataGridViewColumn6.HeaderText = "Память";
                dataGridViewColumn6.ValueType = typeof(int);
                dataGridViewColumn6.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn6;
        }
        private void addComputer(int number, string name, string system, string cpu, string gpu, int ozu)
        {
            if (numbers.Contains(number) == false)
            {
                numbers.Add(number);
                Computer computer = new Computer();
                Computers.Add(number, computer);
                computer.Number = number;
                computer.Name = name;
                computer.System = system;
                computer.CPU = cpu;
                computer.GPU = gpu;
                computer.OZU = ozu;
            }
            else
            {
                MessageBox.Show("Такой номер компьютера уже существует");
            }
            showListInGrid();
        }
        private void deleteComputer(int index)
        {
            Computers.Remove(index);
            numbers.Remove(numbers[index]);
            showListInGrid();
        }
        private void redactComputer(int index, int number, string name, string system, string cpu, string gpu, int ozu)
        {
            Computers[index].Number = number;
            Computers[index].Name = name;
            Computers[index].System = system;
            Computers[index].CPU = cpu;
            Computers[index].GPU = gpu;
            Computers[index].OZU = ozu;
            showListInGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                try
                {
                    addComputer(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown3.Value));
                }
                catch
                {
                    MessageBox.Show("Неверный формат данных");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex + 1;
            DialogResult dr = MessageBox.Show("Удалить компьютер?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                deleteComputer(selectedRow);
            }
        }
        private void РедактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridView1.SelectedCells[0].RowIndex + 1;
                numericUpDown1.Value = Computers[selectedRow].Number;
                textBox1.Text = Computers[selectedRow].Name;
                comboBox1.Text = Computers[selectedRow].System;
                textBox2.Text = Computers[selectedRow].CPU;
                textBox3.Text = Computers[selectedRow].GPU;
                numericUpDown1.Value = Computers[selectedRow].OZU;
                button1.Visible = false;
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex + 1;
            try
            {
                redactComputer(selectedRow, Convert.ToInt32(numericUpDown1.Value), textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown3.Value));
                MessageBox.Show("Данные о компьютере изменены");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = false;
            button2.Enabled = false;
        }
    }
}
