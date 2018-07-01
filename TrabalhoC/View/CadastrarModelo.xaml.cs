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
    /// Lógica interna para CadastrarModelo.xaml
    /// </summary>
    public partial class CadastrarModelo : Window
    {
        public CadastrarModelo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ModeloSapato modeloSapato = new ModeloSapato {
                    Nome = txtNome.Text,
                    Material = txtMaterial.Text,
                    cor = txtCor.Text,
                    Preco = Convert.ToInt32(txtPreco.Text),
                    Cadarco = chkCadarco.IsChecked.Value

                };
                if (ModeloDAO.AdicionarModelo(modeloSapato))
                {
                    MessageBox.Show("Modelo Cadastrado com Sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Modelo!");
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os Campos!");
            }



        }

        private void chkCadarco_Checked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);


        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }

        void Handle(CheckBox checkBox)
        {
            // Use IsChecked.
            bool flag = checkBox.IsChecked.Value;

            // Assign Window Title.
            this.Title = "IsChecked = " + flag.ToString();
        }
    }

}
