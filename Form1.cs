namespace tictactoe
{
    public partial class titactoe : Form
    {
        bool turn = true; // When X turn = true 

        int turnCount = 0; // Increment everytime users click a button
        public titactoe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My first Game\nBy Cyril :) !", "Tic Tac Toe About");
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";

            }
            else
            {
                button.Text = "O";

            }
            turn = !turn;
            button.Enabled = false;
            turnCount++;
            Check_For_Winner();
        }

        private void Check_For_Winner()
        {
            bool thereIsWinner = false;

            // Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                thereIsWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                thereIsWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                thereIsWinner = true;
            }

            //Vertical
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                thereIsWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                thereIsWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                thereIsWinner = true;
            }

            //Diagonals
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                thereIsWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                thereIsWinner = true;
            }

            if (thereIsWinner)
            {
                string winner;
                if (turn)
                {
                    winner = Display_Player_Name_2.Text;
                    O_Wins_Count.Text = (Int32.Parse(O_Wins_Count.Text) + 1).ToString();

                }
                else
                {
                    winner = Display_Player_Name.Text;
                    X_Wins_Count.Text = (Int32.Parse(X_Wins_Count.Text) + 1).ToString();

                }

                MessageBox.Show(winner.ToUpper() + " Won ! :)", "The winner is ...");
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button button = (Button)c;
                        button.Enabled = false;
                    }
                    catch { }
                }
            }
            else
            {

                if (turnCount == 9)
                {
                    MessageBox.Show("NOOBZ !!", "It's a DRAW ! :(");
                    Draw_Count.Text = (Int32.Parse(Draw_Count.Text) + 1).ToString();
                }
            }


        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            turnCount = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";

                }
                catch { }
            }

        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                if (turn)
                {
                    button.Text = "X";
                    button.ForeColor = Color.Beige;
                }
                else
                {
                    button.Text = "O";
                    button.ForeColor = Color.LightBlue;
                }
            }
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                button.Text = "";
            }
        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_Wins_Count.Text = "0";
            O_Wins_Count.Text = "0";
            Draw_Count.Text = "0";

            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
                catch { }
            }
        }

        private void Display_Player_One_Name_Click(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;


            if (text.Enabled)
            {
                text.Text = "";
            }

        }


        private void titactoe_Load(object sender, EventArgs e)
        {

        }
    }
}