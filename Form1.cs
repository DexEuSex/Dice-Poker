using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Poker
{
    public partial class Form1 : Form
    {
        int[] pl1Val = {0,0,0,0,0};
        int whoseTurn = 1;
        public Form1()
        {
            InitializeComponent();
            player1Hint.Visible = false;
            player2Hint.Visible = false;
        }

        private void ThrowButton_Click(object sender, EventArgs e)
        {
            Combination Player1Combination;
            Combination Player2Combination;
            if (whoseTurn % 2 != 0)
            {
                GenerateDicePics(groupBoxPL1);
                
                mainHintLabel.Text = "Игрок 1, выберите комбинацию, которая у вас выпала!";
                whoseTurn++;
                switch(combinationBox.SelectedItem)
                {
                    case "Покер":
                        Player1Combination = new Combination(8, "Покер");
                        break;
                    case "Карэ":
                        Player1Combination = new Combination(7, "Карэ");
                        break;
                    case "Фулл Хаус":
                        Player1Combination = new Combination(6, "Фулл Хаус");
                        break;
                    case "Большой стрит":
                        Player1Combination = new Combination(5, "Большой стрит");
                        break;
                    case "Малый стрит":
                        Player1Combination = new Combination(4, "Малый стрит");
                        break;
                    case "Сет":
                        Player1Combination = new Combination(3, "Сет");
                        break;
                    case "Пара":
                        Player1Combination = new Combination(2, "Пара");
                        break;
                }
            }
            else
            {
                GenerateDicePics(groupBoxPL2);
                mainHintLabel.Text = "Игрок 2, выберите комбинацию, которая у вас выпала!";
                whoseTurn++;
                switch (combinationBox.SelectedItem)
                {
                    case "Покер":
                        Player2Combination = new Combination(8, "Покер");
                        break;
                    case "Карэ":
                        Player2Combination = new Combination(7, "Карэ");
                        break;
                    case "Фулл Хаус":
                        Player2Combination = new Combination(6, "Фулл Хаус");
                        break;
                    case "Большой стрит":
                        Player2Combination = new Combination(5, "Большой стрит");
                        break;
                    case "Малый стрит":
                        Player2Combination = new Combination(4, "Малый стрит");
                        break;
                    case "Сет":
                        Player2Combination = new Combination(3, "Сет");
                        break;
                    case "Пара":
                        Player2Combination = new Combination(2, "Пара");
                        break;
                }
            }
        }


        async public void GenerateDicePics(GroupBox playersGroupBox)
        {
            Random rnd = new Random();
            int n;
            foreach (PictureBox pic in playersGroupBox.Controls.OfType<PictureBox>())
            {
               n = rnd.Next(1, 7);
               await (Task.Delay(10));
               pic.Image = Image.FromFile($@"content\pics\{n}.jpg");
            }
        }

        public string GenerateDiceCombination()
        {

            //Все варианты комбинации "ПАРА"
            for (int i = 0; i < pl1Val.Length; i++)
            {
                for (int j = 0; j < pl1Val.Length; j++)
                {
                    if (pl1Val[i] == pl1Val[j])
                    {
                        mainHintLabel.Text = "У вас выпала пара!";
                    }
                    
                }
            } 

            //for (int i = 0; i < pl1Val.Length; i++)
            //{
            //    for (int j = 0; j < pl1Val.Length; j++)
            //    {
            //        for (int k = 0; k < pl1Val.Length; k++)
            //        {
            //            if (pl1Val[i] == pl1Val[j] && pl1Val[i] == pl1Val[k] && pl1Val[k] == pl1Val[j])
            //            {
            //                hintLabel.Text = "У вас выпал сет!";
            //            }
            //            else hintLabel.Text = "Ничего не выпало";
            //        }    
            //    }
            //}



            //if (pl1Val[0] == pl1Val[1] || pl1Val[0] == pl1Val[2] || pl1Val[0] == pl1Val[3] || pl1Val[0] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпала пара!";
            //}
            //else if (pl1Val[1] == pl1Val[1] || pl1Val[1] == pl1Val[2] || pl1Val[1] == pl1Val[3] || pl1Val[1] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпала пара!";
            //}
            //else if (pl1Val[2] == pl1Val[1] || pl1Val[2] == pl1Val[2] || pl1Val[2] == pl1Val[3] || pl1Val[2] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпала пара!";
            //}
            //else if (pl1Val[3] == pl1Val[1] || pl1Val[3] == pl1Val[2] || pl1Val[3] == pl1Val[3] || pl1Val[3] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпала пара!";
            //}
            //else if (pl1Val[4] == pl1Val[1] || pl1Val[4] == pl1Val[2] || pl1Val[4] == pl1Val[3] || pl1Val[4] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпала пара!";
            //}
            //else if (pl1Val[0] == pl1Val[1] & pl1Val[0] == pl1Val[2])
            //{
            //    hintLabel.Text = "У вас выпал сет!";
            //}
            //else if (pl1Val[0] == pl1Val[2] & pl1Val[0] == pl1Val[3])
            //{
            //    hintLabel.Text = "У вас выпал сет!";
            //}
            //else if (pl1Val[0] == pl1Val[3] & pl1Val[0] == pl1Val[4])
            //{
            //    hintLabel.Text = "У вас выпал сет!";
            //}


            return mainHintLabel.Text;
        }
    }

}
