
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace ExamenP1CarvajalDavid.Models
    {
        public class Cliente
        {
            public int Id { get; set; }
            public string Cedula { get; set; }
            public string Telefono { get; set; }
       
            [Required]
            [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "Debe tener al menos 18 años")]

            [Range(18, 100)]
            public int Edad { get; set; }
            [Required(ErrorMessage = "El saldo no puede ser menos de 0 ")]

            [Range(0, 100000)]
            public decimal Saldo { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            public bool vip { get; set; }

            [DataType(DataType.Date)]
            
            public DateTime FechaRegistro { get; set; }
        }
    }
