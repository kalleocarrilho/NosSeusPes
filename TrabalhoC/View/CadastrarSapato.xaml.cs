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
    /// Lógica interna para CadastrarSapato.xaml
    /// </summary>
    public partial class CadastrarSapato : Window
    {
        public CadastrarSapato()
        {
            InitializeComponent();
        }

        private void cboModelo_Loaded(object sender, RoutedEventArgs e)
        {

            cboModelo.ItemsSource = ModeloDAO.RetornarLista();
            
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            ModeloSapato modelo = new ModeloSapato {
                Nome = (string)cboModelo.SelectedItem
            };

            
            
            if (!string.IsNullOrWhiteSpace(txtTamanho.Text))
            {
                Sapato sapato = new Sapato {
                    Modelo = ModeloDAO.BuscarModeloPorNome(modelo),
                    Estoque = Int32.Parse(txtEtoque.Text),
                    Tamanho = Int32.Parse(txtEtoque.Text)



            };

                if (SapatoDAO.AdicionarSapato(sapato))
                {
                    MessageBox.Show("Sapato cadastrado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sapato cadastrado com sucesso");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }
        }
    }
}
