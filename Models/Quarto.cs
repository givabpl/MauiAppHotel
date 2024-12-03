using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    // Classe que representa as características de um quarto de hotel.
    public class Quarto
    {
        // Descrição do quarto (ex.: "Quarto Deluxe com vista para o mar").
        public string Descricao { get; set; }

        // Valor da diária para adultos hospedados neste quarto.
        public double ValorDiariaAdulto { get; set; }

        // Valor da diária para crianças hospedadas neste quarto.
        public double ValorDiariaCrianca { get; set; }
    }
}
