﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BotaVirgulaPraMim.net_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cb_in, "Insira o nome da coluna.");
            toolTip.SetToolTip(tb_in, "Insira o nome da coluna.");
            toolTip.SetToolTip(CB_quebraLinha, "Remove a quebra de linha.");


            string helpText = $@"O caractere de separação considerado é a quebra de linha (\n)
Data de compilação: {DateTime.Now}";

             toolTip.SetToolTip(lbl_help, helpText);

        }

        private void cb_in_CheckedChanged(object sender, EventArgs e)
        {
            tb_in.Enabled = cb_in.Checked;
        }

        private void btn_pronto_Click(object sender, EventArgs e) => executar();


        private void executar()
        {
            String[] split = tb_dados.Text.Split('\n');

            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i].Replace("\r", "");


                //Aspas
                if (cb_aspas.Checked && !string.IsNullOrEmpty(split[i])) split[i] = "'" + split[i] + "'";

                //Vírgula
                if (cb_virgula.Checked && i != split.Length - 1 && !string.IsNullOrEmpty(split[i + 1]))
                {
                    if (!cb_in.Checked)
                        split[i] += ",";

                    //Impede de colocar virgula na linha 1000 de cada IN
                    else if (cb_in.Checked && (i + 1) % 1000 != 0) split[i] += ","; ;
                }

                //IN
                if (cb_in.Checked)
                {
                    //Primeira linha
                    if (i == 0) split[i] = $"{tb_in.Text} IN ( {split[i]}";

                    //A cada 1000 linhas
                    else if ((i + 1) % 1000 == 0) split[i] += $") OR {tb_in.Text} IN (";

                    //Fecha o parênteses na ultima linha
                    if (i == split.Length - 1)
                        split[i] += ");";
                }

                //Quebra de linha
                if (CB_quebraLinha.Checked) split[i] += '\n';

                //Se o commit estiver habilitado E  (estiver no intervalo definido OU for a ultima linha)
                //ou
                if (cb_commit.Checked && ((i + 1) % Convert.ToInt32(tb_commit.Text) == 0 || i == split.Length - 1)) split[i] += "COMMIT;\n";

            }

            MessageBox.Show("Copiado para área de transferência!");
            Clipboard.SetText(string.Join("", split));

        }

    }
}