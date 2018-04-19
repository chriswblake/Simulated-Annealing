using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ch2___Simulated_Anealing
{
    public partial class Form1 : Form
    {
        //Fields
        Board board = null;
        List<AnnealStat> stats = null;

        //Constructors
        public Form1()
        {
            InitializeComponent();
            chartResults.Series.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Show initial board
            board = new Board(Convert.ToInt32(tbSize.Text));

            //Show the board
            displayPositions(board);

            //Show energy
            tbEnergy.Text = board.Energy.ToString();
        }

        //Methods
        public void tweakBoard(Board theBoard)
        {
            //Adjust board randomly.
            theBoard.tweakSolution();

            //Show new board
            displayPositions(theBoard);

            //Show energy
            tbEnergy.Text = theBoard.Energy.ToString();
        }
        public void displayPositions_old(Board theBoard)
        {
            char[,] positions = theBoard.Positions;

            //Clear current board
            resultsBox.Text = "";

            //Get Dimensions
            var rows = positions.GetLength(0);
            var cols = positions.GetLength(1);

            //Column Header
            resultsBox.Text += "  |";
            for (int c = 0; c < cols; c++)
            {
                resultsBox.Text += c.ToString("00.##") + "|";
            }
            resultsBox.Text += Environment.NewLine;

            //Add rows
            for (int r = 0; r < rows; r++)
            {
                //Row header
                resultsBox.Text += r.ToString("00.##") + "|";

                //Row Data
                for (int c = 0; c < cols; c++)
                {
                    //Get data
                    char p = positions[r, c];
                    resultsBox.Text += p + " |";
                }

                //Next line
                resultsBox.Text += Environment.NewLine;
            }

        }
        public void displayPositions(Board theBoard)
        {
            resultsBox.Text = theBoard.DisplayPositions;
        }
        public Board annealBoard(Board theBoard, out List<AnnealStat> annealStats)
        {
            //Run variables
            int timer = 0, step, solution = 0, useNew, accepted;
            double temperature = 100, finalTemperature = 0.5;
            double alpha = 0.99;
            int stepsPerChange = 100;
            Random rand = new Random();
            Board current, working, best;
            List<AnnealStat> stats = new List<AnnealStat>();

            //Copy current board
            current = new Board(theBoard);
            working = new Board(theBoard);
            best = new Board(theBoard);

            //Anneal
            while (temperature > finalTemperature)
            {
                //Monte Carlo Step
                accepted = 0;
                for (step = 0; step < stepsPerChange; step++)
                {
                    useNew = 0;

                    //Adjust board randomly
                    working.tweakSolution();

                    //Check energy
                    if (working.Energy <= current.Energy)
                    {
                        useNew = 1;
                        accepted++;
                    }
                    else
                    {
                        double test = rand.NextDouble();
                        double delta = working.Energy - current.Energy;
                        double calc = Math.Exp(-delta / temperature);

                        if (calc > test)
                        {
                            accepted++;
                            useNew = 1;
                        }
                    }

                    if (useNew == 1)
                    {
                        useNew = 0;
                        //Copy working to current
                        current = new Board(working);

                        //Compare to best
                        if (current.Energy < best.Energy)
                        {
                            best = new Board(current);
                            solution = 1;
                        }
                    }
                    else
                    {
                        working = new Board(current);
                    }

                }
                //End Monte Carlo Step

                //Fill in stats
                stats.Add(new AnnealStat(timer++, temperature, best.Energy, accepted));

                //Adjust temperature
                temperature *= alpha;
            }

            if (solution == 1)
            {
                annealStats = stats;
                return new Board(best);
            }
            else
            {
                annealStats = stats;
                return new Board(current); //Return last run
            }
        }
        
        //Controls
        private void tbSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Create the board
                board =  new Board(Convert.ToInt32(tbSize.Text));

                //Show board
                displayPositions(board);

                //Show energy
                tbEnergy.Text = board.Energy.ToString();
            }
            catch { }
        }
        private void btnTweak_Click(object sender, EventArgs e)
        {
            tweakBoard(board);
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            //Clear stats
            //Solve
            Board annealedBoard = annealBoard(board, out stats);
            displayPositions(annealedBoard);
            tbEnergy.Text = annealedBoard.Energy.ToString();

            //Show Stats
            tbStats.Text = "Time\tTemp\tEn\tAcc" + Environment.NewLine;
            foreach(AnnealStat stat in stats)
            {
                //Display updates in textbox
                tbStats.Text += stat.Time;
                tbStats.Text += "\t" + stat.Temperature.ToString("F1");
                tbStats.Text += "\t" + stat.Energy;
                tbStats.Text += "\t" + stat.Accepted;
                tbStats.Text += Environment.NewLine;
            }

            //Show chart
            chartResults.DataSource = stats;
            chartResults.Series.Clear();
            chartResults.DataBindTable(stats, "Time");
            foreach (Series s in chartResults.Series)
            {
                s.ChartType = SeriesChartType.Line;
            }
        }

    }

    //Classes
    public class Board
    {
        //Fields
        private char[,] positions = null;
        private int energy = 0;
        private Random rand = new Random();

        //Constructors
        public Board(int size)
        {
            //Create empty array;
            positions = new char[size, size];

            //Set default positions
            for (int r = 0; r < size; r++)
                for (int c = 0; c < size; c++)
                {
                    if (r==c) { this.positions[r, c] = 'Q'; }
                    else
                    {
                        this.positions[r, c] = ' ';
                    }
                }

            //Calculate initial energy
            energy = computeEnergy();
        }
        public Board(Board orig)
        {
            positions = (char[,])orig.positions.Clone();
            energy = orig.energy;
        }

        //Properties
        public char[,] Positions
        {
            get { return positions; }
        }
        public int Energy
        {
            get { return energy; }
        }
        public string DisplayPositions
        {
            get
            {
                //Get Dimensions
                var rows = positions.GetLength(0);
                var cols = positions.GetLength(1);

                //Column Header
                string displayString = "  |";
                for (int c = 0; c < cols; c++)
                {
                    displayString += c.ToString("00.##") + "|";
                }
                displayString += Environment.NewLine;

                //Add rows
                for (int r = 0; r < rows; r++)
                {
                    //Row header
                    displayString += r.ToString("00.##") + "|";

                    //Row Data
                    for (int c = 0; c < cols; c++)
                    {
                        //Get data
                        char p = positions[r, c];
                        displayString += p + " |";
                    }

                    //Next line
                    displayString += Environment.NewLine;
                }

                //return result
                return displayString;
            }
        }

        //Methods
        public void tweakSolution()
        {
            //Get board dimensions
            var rows = positions.GetLength(0);
            var cols = positions.GetLength(1);

            //Pick random column
            int colQ1 = rand.Next(0, cols);

            //Find the queen in that column
            int rowQ1 = 0;
            while (positions[rowQ1,colQ1] != 'Q')
            { rowQ1++; }

            //Pick second random column, that is different
            int colQ2 = 0;
            while (colQ2 == colQ1)
                colQ2 = rand.Next(0, cols);

            //Find the queen in that column
            int rowQ2 = 0;
            while (positions[rowQ2, colQ2] != 'Q')
            { rowQ2++; }

            //Remove original positions
            positions[rowQ1, colQ1] = ' ';
            positions[rowQ2, colQ2] = ' ';

            //Swap rows of Q1 and Q2
            positions[rowQ2, colQ1] = 'Q';
            positions[rowQ1, colQ2] = 'Q';

            //Recalculate energy
            energy = computeEnergy();
        }
        private int computeEnergy()
        {
            //Working variables
            int conflicts = 0;
            int[] dr = new int[] { -1, 1, -1, 1 }; //NW,SE,SW,NE
            int[] dc = new int[] { -1, 1, 1, -1 };
            int tempR;
            int tempC;

            //Create temp positions
            char[,] tempPositions = (char[,])positions.Clone();

            //Get board dimensions
            var rows = tempPositions.GetLength(0);
            var cols = tempPositions.GetLength(1);

            //Scan positions for queens
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    //if a queen is found, check diagonals
                    if (tempPositions[r, c] == 'Q')
                    {
                        //Remove this queen so it is not compared again later
                        tempPositions[r, c] = ' ';

                        //Check each diagonal
                        for (int direction = 0; direction < 4; direction++)
                        {
                            //Copy current position
                            tempR = r;
                            tempC = c;

                            //Check in one direction
                            while (true)
                            {
                                //move direction
                                tempR += dr[direction];
                                tempC += dc[direction];

                                //Check for valid coordinates
                                if (tempR >= rows || tempR < 0 ||
                                    tempC >= cols || tempC < 0)
                                    break;

                                //if there is a queen, add to counter
                                if (tempPositions[tempR, tempC] == 'Q')
                                { 
                                    conflicts++; break;
                                }
                            };

                        }
                    }
                }
            }
            return conflicts;
        }
        
    }
    public class AnnealStat
    {
        //Fields
        private int time;
        private double temperature;
        private int energy;
        private int accepted;

        //Constructors
        public AnnealStat(int time, double temperature, int energy, int accepted)
        {
            this.time = time;
            this.temperature = temperature;
            this.energy = energy;
            this.accepted = accepted;
        }

        //Properties
        public int Time
        {
            get { return time; }
        }
        public double Temperature
        {
            get { return temperature; }
        }
        public int Energy
        {
            get { return energy; }
        }
        public int Accepted
        {
            get { return accepted; }
        }
    }
}
