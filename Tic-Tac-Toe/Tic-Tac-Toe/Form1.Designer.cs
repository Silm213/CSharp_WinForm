
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.label_x_score = new System.Windows.Forms.Label();
            this.label_o_score = new System.Windows.Forms.Label();
            this.b_newgame = new System.Windows.Forms.Button();
            this.b_restart = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_1
            // 
            this.b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_1.Location = new System.Drawing.Point(12, 86);
            this.b_1.Name = "b_1";
            this.b_1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_1.Size = new System.Drawing.Size(75, 75);
            this.b_1.TabIndex = 0;
            this.b_1.Tag = "box";
            this.b_1.Text = "X";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_2.Location = new System.Drawing.Point(93, 86);
            this.b_2.Name = "b_2";
            this.b_2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_2.Size = new System.Drawing.Size(75, 75);
            this.b_2.TabIndex = 1;
            this.b_2.Tag = "box";
            this.b_2.Text = "X";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_3
            // 
            this.b_3.Enabled = false;
            this.b_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_3.Location = new System.Drawing.Point(174, 86);
            this.b_3.Name = "b_3";
            this.b_3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_3.Size = new System.Drawing.Size(75, 75);
            this.b_3.TabIndex = 2;
            this.b_3.Tag = "box";
            this.b_3.Text = "X";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_4
            // 
            this.b_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_4.Location = new System.Drawing.Point(12, 167);
            this.b_4.Name = "b_4";
            this.b_4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_4.Size = new System.Drawing.Size(75, 75);
            this.b_4.TabIndex = 3;
            this.b_4.Tag = "box";
            this.b_4.Text = "X";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_6
            // 
            this.b_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_6.Location = new System.Drawing.Point(174, 167);
            this.b_6.Name = "b_6";
            this.b_6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_6.Size = new System.Drawing.Size(75, 75);
            this.b_6.TabIndex = 4;
            this.b_6.Tag = "box";
            this.b_6.Text = "X";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // b_5
            // 
            this.b_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_5.Location = new System.Drawing.Point(93, 167);
            this.b_5.Name = "b_5";
            this.b_5.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_5.Size = new System.Drawing.Size(75, 75);
            this.b_5.TabIndex = 5;
            this.b_5.Tag = "box";
            this.b_5.Text = "X";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_7
            // 
            this.b_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_7.Location = new System.Drawing.Point(12, 248);
            this.b_7.Name = "b_7";
            this.b_7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_7.Size = new System.Drawing.Size(75, 75);
            this.b_7.TabIndex = 6;
            this.b_7.Tag = "box";
            this.b_7.Text = "X";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
            // 
            // b_8
            // 
            this.b_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_8.Location = new System.Drawing.Point(93, 248);
            this.b_8.Name = "b_8";
            this.b_8.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_8.Size = new System.Drawing.Size(75, 75);
            this.b_8.TabIndex = 7;
            this.b_8.Tag = "box";
            this.b_8.Text = "X";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
            // 
            // b_9
            // 
            this.b_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_9.Location = new System.Drawing.Point(174, 248);
            this.b_9.Name = "b_9";
            this.b_9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.b_9.Size = new System.Drawing.Size(75, 75);
            this.b_9.TabIndex = 8;
            this.b_9.Tag = "box";
            this.b_9.Text = "X";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
            // 
            // label_x_score
            // 
            this.label_x_score.AutoSize = true;
            this.label_x_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_x_score.Location = new System.Drawing.Point(167, 9);
            this.label_x_score.Name = "label_x_score";
            this.label_x_score.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label_x_score.Size = new System.Drawing.Size(79, 39);
            this.label_x_score.TabIndex = 11;
            this.label_x_score.Text = "X: 0";
            // 
            // label_o_score
            // 
            this.label_o_score.AutoSize = true;
            this.label_o_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_o_score.Location = new System.Drawing.Point(167, 41);
            this.label_o_score.Name = "label_o_score";
            this.label_o_score.Size = new System.Drawing.Size(80, 39);
            this.label_o_score.TabIndex = 12;
            this.label_o_score.Text = "O: 0";
            // 
            // b_newgame
            // 
            this.b_newgame.Location = new System.Drawing.Point(12, 12);
            this.b_newgame.Name = "b_newgame";
            this.b_newgame.Size = new System.Drawing.Size(75, 23);
            this.b_newgame.TabIndex = 13;
            this.b_newgame.Text = "New Game";
            this.b_newgame.UseVisualStyleBackColor = true;
            this.b_newgame.Click += new System.EventHandler(this.b_newgame_Click);
            // 
            // b_restart
            // 
            this.b_restart.Location = new System.Drawing.Point(12, 44);
            this.b_restart.Name = "b_restart";
            this.b_restart.Size = new System.Drawing.Size(75, 23);
            this.b_restart.TabIndex = 14;
            this.b_restart.Text = "Nowa runda";
            this.b_restart.UseVisualStyleBackColor = true;
            this.b_restart.Click += new System.EventHandler(this.b_restart_Click);
            // 
            // turn
            // 
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turn.Location = new System.Drawing.Point(93, 12);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(75, 55);
            this.turn.TabIndex = 15;
            this.turn.Text = "Tura";
            this.turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 338);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.b_restart);
            this.Controls.Add(this.b_newgame);
            this.Controls.Add(this.label_o_score);
            this.Controls.Add(this.label_x_score);
            this.Controls.Add(this.b_9);
            this.Controls.Add(this.b_8);
            this.Controls.Add(this.b_7);
            this.Controls.Add(this.b_5);
            this.Controls.Add(this.b_6);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_7;
        private System.Windows.Forms.Button b_8;
        private System.Windows.Forms.Button b_9;
        private System.Windows.Forms.Label label_x_score;
        private System.Windows.Forms.Label label_o_score;
        private System.Windows.Forms.Button b_newgame;
        private System.Windows.Forms.Button b_restart;
        private System.Windows.Forms.Label turn;
    }
}

