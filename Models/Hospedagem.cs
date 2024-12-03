using System;

namespace MauiAppHotel.Models
{
    // Classe que representa uma hospedagem em um hotel.
    public class Hospedagem
    {
        // Propriedade que armazena o quarto selecionado para a hospedagem.
        public Quarto QuartoSelecionado { get; set; }

        // Número de adultos na hospedagem.
        public int QntAdultos { get; set; }

        // Número de crianças na hospedagem.
        public int QntCriancas { get; set; }

        // Data de check-in da hospedagem.
        public DateTime DataCheckIn { get; set; }

        // Data de check-out da hospedagem.
        public DateTime DataCheckOut { get; set; }

        // Propriedade calculada que retorna o número de dias de estadia.
        // Utiliza o método Subtract para calcular a diferença entre as datas.
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        // Propriedade calculada que retorna o valor total da hospedagem.
        public double ValorTotal
        {
            get
            {
                // Calcula o custo total para adultos baseado no valor da diária do quarto.
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;

                // Calcula o custo total para crianças baseado no valor da diária do quarto.
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                // Multiplica o custo total por adultos e crianças pelo número de dias da estadia.
                double total = (valor_adultos + valor_criancas) * Estadia;

                // Retorna o valor total da hospedagem.
                return total;
            }
        }
    }
}
