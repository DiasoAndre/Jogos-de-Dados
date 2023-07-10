/*
 * Created by SharpDevelop.
 * User: RM20232930091
 * Date: 29/05/2023
 * Time: 14:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dados_3._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox dado1;
		private System.Windows.Forms.PictureBox dado2;
		private System.Windows.Forms.PictureBox dado3;
		private System.Windows.Forms.PictureBox dado4;
		private System.Windows.Forms.PictureBox dado5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dado1 = new System.Windows.Forms.PictureBox();
			this.dado2 = new System.Windows.Forms.PictureBox();
			this.dado3 = new System.Windows.Forms.PictureBox();
			this.dado4 = new System.Windows.Forms.PictureBox();
			this.dado5 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dado3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dado4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dado5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dado1
			// 
			this.dado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dado1.Image = ((System.Drawing.Image)(resources.GetObject("dado1.Image")));
			this.dado1.Location = new System.Drawing.Point(29, 335);
			this.dado1.Name = "dado1";
			this.dado1.Size = new System.Drawing.Size(147, 140);
			this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dado1.TabIndex = 0;
			this.dado1.TabStop = false;
			// 
			// dado2
			// 
			this.dado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dado2.Image = ((System.Drawing.Image)(resources.GetObject("dado2.Image")));
			this.dado2.Location = new System.Drawing.Point(187, 335);
			this.dado2.Name = "dado2";
			this.dado2.Size = new System.Drawing.Size(147, 140);
			this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dado2.TabIndex = 1;
			this.dado2.TabStop = false;
			// 
			// dado3
			// 
			this.dado3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dado3.Enabled = false;
			this.dado3.Image = ((System.Drawing.Image)(resources.GetObject("dado3.Image")));
			this.dado3.Location = new System.Drawing.Point(345, 335);
			this.dado3.Name = "dado3";
			this.dado3.Size = new System.Drawing.Size(147, 140);
			this.dado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dado3.TabIndex = 2;
			this.dado3.TabStop = false;
			this.dado3.Visible = false;
			this.dado3.Click += new System.EventHandler(this.Dado3Click);
			// 
			// dado4
			// 
			this.dado4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dado4.Enabled = false;
			this.dado4.Image = ((System.Drawing.Image)(resources.GetObject("dado4.Image")));
			this.dado4.Location = new System.Drawing.Point(503, 335);
			this.dado4.Name = "dado4";
			this.dado4.Size = new System.Drawing.Size(147, 140);
			this.dado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dado4.TabIndex = 3;
			this.dado4.TabStop = false;
			this.dado4.Visible = false;
			this.dado4.Click += new System.EventHandler(this.Dado4Click);
			// 
			// dado5
			// 
			this.dado5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dado5.Enabled = false;
			this.dado5.Image = ((System.Drawing.Image)(resources.GetObject("dado5.Image")));
			this.dado5.Location = new System.Drawing.Point(661, 335);
			this.dado5.Name = "dado5";
			this.dado5.Size = new System.Drawing.Size(147, 140);
			this.dado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dado5.TabIndex = 4;
			this.dado5.TabStop = false;
			this.dado5.Visible = false;
			this.dado5.Click += new System.EventHandler(this.Dado5Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 121);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(187, 121);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(147, 140);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Moccasin;
			this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(30, 499);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Iniciar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(654, 250);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Computador:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(555, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Player:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Moccasin;
			this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(111, 499);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Finalizar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(555, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Player:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(654, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Computador:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(555, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gold;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(555, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(199, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Placar";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(555, 228);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(199, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Pontos";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PeachPuff;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 78);
			this.panel1.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(29, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(305, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Faça mais pontos que o computador para ganhar";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(29, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Jogo de Dados";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(29, 95);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(210, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Computador\r\n";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(29, 309);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(210, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Seus dados";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Moccasin;
			this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(192, 499);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 22;
			this.button3.Text = "Restart";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(839, 538);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dado5);
			this.Controls.Add(this.dado4);
			this.Controls.Add(this.dado3);
			this.Controls.Add(this.dado2);
			this.Controls.Add(this.dado1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Jogo dos Dados !!!";
			((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dado3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dado4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dado5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
