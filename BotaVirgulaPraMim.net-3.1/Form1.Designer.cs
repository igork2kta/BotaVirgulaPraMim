namespace BotaVirgulaPraMim.net_3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_dados = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tb_commit = new System.Windows.Forms.TextBox();
            cb_commit = new System.Windows.Forms.CheckBox();
            CB_quebraLinha = new System.Windows.Forms.CheckBox();
            tb_in = new System.Windows.Forms.TextBox();
            cb_in = new System.Windows.Forms.CheckBox();
            cb_aspas = new System.Windows.Forms.CheckBox();
            cb_virgula = new System.Windows.Forms.CheckBox();
            btn_pronto = new System.Windows.Forms.Button();
            lbl_help = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // tb_dados
            // 
            tb_dados.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_dados.Location = new System.Drawing.Point(12, 12);
            tb_dados.MaxLength = 999999999;
            tb_dados.Multiline = true;
            tb_dados.Name = "tb_dados";
            tb_dados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tb_dados.Size = new System.Drawing.Size(574, 426);
            tb_dados.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(723, 173);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 18;
            label1.Text = "Linhas";
            // 
            // tb_commit
            // 
            tb_commit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb_commit.Enabled = false;
            tb_commit.Location = new System.Drawing.Point(611, 170);
            tb_commit.Name = "tb_commit";
            tb_commit.Size = new System.Drawing.Size(106, 23);
            tb_commit.TabIndex = 17;
            tb_commit.KeyPress += tb_commit_KeyPress;
            // 
            // cb_commit
            // 
            cb_commit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_commit.AutoSize = true;
            cb_commit.Location = new System.Drawing.Point(593, 145);
            cb_commit.Name = "cb_commit";
            cb_commit.Size = new System.Drawing.Size(107, 19);
            cb_commit.TabIndex = 16;
            cb_commit.Text = "Commit a cada";
            cb_commit.UseVisualStyleBackColor = true;
            cb_commit.CheckedChanged += cb_commit_CheckedChanged;
            // 
            // CB_quebraLinha
            // 
            CB_quebraLinha.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CB_quebraLinha.AutoSize = true;
            CB_quebraLinha.Checked = true;
            CB_quebraLinha.CheckState = System.Windows.Forms.CheckState.Checked;
            CB_quebraLinha.Location = new System.Drawing.Point(592, 66);
            CB_quebraLinha.Name = "CB_quebraLinha";
            CB_quebraLinha.Size = new System.Drawing.Size(113, 19);
            CB_quebraLinha.TabIndex = 15;
            CB_quebraLinha.Text = "Quebra de Linha";
            CB_quebraLinha.UseVisualStyleBackColor = true;
            // 
            // tb_in
            // 
            tb_in.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb_in.Enabled = false;
            tb_in.Location = new System.Drawing.Point(611, 116);
            tb_in.Name = "tb_in";
            tb_in.Size = new System.Drawing.Size(177, 23);
            tb_in.TabIndex = 14;
            // 
            // cb_in
            // 
            cb_in.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_in.AutoSize = true;
            cb_in.Location = new System.Drawing.Point(593, 91);
            cb_in.Name = "cb_in";
            cb_in.Size = new System.Drawing.Size(36, 19);
            cb_in.TabIndex = 13;
            cb_in.Text = "In";
            cb_in.UseVisualStyleBackColor = true;
            cb_in.CheckedChanged += cb_in_CheckedChanged;
            // 
            // cb_aspas
            // 
            cb_aspas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_aspas.AutoSize = true;
            cb_aspas.Location = new System.Drawing.Point(592, 41);
            cb_aspas.Name = "cb_aspas";
            cb_aspas.Size = new System.Drawing.Size(57, 19);
            cb_aspas.TabIndex = 12;
            cb_aspas.Text = "Aspas";
            cb_aspas.UseVisualStyleBackColor = true;
            cb_aspas.CheckedChanged += cb_aspas_CheckedChanged;
            // 
            // cb_virgula
            // 
            cb_virgula.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_virgula.AutoSize = true;
            cb_virgula.Location = new System.Drawing.Point(592, 16);
            cb_virgula.Name = "cb_virgula";
            cb_virgula.Size = new System.Drawing.Size(63, 19);
            cb_virgula.TabIndex = 11;
            cb_virgula.Text = "Vírgula";
            cb_virgula.UseVisualStyleBackColor = true;
            cb_virgula.CheckedChanged += cb_virgula_CheckedChanged;
            // 
            // btn_pronto
            // 
            btn_pronto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_pronto.Location = new System.Drawing.Point(611, 417);
            btn_pronto.Name = "btn_pronto";
            btn_pronto.Size = new System.Drawing.Size(75, 23);
            btn_pronto.TabIndex = 10;
            btn_pronto.Text = "Pronto!";
            btn_pronto.UseVisualStyleBackColor = true;
            btn_pronto.Click += btn_pronto_Click;
            // 
            // lbl_help
            // 
            lbl_help.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_help.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_help.Image = Properties.Resources.HelpTableOfContents;
            lbl_help.Location = new System.Drawing.Point(768, 423);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(20, 18);
            lbl_help.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lbl_help);
            Controls.Add(label1);
            Controls.Add(tb_commit);
            Controls.Add(cb_commit);
            Controls.Add(CB_quebraLinha);
            Controls.Add(tb_in);
            Controls.Add(cb_in);
            Controls.Add(cb_aspas);
            Controls.Add(cb_virgula);
            Controls.Add(btn_pronto);
            Controls.Add(tb_dados);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bota Vírgula pra Mim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_commit;
        private System.Windows.Forms.CheckBox cb_commit;
        private System.Windows.Forms.CheckBox CB_quebraLinha;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.CheckBox cb_in;
        private System.Windows.Forms.CheckBox cb_aspas;
        private System.Windows.Forms.CheckBox cb_virgula;
        private System.Windows.Forms.Button btn_pronto;
        private System.Windows.Forms.Label lbl_help;
    }
}
