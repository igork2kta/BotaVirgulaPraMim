using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BotaVirgulaPraMim.net_3._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cb_in, "Insira o nome da coluna.");
            toolTip.SetToolTip(tb_in, "Insira o nome da coluna.");
            toolTip.SetToolTip(CB_quebraLinha, "Remove a quebra de linha.");

            // Obter a data de criação do arquivo do assembly
            DateTime creationDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);

            string helpText = $@"O caractere de separação considerado é a quebra de linha (\n)
Data de compilação: {creationDate}
Versão {Assembly.GetEntryAssembly().GetName().Version}";

            toolTip.SetToolTip(lbl_help, helpText);

        }

        private void btn_pronto_Click(object sender, EventArgs e) => executar();


        private void executar()
        {

            if (cb_in.Checked && string.IsNullOrEmpty(tb_in.Text))
            {
                MessageBox.Show("Para utilizar a função \"IN\" o nome do campo precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cb_commit.Checked && string.IsNullOrEmpty(tb_commit.Text))
            {
                MessageBox.Show("Para utilizar a função \"COMMIT\" o intervalo de linhas precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            string text = string.Join("", split);

            if (rb_upper.Checked)
                Clipboard.SetText(text.ToUpper());
            else if (rb_lower.Checked)
                Clipboard.SetText(text.ToLower()); 

            
            MessageBox.Show("Copiado para área de transferência!");
        }

        private void cb_in_CheckedChanged(object sender, EventArgs e)
        {
            tb_in.Enabled = cb_in.Checked;

            if (cb_in.Checked)
            {
                cb_aspas.Checked = true;
                cb_virgula.Checked = true;
                cb_commit.Checked = false;
            }

        }

        private void cb_commit_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_commit.Checked)
            {
                cb_aspas.Checked = false;
                cb_virgula.Checked = false;
                cb_in.Checked = false;
            }
            tb_commit.Enabled = cb_commit.Checked;
        }

        private void cb_virgula_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_virgula.Checked) cb_commit.Checked = false;
        }

        private void cb_aspas_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_aspas.Checked) cb_commit.Checked = false;
        }

        private void tb_commit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede que um caractere não numérico seja inserido no TextBox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
