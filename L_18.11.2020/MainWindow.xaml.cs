using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace L_18._11._2020
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private DispatcherTimer timer;
       private Brush pressed;
       private Brush prevColor;
       private Brush prevColor_text_box;
        private double speed;
        private string text_test;
        private string checked_symbol;//для проверки совпадения символа
       private int i = 0;//для добавления вывода на текст блок
       private int counter_fails;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            pressed = new SolidColorBrush(Color.FromArgb(255, (byte)57, (byte)129, (byte)184));
            checked_symbol=string.Empty ;
           
            prevColor_text_box = TextBlockOut.Background;
           // speed = 2;
            this.buttonStop.IsEnabled = false;
                  
        }

        private void Check_button_pressed(string buttonSymbol)
        {
            if (checked_symbol == buttonSymbol)
            {
                this.TextBlockOut.Background = Brushes.Green;
            }
            else
            {
                this.TextBlockOut.Background = Brushes.Red;
                counter_fails++;
            }
        }


        /// <summary>
        ///Обработка нажатия люьбой кнопки нажатие вниз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.D1)
            {
                prevColor = this.Border1.Background;
                this.Border1.Background = pressed;
                this.Check_button_pressed("1");
               
            }
            if (e.Key==Key.Oem3)
            {
                prevColor = this.BorderTetta.Background;
                this.BorderTetta.Background = pressed;
                this.Check_button_pressed("`");
            }

            if (e.Key == Key.D2)
            {
                prevColor = this.Border2.Background;
                this.Border2.Background = pressed;
                this.Check_button_pressed("2");
                
            }
            if (e.Key == Key.D3)
            {
                prevColor = this.Border3.Background;
                this.Border3.Background = pressed;
                this.Check_button_pressed("3");
               
            }

            if (e.Key == Key.D4)
            {
                prevColor = this.Border4.Background;
                this.Border4.Background = pressed;
                this.Check_button_pressed("4");
               
            }
            if (e.Key == Key.D5)
            {
                prevColor = this.Border5.Background;
                this.Border5.Background = pressed;
                this.Check_button_pressed("5");
               
            }
            if (e.Key == Key.D6)
            {
                prevColor = this.Border6.Background;
                this.Border6.Background = pressed;
                this.Check_button_pressed("6");
               
            }
            if (e.Key == Key.D7)
            {
                prevColor = this.Border7.Background;
                this.Border7.Background = pressed;
                this.Check_button_pressed("7");
                
            }
            if (e.Key == Key.D8)
            {
                prevColor = this.Border8.Background;
                this.Border8.Background = pressed;
                this.Check_button_pressed("8");
               
            }
            if (e.Key == Key.D9)
            {
                prevColor = this.Border9.Background;
                this.Border9.Background = pressed;
                this.Check_button_pressed("9");
                
            }
            if (e.Key == Key.D0)
            {
                prevColor = this.Border0.Background;
                this.Border0.Background = pressed;
                this.Check_button_pressed("0");
               
            }
            if (e.Key == Key.OemMinus)
            {
                prevColor = this.BorderMinus.Background;
                this.BorderMinus.Background = pressed;
                this.Check_button_pressed("-");
               
            }
            if (e.Key == Key.OemPlus)// will be like equality
            {
                prevColor = this.BorderEqual.Background;
                this.BorderEqual.Background = pressed;
                this.Check_button_pressed("+");
                
            }
            if (e.Key == Key.Back)
            {
                prevColor = this.BorderBack.Background;
                this.BorderBack.Background = pressed;
                this.Check_button_pressed("Back");
            }

            //---------------------Second row---------------------------
            if (e.Key == Key.Tab)
            {
                prevColor = this.BorderTab.Background;
                this.BorderTab.Background = pressed;
                this.Check_button_pressed("Tab");
            }
            if (e.Key == Key.Q)
            {
                prevColor = this.BorderQ.Background;
                this.BorderQ.Background = pressed;
                this.Check_button_pressed("q");
            }
            if (e.Key == Key.W)
            {
                prevColor = this.BorderW.Background;
                this.BorderW.Background = pressed;
                this.Check_button_pressed("w");
            }
            if (e.Key == Key.E)
            {
                prevColor = this.BorderE.Background;
                this.BorderE.Background = pressed;
                this.Check_button_pressed("e");
            }
            if (e.Key == Key.R)
            {
                prevColor = this.BorderR.Background;
                this.BorderR.Background = pressed;
                this.Check_button_pressed("r");
            }
            if (e.Key == Key.T)
            {
                prevColor = this.BorderT.Background;
                this.BorderT.Background = pressed;
                this.Check_button_pressed("t");
            }
            if (e.Key == Key.Y)
            {
                prevColor = this.BorderY.Background;
                this.BorderY.Background = pressed;
                this.Check_button_pressed("Y");
            }
            if (e.Key == Key.U)
            {
                prevColor = this.BorderU.Background;
                this.BorderU.Background = pressed;
                this.Check_button_pressed("u");
            }
            if (e.Key == Key.I)
            {
                prevColor = this.BorderU.Background;
                this.BorderI.Background = pressed;
                this.Check_button_pressed("i");
            }
            if (e.Key == Key.O)
            {
                prevColor = this.BorderU.Background;
                this.BorderO.Background = pressed;
                this.Check_button_pressed("o");
            }
            if (e.Key == Key.P)
            {
                prevColor = this.BorderP.Background;
                this.BorderP.Background = pressed;
                this.Check_button_pressed("P");
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                prevColor = this.BorderOpenBrackets.Background;
                this.BorderOpenBrackets.Background = pressed;
                this.Check_button_pressed("[");
            }
            if (e.Key == Key.Oem6)
            {
                prevColor = this.BorderCloseBrackets.Background;
                this.BorderCloseBrackets.Background = pressed;
                this.Check_button_pressed("]");
            }
            if (e.Key == Key.Oem5)// back slash
            {
                prevColor = this.BorderBackSlash.Background;
                this.BorderBackSlash.Background = pressed;
                this.Check_button_pressed(@"\");
            }
            //------------------Third row------------------------------------
            if (e.Key == Key.Capital)
            {
                prevColor = this.BorderCapsLk.Background;
                this.BorderCapsLk.Background = pressed;
                this.Check_button_pressed("CapsLk");
              
            }
            if (e.Key == Key.A)//Divide
            {
                prevColor = this.BorderA.Background;
                this.BorderA.Background = pressed;
                this.Check_button_pressed("a");
            }
            if (e.Key == Key.S)//Divide
            {
                prevColor = this.BorderS.Background;
                this.BorderS.Background = pressed;
                this.Check_button_pressed("s");
            }
            if (e.Key == Key.D)//Divide
            {
                prevColor = this.BorderD.Background;
                this.BorderD.Background = pressed;
                this.Check_button_pressed("d");
            }
            if (e.Key == Key.F)//Divide
            {
                prevColor = this.BorderF.Background;
                this.BorderF.Background = pressed;
                this.Check_button_pressed("f");
            }
            if (e.Key == Key.G)
            {
                prevColor = this.BorderG.Background;
                this.BorderG.Background = pressed;
                this.Check_button_pressed("g");
            }
            if (e.Key == Key.H)
            {
                prevColor = this.BorderH.Background;
                this.BorderH.Background = pressed;
                this.Check_button_pressed("h");
            }
            if (e.Key == Key.J)
            {
                prevColor = this.BorderJ.Background;
                this.BorderJ.Background = pressed;
                this.Check_button_pressed("j");
            }
            if (e.Key == Key.K)
            {
                prevColor = this.BorderK.Background;
                this.BorderK.Background = pressed;
                this.Check_button_pressed("k");
            }
            if (e.Key == Key.L)
            {
                prevColor = this.BorderL.Background;
                this.BorderL.Background = pressed;
                this.Check_button_pressed("l");
            }
            //; Semicolon
            if (e.Key == Key.Oem1)
            {
                prevColor = this.BorderSemicolon.Background;
                this.BorderSemicolon.Background = pressed;
                this.Check_button_pressed(";");
            }
            if (e.Key == Key.OemQuotes)
            {
                prevColor = this.BorderQuotes.Background;
                this.BorderQuotes.Background = pressed;
                this.Check_button_pressed("'");
            }
            if (e.Key == Key.Return)
            {
                prevColor = this.BorderEnter.Background;
                this.BorderEnter.Background = pressed;
                this.Check_button_pressed("Enter");
            }
            //------------------------------ Fourth row---------------------------------
            if (e.Key == Key.LeftShift)
            {
                prevColor = this.BorderShiftL.Background;
                this.BorderShiftL.Background = pressed;
                this.Check_button_pressed("Left Shift");
            }
            if (e.Key == Key.Z)
            {
                prevColor = this.BorderZ.Background;
                this.BorderZ.Background = pressed;
                this.Check_button_pressed("z");
            }
            if (e.Key == Key.X)
            {
                prevColor = this.BorderX.Background;
                this.BorderX.Background = pressed;
                this.Check_button_pressed("x");
            }
            if (e.Key == Key.C)
            {
                prevColor = this.BorderC.Background;
                this.BorderC.Background = pressed;
                this.Check_button_pressed("c");
            }
            if (e.Key == Key.V)
            {
                prevColor = this.BorderV.Background;
                this.BorderV.Background = pressed;
                this.Check_button_pressed("v");
            }
            if (e.Key == Key.B)
            {
                prevColor = this.BorderB.Background;
                this.BorderB.Background = pressed;
                this.Check_button_pressed("b");
            }
            if (e.Key == Key.N)
            {
                prevColor = this.BorderN.Background;
                this.BorderN.Background = pressed;
                this.Check_button_pressed("n");
            }
            if (e.Key == Key.M)
            {
                prevColor = this.BorderM.Background;
                this.BorderM.Background = pressed;
                this.Check_button_pressed("m");
            }
            //Comma
            if (e.Key == Key.OemComma)
            {
                prevColor = this.BorderComma.Background;
                this.BorderComma.Background = pressed;
                this.Check_button_pressed(",");
            }
            //point
            if (e.Key == Key.OemPeriod)
            {
                prevColor = this.BorderPoint.Background;
                this.BorderPoint.Background = pressed;
                this.Check_button_pressed(".");
            }
            //Divide
            if (e.Key == Key.OemQuestion)
            {
                prevColor = this.BorderDivide.Background;
                this.BorderDivide.Background = pressed;
                this.Check_button_pressed("/");
            }
            if (e.Key == Key.RightShift)
            {
                prevColor = this.BorderShiftR.Background;
                this.BorderShiftR.Background = pressed;
                this.Check_button_pressed("Right Shift");
            }
            if (e.Key == Key.LeftCtrl)
            {
                prevColor = this.BorderCtrL.Background;
                this.BorderCtrL.Background = pressed;
                this.Check_button_pressed("Left Ctrl");
            }
            if (e.Key == Key.LWin)
            {
                prevColor = this.BorderLWin.Background;
                this.BorderLWin.Background = pressed;
                this.BorderRWin.Background = pressed;
                this.Check_button_pressed("LWin");
            }
            if (e.Key == Key.System)
            {
                prevColor = this.BorderAltL.Background;
                this.BorderAltL.Background = pressed;
                this.Check_button_pressed("Alt");

            }
            if (e.Key == Key.System)
            {
                prevColor = this.BorderAltR.Background;
              
                this.BorderAltR.Background = pressed;
                this.Check_button_pressed("Alt");
            }
            if (e.Key == Key.Space)
            {
                prevColor = this.BorderSpace.Background;
                this.BorderSpace.Background = pressed;
                this.Check_button_pressed(" ");
            }
            if (e.Key == Key.RightCtrl)
            {
                prevColor = this.BorderCtrR.Background;
                this.BorderCtrR.Background = pressed;
                this.Check_button_pressed("Right Ctrl");
            }
        }
        /// <summary>
        /// Обработка событий отпущенной кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                this.Border1.Background = prevColor;
            }

            if (e.Key == Key.Oem3)
            {
              
                this.BorderTetta.Background = prevColor;
            }
            if (e.Key == Key.D2)
            {
               
                this.Border2.Background = prevColor;
            }
            if (e.Key == Key.D3)
            {
                this.Border3.Background = prevColor;
            }
            if (e.Key == Key.D4)
            {
                this.Border4.Background = prevColor;
            }
            if (e.Key == Key.D5)
            {
                this.Border5.Background = prevColor;
            }

            if (e.Key == Key.D6)
            {
                this.Border6.Background = prevColor;
            }
            if (e.Key == Key.D7)
            {
                this.Border7.Background = prevColor;
            }
            if (e.Key == Key.D8)
            {
                this.Border8.Background = prevColor;
            }
            if (e.Key == Key.D9)
            {
                this.Border9.Background = prevColor;
            }
            if (e.Key == Key.D0)
            {
                this.Border0.Background = prevColor;
            }
            if (e.Key == Key.OemMinus)
            {
                this.BorderMinus.Background = prevColor;
            }
            if (e.Key == Key.OemPlus)
            {
                this.BorderEqual.Background = prevColor;
            }
            if (e.Key == Key.Back)
            {
                this.BorderBack.Background = prevColor;
            }
            //---------------------Second row---------------------------
            if (e.Key == Key.Tab)
            {
                this.BorderTab.Background = prevColor;
            }
            if (e.Key == Key.Q)
            {
                this.BorderQ.Background = prevColor;
            }
            if (e.Key == Key.W)
            {
                this.BorderW.Background = prevColor;
            }
            if (e.Key == Key.E)
            {
                this.BorderE.Background = prevColor;
            }
            if (e.Key == Key.R)
            {
                this.BorderR.Background = prevColor;
            }
            if (e.Key == Key.T)
            {
                this.BorderT.Background = prevColor;
            }
            if (e.Key == Key.Y)
            {
                this.BorderY.Background = prevColor;
            }
            if (e.Key == Key.U)
            {
                this.BorderU.Background = prevColor;
            }
            if (e.Key == Key.I)
            {
                this.BorderI.Background = prevColor;
            }
            if (e.Key == Key.O)
            {
                this.BorderO.Background = prevColor;
            }
            if (e.Key == Key.P)
            {
                this.BorderP.Background = prevColor;
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                this.BorderOpenBrackets.Background = prevColor;
            }
            if (e.Key == Key.Oem6)
            {
                this.BorderCloseBrackets.Background = prevColor;
            }
            if (e.Key == Key.Oem5)// BackSlash
            {
                this.BorderBackSlash.Background = prevColor;
            }
            //------------------Third row------------------------------------
            if (e.Key == Key.Capital)
            {
                this.BorderCapsLk.Background = prevColor;
            }
            if (e.Key == Key.A)
            {
                this.BorderA.Background = prevColor;
            }
            if (e.Key == Key.S)
            {
                this.BorderS.Background = prevColor;
            }
            if (e.Key == Key.D)
            {
                this.BorderD.Background = prevColor;
            }
            if (e.Key == Key.F)
            {
                this.BorderF.Background = prevColor;
            }
            if (e.Key == Key.G)
            {
                this.BorderG.Background = prevColor;
            }
            if (e.Key == Key.H)
            {
                this.BorderH.Background = prevColor;
            }
            if (e.Key == Key.J)
            {
                this.BorderJ.Background = prevColor;
            }
            if (e.Key == Key.K)
            {
                this.BorderK.Background = prevColor;
            }
            if (e.Key == Key.L)
            {
             
                this.BorderL.Background = prevColor;
            }
            if (e.Key == Key.Oem1)
            {
                this.BorderSemicolon.Background = prevColor;
            }
            //' кавычка
            if (e.Key == Key.OemQuotes)
            {
                this.BorderQuotes.Background = prevColor;
            }
            if (e.Key == Key.Return)
            {
                this.BorderEnter.Background = prevColor;
            }
            //------------------------------ Fourth row---------------------------------
            if (e.Key == Key.LeftShift)
            {
                this.BorderShiftL.Background = prevColor;
            }
            if (e.Key == Key.Z)
            {
                this.BorderZ.Background = prevColor;
            }
            if (e.Key == Key.X)
            {
                this.BorderX.Background = prevColor;
            }
            if (e.Key == Key.C)
            {
                this.BorderC.Background = prevColor;
            }
            if (e.Key == Key.V)
            {
                this.BorderV.Background = prevColor;
            }
            if (e.Key == Key.B)
            {
                this.BorderB.Background = prevColor;
            }
            if (e.Key == Key.N)
            {
                this.BorderN.Background = prevColor;
            }
            if (e.Key == Key.M)
            {
                this.BorderM.Background = prevColor;
            }
            //comma
            if (e.Key == Key.OemComma)
            {
                this.BorderComma.Background = prevColor;
            }
            if (e.Key == Key.OemPeriod)
            {
                this.BorderPoint.Background = prevColor;
            }
            //Divide /
            if (e.Key == Key.OemQuestion)
            {
                this.BorderDivide.Background = prevColor;
            }
            if (e.Key == Key.RightShift)
            {
                this.BorderShiftR.Background = prevColor;
            }
            if (e.Key == Key.LeftCtrl)
            {
                this.BorderCtrL.Background = prevColor;
            }
            if (e.Key == Key.LWin)
            {
                this.BorderLWin.Background = prevColor;
                this.BorderRWin.Background = prevColor;
               
            }
            if (e.Key == Key.System)
            {
                this.BorderAltL.Background = prevColor;
               
            }
            if (e.Key == Key.System)
            {
                
                this.BorderAltR.Background = prevColor;
            }
            if (e.Key == Key.Space)
            {
                this.BorderSpace.Background = prevColor;
            }
            if (e.Key == Key.RightCtrl)
            {
                this.BorderCtrR.Background = prevColor;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
          
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.TextBlockOut.Background = prevColor_text_box;
            checked_symbol = string.Empty;
           
             
            this.TextBlockOut.Text += text_test[i];
            checked_symbol = text_test[i].ToString();
            i++;
            if (i==text_test.Length)
            {
                timer.Stop();
            }
            this.TextBlockFails.Text = counter_fails.ToString();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            text_test = "`1234567890-=qwertyuiop";
            double difValue = Convert.ToDouble(TextBlockDifficulty.Text);
            counter_fails = 0;
            if (difValue>=1 && difValue<2)
            {
                speed = 2;
                TextBlockSpeed.Text = "2";
            }
            else if (difValue >= 2 && difValue < 3)
            {
                speed = 1.5;
                TextBlockSpeed.Text = "1.5";
            }
            else if (difValue >= 3 && difValue < 4)
            {
                speed = 1;
                TextBlockSpeed.Text = "1";
            }
            else if (difValue >= 4 && difValue < 5)
            {
                speed = 0.5;
                TextBlockSpeed.Text = "0.5";
            }
            else if (difValue == 5)
            {
                speed = 0.3;
                TextBlockSpeed.Text = "0.3";
            }
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(speed);
            timer.Start();
            this.buttonStop.IsEnabled = true;
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
           
            timer.Stop();
            this.TextBlockOut.Text=null;
            text_test = string.Empty;
            i = 0;
        }
    }
}
