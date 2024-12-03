using System;

namespace MauiAppHotel
{
    // A classe MainPage herda de ContentPage, que é o tipo base para a página da interface
    public partial class MainPage : ContentPage
    {
        // Contador para armazenar o número de cliques no botão
        int count = 0;

        // Construtor da página, chamado quando a página é inicializada
        public MainPage()
        {
            InitializeComponent();  // Inicializa o conteúdo da página (vincula o arquivo XAML)
        }

        // Método chamado quando o botão é clicado
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;  // Incrementa o contador

            // Atualiza o texto do botão com o número de cliques
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";  // Exibe 'time' para o primeiro clique
            else
                CounterBtn.Text = $"Clicked {count} times";  // Exibe 'times' para múltiplos cliques

            // Anuncia o texto do botão para o leitor de tela, facilitando a acessibilidade
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
