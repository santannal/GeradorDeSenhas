using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Define uma string inicial com os caracteres minúsculos do alfabeto
            string caracteres = "abcdefghijklmnopqrstuvwxyz";

            // Adiciona números à string de caracteres se a opção estiver marcada
            if (cAlgarismos.Checked)
            {
                caracteres += "0123456789";
            }

            // Adiciona caracteres especiais à string de caracteres se a opção estiver marcada
            if (cEspeciais.Checked)
            {
                caracteres += "!@#$%&*()-_+={}[];.,:";
            }

            // Adiciona letras maiúsculas à string de caracteres se a opção estiver marcada
            if (cMaiusculos.Checked)
            {
                caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            // Limpa os itens da tabela onde as senhas serão exibidas
            tableExibirSenhas.Items.Clear();

            // Inicia um objeto Random para sorteio
            Random sorteio = new Random();

            // Define a quantidade de senhas a serem geradas (atualmente, sempre 1)
            int qtd = 1;

            // Loop para gerar a quantidade de senhas especificada
            for (int num = 1; num <= qtd; num++)
            {
                // Inicia uma StringBuilder para construir a senha
                StringBuilder senha = new StringBuilder();

                // Loop para construir a senha com base no número de caracteres especificado
                for (int x = 1; x <= numeroCaracteres.Value; x++)
                {
                    // Gera um índice aleatório para escolher um caractere da string de caracteres
                    int local = sorteio.Next(0, caracteres.Length);

                    // Adiciona o caractere escolhido à senha
                    senha.Append(caracteres[local].ToString());
                }

                // Adiciona a senha à tabela de exibição
                tableExibirSenhas.Items.Add(senha.ToString());
            }
        }

        // Método para fechar a aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

