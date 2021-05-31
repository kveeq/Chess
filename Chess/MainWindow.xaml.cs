using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private string name_prev;
        private int _column;
        private int _row;
        ChessFigures figures = null;
        bool state = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private MaterialDesignThemes.Wpf.PackIcon take_element(string name)
        {
            MaterialDesignThemes.Wpf.PackIcon[] icons = new MaterialDesignThemes.Wpf.PackIcon[32] { Ic_PawnB1, Ic_PawnB2, Ic_PawnB3, Ic_PawnB4, Ic_PawnB5, Ic_PawnB6, Ic_PawnB7, Ic_PawnB8, Ic_RookB1, Ic_RookB2, Ic_KnightB1, Ic_KnightB2, Ic_BishopB1, Ic_BishopB2, Ic_QueenB0, Ic_KingB0, Ic_PawnW1, Ic_PawnW2, Ic_PawnW3, Ic_PawnW4, Ic_PawnW5, Ic_PawnW6, Ic_PawnW7, Ic_PawnW8, Ic_RookW1, Ic_RookW2, Ic_KnightW1, Ic_KnightW2, Ic_BishopW1, Ic_BishopW2, Ic_QueenW0, Ic_KingW0 };
            MaterialDesignThemes.Wpf.PackIcon name_icon = Ic_PawnB1;
            foreach (var item in icons)
            {
                if (item.Name.ToString() == name)
                {
                    name_icon = item;
                    break;
                }

            }
            return name_icon;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // передвигать только картинку и имя кнопки которая нажата, еще сздать кнопку которая будет хранить предыдущую кнопку

            Button _btn = sender as Button;
            Button btn_prev = new Button();
            state = !state;
            _row = (int)_btn.GetValue(Grid.RowProperty);
            _column = (int)_btn.GetValue(Grid.ColumnProperty);

            if (state)
            {
                name = _btn.Name.ToString();
                Fabrika(name, _column, _row);
            }
            else
            {
                if (figures.Move(_column, _row))
                {
                    //if(_btn.Name == "" || _btn.Name == null)
                    //{
                    _btn.Name = name;
                    //btn_prev.Name = name_prev;
                    //btn_prev.Name = "";
                    //btn_prev = _btn;
                    Grid.SetRow(take_element("Ic_" + name), _row);
                    Grid.SetColumn(take_element("Ic_" + name), _column);
                    //}
                    //else if(_btn.Name[_btn.Name.Length - 2] != btn_prev.Name[btn_prev.Name.Length - 2])
                    //{
                    //    var a = take_element("Ic_" + name_prev);
                    //    a.Kind = new MaterialDesignThemes.Wpf.PackIconKind();
                    //}
                }
                else
                {
                    MessageBox.Show($"{figures.Move(_column, _row)} \n row {_row} column {_column}");

                }
            }
        }

        private void Fabrika(string _name, int x, int y)
        {
            switch (_name.Replace("White_", "").Remove(_name.Length - 2))
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

        //bool CanEat;

        //private void CheckEat (Button btn, Button btn_prev)
        //{
        //    if (btn.Name[btn.Name.Length-2] != btn.Name[btn.Name.Length - 2])
        //    {

        //    }

        //}
    }
}
