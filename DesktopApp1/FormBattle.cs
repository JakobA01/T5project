using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DesktopApp1
{
    public partial class FormBattle : Form
    {
        Form1 form;
        System.Timers.Timer timer = new System.Timers.Timer(2000);
        string battleText = "";
        int defense;
        int opponentMissChance;
        int turn = 0;
        public FormBattle(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            timer.Start();
            battleText = "Choose an attack!";
            timer.Elapsed += OnTimeEvent;
        }

        public void OnTimeEvent(Object o, ElapsedEventArgs e)
        {
            lblBattleText.Invoke((Action)delegate
            {
                lblBattleText.Text = battleText;
            });
            timer.Stop();       
        }

        private int Attack (String attackName)
        {
            int damage = 0;
            int missChance = 0;
            defense = 0;
            opponentMissChance = 0;
            Random randomInt = new Random();
            if (attackName.Equals("Thunderbolt"))
            {
                damage = randomInt.Next(15, 41);
                missChance = 40;
            }
            else if (attackName.Equals("Quick attack"))
            {
                damage = randomInt.Next(10, 26);
                missChance = 20;
            }
            else if (attackName.Equals("Electric shock"))
            {
                damage = randomInt.Next(5, 16);
                opponentMissChance = 1;
            }
            else if (attackName.Equals("Harden"))
            {
                defense = 1;
            }
            int miss = randomInt.Next(101);
            if (miss <= missChance)
            {
                battleText = attackName + " missed!";
                damage = 0;
            }
            return damage;
        }

        private void LblAttack1_Click(object sender, EventArgs e)
        {
            string attackName = lblAttack1.Text;
            if (progressBarYou.Value > 0 || progressBarOpponent.Value > 0)
            {
                battleText = "Choose an attack!";
                timer.Elapsed += OnTimeEvent;
                YourAttackTurn(attackName);
                OpponentsTurn();
            }      
        }

        private void LblAttack2_Click(object sender, EventArgs e)
        {
            string attackName = lblAttack2.Text;
            if (progressBarYou.Value > 0 || progressBarOpponent.Value > 0)
            {
                battleText = "Choose an attack!";
                timer.Elapsed += OnTimeEvent;
                YourAttackTurn(attackName);
                OpponentsTurn();
            }
           
        }

        private void LblAttack3_Click(object sender, EventArgs e)
        {
            string attackName = lblAttack3.Text;
            if (progressBarYou.Value > 0 || progressBarOpponent.Value > 0)
            {
                battleText = "Choose an attack!";
                timer.Elapsed += OnTimeEvent;
                YourAttackTurn(attackName);
                OpponentsTurn();
            }
            
        }

        private void LblAttack4_Click(object sender, EventArgs e)
        {
            string attackName = lblAttack4.Text;
            if (progressBarYou.Value > 0 || progressBarOpponent.Value > 0)
            {
                YourAttackTurn(attackName);
                OpponentsTurn();
            }
            
        }

        private void YourAttackTurn(string attackName)
        {
            if (turn == 0)
            {
                lblBattleText.Text = "Pikachu used " + attackName + "!";
                int damage = Attack(attackName);
                if (battleText.Equals(attackName + " missed!"))
                {
                    timer.Start();
                    timer.Elapsed += OnTimeEvent;
                }
                else if (opponentMissChance == 1)
                {
                    battleText = attackName + " deals " + damage + " damage!\nOpponent's miss chance increased.";
                    timer.Start();
                    timer.Elapsed += OnTimeEvent;
                    if (damage >= progressBarOpponent.Value)
                    {
                        battleText = "Opponent has been defeated, Pikachu wins!";
                        timer.Start();
                        timer.Elapsed += OnTimeEvent;
                    }
                    else
                    {
                        progressBarOpponent.Value -= damage;
                        lblOpponentHP.Text = "HP: " + progressBarOpponent.Value;
                    }
                }
                else if (defense == 1)
                {
                    battleText = "Pikachu's defense increased!";
                    timer.Start();
                    timer.Elapsed += OnTimeEvent;
                    progressBarOpponent.Value -= damage;
                    lblOpponentHP.Text = "HP: " + progressBarOpponent.Value;
                }
                else
                {
                    battleText = attackName + " deals " + damage + " damage!";
                    timer.Start();
                    timer.Elapsed += OnTimeEvent;                   
                    if (damage >=  progressBarOpponent.Value)
                    {
                        battleText = "Opponent has been defeated, Pikachu wins!";
                        timer.Start();
                        timer.Elapsed += OnTimeEvent;
                    }
                    else
                    {
                        progressBarOpponent.Value -= damage;
                        lblOpponentHP.Text = "HP: " + progressBarOpponent.Value;
                    }
                }
            }
            else
            {
                lblAttack1.Enabled = false;
                lblAttack2.Enabled = false;
                lblAttack3.Enabled = false;
                lblAttack4.Enabled = false;
            }
            turn = 1;
        }
        private void OpponentsTurn()
        {
            int missChance = 25;
            string attackName = "Slam";
            Random randomInt = new Random();
            int damage = randomInt.Next(10, 41);
            if (opponentMissChance == 1)
            {
                missChance = missChance * 2;
            }
            if (defense == 1)
            {
                damage = (int)(damage / (randomInt.NextDouble()+1));
            }
            int miss = randomInt.Next(101);
            if (miss <= missChance)
            {
                battleText = attackName + " missed!";
                timer.Start();
                timer.Elapsed += OnTimeEvent;
                damage = 0;
            }
            else
            {
                battleText = attackName + " deals " + damage + " damage!";
                timer.Start();
                timer.Elapsed += OnTimeEvent;
                if (damage >= progressBarYou.Value)
                {
                    battleText = "Pikachu has been defeated, opponent wins!";
                    timer.Start();
                    timer.Elapsed += OnTimeEvent;
                }
                else
                {
                    progressBarYou.Value -= damage;
                    lblYourHP.Text = "HP: " + progressBarYou.Value;
                }
            }
            turn = 0;
        }
    }
}
