/*
 * Created by SharpDevelop.
 * User: RM20232930091
 * Date: 29/05/2023
 * Time: 14:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dados_3._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Random rnd = new Random();
		int soma_player;
		int n1, n2, n3, n4 ,n5;
		int soma_pc;
		
		int placar_pc;
		int placar_player;
		int rodadas = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void Button1Click(object sender, EventArgs e)
		{
			 n1 = rnd.Next(1,7);
			 n2 = rnd.Next(1,7);
			soma_player = n1 + n2;
			label2.Text = "Player " + soma_player;
			
			if (rodadas >= 6) {
				button3.Visible = true;
				button2.Enabled = false;
				MessageBox.Show("O máximo de rodadas é cinco. Reinicie o Jogo!!", "ERROR !!");
			}
			else {
				rodadas += 1;
				label8.Text = rodadas + " Rodada";
			}
			
			button1.Enabled = false;
			button2.Enabled = true;
			// coloca o interrogação nas pictures do Computador
			pictureBox1.Load("interrogação.png");
			pictureBox2.Load("interrogação.png");
			
			// coloca interrogação nas pictures do jogador
			dado3.Load("interrogação.png");
			dado4.Load("interrogação.png");
			dado5.Load("interrogação.png");
			
			// ativa o dado 3
			dado3.Enabled = true;
			dado4.Enabled = false;
			dado5.Enabled = false;
			// torna somente o dado3 visivel
			dado3.Visible = true;
			dado4.Visible = false;
			dado5.Visible = false;
			
			
			
			// atualiza a img dado1
			if (n1==1)
			{
				dado1.Load("dado_1.png");
			}
			if (n1==2)
			{
				dado1.Load("dado_2.png");
			}
			if (n1==3)
			{
				dado1.Load("dado_3.png");
			}
			if (n1==4)
			{
				dado1.Load("dado_4.png");
			}
			if (n1==5)
			{
				dado1.Load("dado_5.png");
			}
			if (n1==6)
			{
				dado1.Load("dado_6.png");
			}
			
			
			// atualiza a img dado2
			if (n2==1)
			{
				dado2.Load("dado_1.png");
			}
			if (n2==2)
			{
				dado2.Load("dado_2.png");
			}
			if (n2==3)
			{
				dado2.Load("dado_3.png");
			}
			if (n2==4)
			{
				dado2.Load("dado_4.png");
			}
			if (n2==5)
			{
				dado2.Load("dado_5.png");
			}
			if (n2==6)
			{
				dado2.Load("dado_6.png");
			}
			
		}
		public void Dado3Click(object sender, EventArgs e)
		{
			n3 = rnd.Next(1,7);
			soma_player += n3;
			label2.Text = "Player " + soma_player;
			// atualiza a img dado3
			if (n3==1)
			{
				dado3.Load("dado_1.png");
			}
			if (n3==2)
			{
				dado3.Load("dado_2.png");
			}
			if (n3==3)
			{
				dado3.Load("dado_3.png");
			}
			if (n3==4)
			{
				dado3.Load("dado_4.png");
			}
			if (n3==5)
			{
				dado3.Load("dado_5.png");
			}
			if (n3==6)
			{
				dado3.Load("dado_6.png");
			}
			dado3.Enabled = false;
			dado4.Visible = true;
			dado4.Enabled = true;
		}
		public void Dado4Click(object sender, EventArgs e)
		{
			 n4 = rnd.Next(1,7);
			
			soma_player += n4;
			label2.Text = "Player " + soma_player;
			// atualiza a img dado4
			if (n4==1)
			{
				dado4.Load("dado_1.png");
			}
			if (n4==2)
			{
				dado4.Load("dado_2.png");
			}
			if (n4==3)
			{
				dado4.Load("dado_3.png");
			}
			if (n4==4)
			{
				dado4.Load("dado_4.png");
			}
			if (n4==5)
			{
				dado4.Load("dado_5.png");
			}
			if (n4==6)
			{
				dado4.Load("dado_6.png");
			}
			dado4.Enabled = false;
			dado5.Visible = true;
			dado5.Enabled = true;
		}
		public void Dado5Click(object sender, EventArgs e)
		{
			 n5 = rnd.Next(1,7);
			
			soma_player += n5;
			label2.Text = "Player " + soma_player;
			// atualiza a img dado5
			if (n5==1)
			{
				dado5.Load("dado_1.png");
			}
			if (n5==2)
			{
				dado5.Load("dado_2.png");
			}
			if (n5==3)
			{
				dado5.Load("dado_3.png");
			}
			if (n5==4)
			{
				dado5.Load("dado_4.png");
			}
			if (n5==5)
			{
				dado5.Load("dado_5.png");
			}
			if (n5==6)
			{
				dado5.Load("dado_6.png");
			}
			dado5.Enabled = false;
		}
		public void Button2Click(object sender, EventArgs e)
		{
			if (rodadas >= 6) {
				button3.Visible = true;
				button2.Enabled = false;
				MessageBox.Show("O máximo de rodadas é cinco. Reinicie o Jogo!!", "ERROR !!");
			}
			int ia_1Dado = rnd.Next(1,7);
			int ia_2Dado = rnd.Next(1,7);
			// atualiza a img dado1 do computador
			if (ia_1Dado ==1)
			{
				pictureBox2.Load("dado_1.png");
			}
			if (ia_1Dado ==2)
			{
				pictureBox2.Load("dado_2.png");
			}
			
			if (ia_1Dado ==3)
			{
				pictureBox2.Load("dado_3.png");
			}
			
			if (ia_1Dado ==4)
			{
				pictureBox2.Load("dado_4.png");
			}
			
			if (ia_1Dado ==5)
			{
				pictureBox2.Load("dado_5.png");
			}
			
			if (ia_1Dado ==6)
			{
				pictureBox2.Load("dado_6.png");
			}
			
			// atualiza a img dado2 do computador
			if (ia_2Dado ==1)
			{
				pictureBox1.Load("dado_1.png");
			}
			if (ia_2Dado ==2)
			{
				pictureBox1.Load("dado_2.png");
			}
			
			if (ia_2Dado ==3)
			{
				pictureBox1.Load("dado_3.png");
			}
			
			if (ia_2Dado ==4)
			{
				pictureBox1.Load("dado_4.png");
			}
			
			if (ia_2Dado ==5)
			{
				pictureBox1.Load("dado_5.png");
			}
			
			if (ia_2Dado ==6)
			{
				pictureBox1.Load("dado_6.png");
			}

			dado3.Enabled = false;
			dado4.Enabled = false;
			dado5.Enabled = false;
			
			button1.Enabled = true;
			button2.Enabled = false;
			
			// Soma os pontos do Computador
			soma_pc = ia_2Dado + ia_1Dado;
		
			// atualiza os pontos no placar Azul 
			label1.Text = "Computador: " + soma_pc;
			label2.Text = "Player: " + soma_player;
			
			if (soma_player > 13) { //computador vence
				placar_pc += 1;
				// labels placar
				label4.Text = "Computador: " + placar_pc;
				label3.Text = "Player: " + placar_player;
				label4.BackColor = Color.PaleGreen;
				label3.BackColor = Color.LightCoral;
			}
			else if (soma_pc > soma_player) { // computador ganha
				placar_pc += 1;
				label4.BackColor = Color.PaleGreen;
				label3.BackColor = Color.LightCoral;
				label4.Text = "Computador: " + placar_pc;
			}
			else if (soma_player > soma_pc) {
				label4.BackColor = Color.LightCoral;
				label3.BackColor = Color.PaleGreen;
				placar_player += 1;
				label3.Text = "Player: " + placar_player;
			}
			//Verifica se não houve empate, caso haja, o computador vence a rodada
			else if (soma_pc == soma_player) {
				placar_pc += 1;
				label4.BackColor = Color.PaleGreen;
				label3.BackColor = Color.LightCoral;
				label4.Text = "Computador: " + placar_pc;
				}
			//se for a última rodada
			if (rodadas == 5) { 
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Visible = true;
				if (placar_pc == 3) { 
					MessageBox.Show("Computador Venceu!!");
				}
				else if (placar_player == 3) {
					MessageBox.Show("Você Venceu!!");
				}
				else if (placar_player > placar_pc){
					MessageBox.Show("Você ganhou!");
				}
				else if (placar_player < placar_pc){
					MessageBox.Show("Você Perdeu!");
				}
				else if (placar_pc == placar_player){ // em caso de empate, o computador vence
					MessageBox.Show("Computador Venceu!!");
				}
			}
			
			label4.Text = "Computador " + placar_pc;
			label3.Text = "Player " + placar_player;
		}
		void Button3Click(object sender, EventArgs e) // reseta o jogo inteiro, todas as variáveis
		{
			button1.Enabled = true;
			button2.Enabled = false;
			button3.Visible = false;
			// coloca o interrogação nas pictures do Computador
			pictureBox1.Load("interrogação.png");
			pictureBox2.Load("interrogação.png");
			
			// coloca interrogação nas pictures do jogador
			dado1.Load("interrogação.png");
			dado2.Load("interrogação.png");
			dado3.Load("interrogação.png");
			dado4.Load("interrogação.png");
			dado5.Load("interrogação.png");
			soma_player = 0;
			placar_player = 0;
			
			dado3.Visible = false;
			dado4.Visible = false;
			dado5.Visible = false;
			
			//soma_npc = 0;
			placar_pc = 0;
			placar_player = 0;
			rodadas = 0;
			
			// atualiza as labels
			label3.BackColor = Color.Transparent;
			label3.Text = "Player: ";
			label4.BackColor = Color.Transparent;
			label8.Text = "";
			label4.Text = "Computador: ";
			label1.Text = "Computador:";
			label2.Text = "Player: ";
		}
	}
}
