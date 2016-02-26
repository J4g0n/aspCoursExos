using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public class Taquin
    {
        int N = 3;
        public int xEmptyCell;
        public int yEmptyCell;
        
        List<String> taquinBoard = new List<String>();

        public Taquin()
        {
            Init();
            Shuffle();
        }

        public void Init()
        {
            char c = 'A';
            for (int i = 0; i < NumberCells() - 1; i++, c++)
            {
                taquinBoard.Add(c.ToString());
            }
            taquinBoard.Add("#");
            xEmptyCell = 2;
            xEmptyCell = 2;
        }

        public void Shuffle()
        {
            Random genRand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int index = (int) (genRand.NextDouble() * NumberCells());
                String firstElement = taquinBoard.First();
              
                taquinBoard.RemoveAt(0);
                taquinBoard.Insert(index, firstElement);

                if (firstElement == "#")
                {
                    xEmptyCell = index % N;
                    xEmptyCell = NumberCells() - xEmptyCell;
                }
            }
        }

        public int NumberCells()
        {
            return N * N;
        }

        public int NumberColumns()
        {
            return N;
        }

        public int NumberRows()
        {
            return N;
        }

        public String GetCell(int x, int y)
        {
            return taquinBoard.ElementAt(x * N + y);
        }
    }


    public partial class Exercice220 : System.Web.UI.Page
    {
        static Taquin taquin = new Taquin();
        static string selectedCell = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable();
        }

        protected void CreateTable()
        {
            for (int cell = 0; cell < taquin.NumberRows(); cell++)
            {
                TableRow tableRow = new TableRow();
                for (int cell2 = 0; cell2 < taquin.NumberColumns(); cell2++)
                {
                    TableCell tableCell = new TableCell();
                    /*Button buttonCell = new Button();
                    buttonCell.Click += new EventHandler(
                        this.TableCellClicked(tableCell, cell, cell2);*/
                    tableCell.Text = taquin.GetCell(cell, cell2);
                    tableRow.Cells.Add(tableCell);
                }
                taquinBoard.Rows.Add(tableRow);
            }
        }

        protected void TableCellClicked(TableCell tableCell, int row, int column)
        {
            if (!(selectedCell == "") && (selectedCell != "#"))
            {
                selectedCell = "";
            }
        }
    }
}