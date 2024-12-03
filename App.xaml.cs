using MauiAppHotel.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace MauiAppHotel
{
    // Classe principal da aplicação, responsável por configurar o comportamento inicial
    public partial class App : Application
    {
        // Lista de quartos disponíveis para reserva
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            // Suíte Super Luxo
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,  // Valor da diária para adultos
                ValorDiariaCrianca = 55.0   // Valor da diária para crianças
            },
            // Suíte Luxo
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            // Suíte Single
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            // Suíte Crise
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };

        // Construtor da aplicação
        public App()
        {
            // Inicializa os componentes da aplicação, conforme definido no XAML
            InitializeComponent();

            // Define a página principal da aplicação como a página de contratação de hospedagem
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // Método para criar a janela principal da aplicação
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Chama o método base para criar a janela
            var window = base.CreateWindow(activationState);

            // Define o tamanho da janela
            window.Width = 400;
            window.Height = 600;

            // Retorna a janela configurada
            return window;
        }
    }
}
