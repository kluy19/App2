using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            //desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            // verificar se o período e semestre foram selecionados
            if(Entry2.Text != null &&
               Entry2.Text.Legth > 0 &&
               Picke.SelectedIndex >= 0)
            {

                // criar objeto aluno

                Aluno aluno = new Aluno();

                // modificar o período do aluno de acordo com o texto

                aluno.periodo = int.Parse(Entry2.Text);

                // verificar se os valores são iguais

                if (aluno.periodo == disciplinas[Picker.SelectedIndex].semestre)

                {

                    // habilitar mensagem de erro

                    Label1.IsVisible = true;

                }
                else

                {

                    // habilitar mensagem de erro

                    Label2.IsVisible = true;

                }

            }
            else

            {

                // habilitar mensagem de erro

                Label2.IsVisible = true;

            }



        }


    }


	}
}
