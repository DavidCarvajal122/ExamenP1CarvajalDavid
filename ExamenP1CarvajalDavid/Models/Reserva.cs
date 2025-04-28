using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Serialization;

namespace ExamenP1CarvajalDavid.Models
    {
        public class Reserva
        {
            public int Id { get; set; }

            [DataType(DataType.Date)]
            public DateTime FechaEntrada { get; set; }

            [DataType(DataType.Date)]
            public DateTime FechaSalida { get; set; }

            [Range(0, 10000, ErrorMessage = "El valor debe ser positivo")]
            public decimal ValorPagar { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
        }
    }

