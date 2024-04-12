using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAperte_Click(object sender, EventArgs e)
        {
            if( cboCidades.SelectedItem.ToString() == "Sydney" )
            {
                lblResultado.Text = "Você ama a cidade das praias!";
            }
            else if ( cboCidades.SelectedItem.ToString() == "Paris" )
            {
                lblResultado.Text = "Você ama a cidade da luz!";
            } 
            else if ( cboCidades.SelectedItem.ToString() == "Roma")
            {
                lblResultado.Text = "Você ama a cidade eterna!";
            }
            else if ( cboCidades.SelectedItem.ToString() == "São Paulo" )
            {
                lblResultado.Text = "Você tem um bom gosto para viagens!";
            }
        }
    }
}
//1 ComboBox, 1 label(para o resultado) e 1 button. adicionei as cidades na combobox pelo "items" na caixa de propriedades mas o comando manual é esse:
  //{
//comboBox1.Items.Add("Sydney");
//comboBox1.Items.Add("Paris");
//comboBox1.Items.Add("Roma");
        //}

//private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        //{
   // string selectedOption = comboBox1.SelectedItem.ToString();
   // MessageBox.Show("Opção selecionada: " + Sydney); 
 //}