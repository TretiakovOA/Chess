using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Chess.Model;
using ChessColor = Chess.Model.Color;

namespace Chess
{
    public partial class Form1 : Form
    {
        private ChessGame Game { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game = new ChessGame();
            InitBoard();
            DrawFigures();
        }

        private void InitBoard()
        {
            labelWhite.Visible = true;
            labelBlack.Visible = false;
            
            dgvBoard.RowCount = 8;
            dgvBoard.ColumnCount = 8;
            dgvBoard.RowHeadersWidth = 70;
            dgvBoard.ColumnHeadersHeight = 70;
            Font letterFont = new Font("Arial", 24, FontStyle.Bold);
            Font chessFont = new Font("Arial", 36, FontStyle.Bold);

            for (int i = 0; i < dgvBoard.RowCount; i++)
            {
                dgvBoard.Rows[i].Height = 70;
                dgvBoard.Rows[i].HeaderCell.Style.Font = letterFont;
                dgvBoard.Rows[i].HeaderCell.Value = (8 - i).ToString();
            }
            for (int j = 0; j < dgvBoard.ColumnCount; j++)
            {
                dgvBoard.Columns[j].Width = 70;
                dgvBoard.Columns[j].HeaderCell.Style.Font = letterFont;
                dgvBoard.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                int aCharNumber = (int) 'A';
                dgvBoard.Columns[j].HeaderCell.Value = ((char)(aCharNumber + j)).ToString();
            }
            for (int i = 0; i < dgvBoard.RowCount; i++)
            {
                for (int j = 0; j < dgvBoard.ColumnCount; j++)
                {
                    ChessColor chessColor = Game.Board.GetFieldColor(i, j);
                    dgvBoard.Rows[i].Cells[j].Style.BackColor = chessColor == ChessColor.BLACK
                        ? System.Drawing.Color.DarkGray
                        : System.Drawing.Color.WhiteSmoke;
                    dgvBoard.Rows[i].Cells[j].Style.Font = chessFont;
                }
            }
        }

        private void DrawFigures()
        {
            List<ChessFigure> whiteFigures = Game.WhitePlayer.Figures.Where(f => !f.IsKilled).ToList();
            List<ChessFigure> blackFigures = Game.BlackPlayer.Figures.Where(f => !f.IsKilled).ToList();
            foreach (var whiteFigure in whiteFigures)
            {
                ChessField field = whiteFigure.CurrentField;
                Tuple<int, int> indexes = field.GetIndexes();
                string symbol = whiteFigure.GetSymbol(ChessColor.WHITE).ToString();
                dgvBoard.Rows[indexes.Item1].Cells[indexes.Item2].Value = symbol;
            }
            foreach (var blackFigure in blackFigures)
            {
                ChessField field = blackFigure.CurrentField;
                Tuple<int, int> indexes = field.GetIndexes();
                string symbol = blackFigure.GetSymbol(ChessColor.BLACK).ToString();
                dgvBoard.Rows[indexes.Item1].Cells[indexes.Item2].Value = symbol;
            }
        }
    }
}
