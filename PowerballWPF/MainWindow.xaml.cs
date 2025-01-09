using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PowerballWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public int trialNumber = 1;
        List<Trial> trials = new List<Trial>();

        List<int> tempNumbers = new List<int>();
        int[] tempArray = [];

        private object originalLabelOutput; //Ref: Chat GPT
        private object originalLabelWinning;

        int maxGame = 5;

        bool isPlayed = false;


        public MainWindow()
        {
            InitializeComponent();

            originalLabelOutput = LabelOutput.Content;
            originalLabelWinning = LabelWinning.Content;

        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            } 

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button01.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                } 


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button02.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button03.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button04_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button04.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button05_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button05.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }


        private void Button06_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button06.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button07_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button07.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button08_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button08.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button09_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button09.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button10.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button11.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button12.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }



        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button13.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button14.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button15.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button16.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button17.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button18.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button19.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button20.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button21.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button22.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button23.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button24_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button24.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button25_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button25.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button26_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button26.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button27_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button27.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button28_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button28.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button29_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button29.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button30_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button30.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button31.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button32_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button32.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button33_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button33.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button34_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button34.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void Button35_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show($"Warnning Max {maxGame} games!");
                return;
            }

            if (tempArray.Length == Trial.ValueLength) return;

            int buttonNumber = int.Parse(Button35.Content as string);

            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber == buttonNumber) return;
            }

            tempNumbers.Add(buttonNumber);


            string outputString = "Current: ";
            foreach (var tempNumber in tempNumbers)
            {
                if (tempNumber < 10)
                {
                    outputString = outputString + $"0{tempNumber} ";
                }
                else
                {
                    outputString = outputString + $"{tempNumber} ";
                }
            }
            LabelOutput.Content = outputString;


            tempArray = tempNumbers.ToArray();

            if (tempArray.Length == Trial.ValueLength)
            {
                Trial trial = new Trial();
                trial.ValueSet = tempArray;

                while (true)
                {
                    insertwindow op1 = new insertwindow();
                    op1.ShowDialog();

                    if (op1.TempPowerball != -1)
                    {
                        trial.Powerball = op1.TempPowerball;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Your PowerBall!");
                    }
                }


                trials.Add(trial);

                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();

                LabelOutput.Content = originalLabelOutput;
                tempNumbers = []; //tempNumbers.Clear();
                tempArray = [];
            }
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (tempNumbers.Count == 0) return;

            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (tempNumbers.Count == 1)
            {
                tempNumbers = [];
                tempArray = [];
                LabelOutput.Content = originalLabelOutput;
            }
            else
            {
                List<int> tempTemp = new List<int>();
                for (int i = 0; i < tempNumbers.Count - 1; i++)
                {
                    tempTemp.Add(tempNumbers[i]);
                }

                tempNumbers = tempTemp;

                string outputString = "Current: ";
                foreach (var tempNumber in tempNumbers)
                {
                    if (tempNumber < 10)
                    {
                        outputString = outputString + $"0{tempNumber} ";
                    }
                    else
                    {
                        outputString = outputString + $"{tempNumber} ";
                    }
                }
                LabelOutput.Content = outputString;

                tempArray = tempNumbers.ToArray();
            }

        }

        private void ButtonRandom_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count >= maxGame)
            {
                MessageBox.Show("Warnning Max 5 games!");
                return;
            }

            if (tempArray.Length != 0)
            {
                MessageBox.Show("Already Chosen Numbers exist");
                return;
            }

            Trial trial = new Trial();
            trial.RandomChoice();

            trials.Add(trial);

            ListboxTrials.ItemsSource = trials;
            ListboxTrials.Items.Refresh();

            LabelOutput.Content = originalLabelOutput;
            tempNumbers = [];
            tempArray = [];
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (trials.Count == 0)
            {
                MessageBox.Show("Please select your numbers first!");
                return;
            }

            if (tempNumbers.Count != 0)
            {
                MessageBox.Show("Please complete your selection first.");
                return;
            }

            Winning winning = new Winning();
            winning.RandomChoice();

            LabelWinning.Content = winning;

            

            foreach (Trial trial in trials)
            {
                trial.RankCheck(winning.ValueSet, winning.Powerball);
            }

            ListboxTrials.ItemsSource = trials;
            ListboxTrials.Items.Refresh();

            MessageBox.Show(
                $"""
                Rank 01: {Trial.ValueLength} Matching Numbers + Powerball
                Rank 02: {Trial.ValueLength} Matching Numbers + not Powerball
                Rank 03: {Trial.ValueLength - 1} Matching Numbers + Powerball
                Rank 04: {Trial.ValueLength - 1} Matching Numbers + not Powerball
                Rank 05: {Trial.ValueLength - 2} Matching Numbers + Powerball
                Rank 06: {Trial.ValueLength - 2} Matching Numbers + not Powerball
                Rank 07: {Trial.ValueLength - 3} Matching Numbers + Powerball
                """);

            isPlayed = true;
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            LabelOutput.Content = originalLabelOutput;
            tempNumbers = [];
            tempArray = [];

            LabelWinning.Content = originalLabelWinning;

            trials = new List<Trial>();

            ListboxTrials.ItemsSource = trials;
            ListboxTrials.Items.Refresh();

            isPlayed = false;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayed)
            {
                MessageBox.Show("Already played. Please click 'RESET'.");
                return;
            }

            if (tempNumbers.Count == 0 && ListboxTrials.SelectedItem is null) return;

            List<Trial> tempTrials = new List<Trial>();

            if (ListboxTrials.SelectedItem is not null)
            {
                foreach (Trial trial in trials)
                {
                    if (ListboxTrials.SelectedItem != trial)
                    {
                        tempTrials.Add(trial);
                    }
                }
                
                MessageBox.Show($"{ListboxTrials.SelectedItem} Delected");

                trials = tempTrials;
                ListboxTrials.ItemsSource = trials;
                ListboxTrials.Items.Refresh();
            }
            else
            {
                LabelOutput.Content = originalLabelOutput;
                tempNumbers = [];
                tempArray = [];
            }
        }
    }
}

