using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessLibrary;

namespace Chess
{
    public partial class MainWindow : Window
    {

        private string name;
        private int _column;
        private int _row;
        ChessFigures figures = null;
        bool state = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button _btn = sender as Button;
            if (_btn.Background == null) { }
            state = !state;
            _row = (int)_btn.GetValue(Grid.RowProperty) + 1;
            _column = (int)_btn.GetValue(Grid.ColumnProperty) + 1;

            if (state)
            {
                name = _btn.Name;
                Fabrika(name, _column, _row);
            }
            else
            {
                MessageBox.Show($"{figures.Move(_column, _row)} \n row {_row} column {_column}");
            }
        }

        private void Fabrika(string _name, int x, int y)
        {
            switch (_name)
            {
                case "King":
                    figures = new King(x, y);
                    //figures.Move();
                    break;
                case "Queen":
                    figures = new Queen(x, y);
                    break;
                case "Bishop":
                    figures = new Bishop(x, y);
                    break;
                case "Knight":
                    figures = new Knight(x, y);
                    break;
                case "Rook":
                    figures = new Rook(x, y);
                    break;
                case "Pawn":
                    figures = new Pawn(x, y);
                    break;
            }
        }
    }
}
