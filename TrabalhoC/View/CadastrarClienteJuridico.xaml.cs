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
    /// Lógica interna para CadastrarClienteJuridico.xaml
    /// </summary>
    public partial class CadastrarClienteJuridico : Window
    {
        public CadastrarClienteJuridico()
        {
            InitializeComponent();
        }

        private void btnCadastrarJuridico_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ClienteJuridico clienteJuridico = new ClienteJuridico {

                    Nome = txtNome.Text,
                    Cnpj = txtCnpj.Text,
                    Razao = txtRazao.Text,
                    Endereco = txtEndereco.Text
                    

                };

                if (ClienteJuridicoDAO.AdicionarClienteJuridico(clienteJuridico))
                {
                    MessageBox.Show("Cliente Gravado com Sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente");
                }

            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }



        }
    }
}
