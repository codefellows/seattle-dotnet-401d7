using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Position
    {
		public int Row { get; set; }
		public int Column { get; set; }

		/// <summary>
		/// Position on the gameboard being initialized 
		/// </summary>
		/// <param name="row">row number</param>
		/// <param name="column">column number</param>
		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}
	}
}
