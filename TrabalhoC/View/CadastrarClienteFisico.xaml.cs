using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrabalhoC.DAL;
using TrabalhoC.Model;

namespace TrabalhoC.View
{
    /// <summary>
    /// Lógica interna para CadastrarClienteFisico.xaml
    /// </summary>
    public partial class CadastrarClienteFisico : Window
    {
        public CadastrarClienteFisico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ClienteFisico clienteFisico = new ClienteFisico {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    DataNascimento =(DateTime)dtpDataDeNascimento.SelectedDate

                };
                if (ClienteFisicoDAO.AdicionarClienteFisico(clienteFisico))
                {
                    MessageBox.Show("Cliente Gravado com Sucesso!");
                    this.Close();

                }else
                {
                    MessageBox.Show("Erro ao cadastrar cliente!");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!!");
            }


        }
    }
}
