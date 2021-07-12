﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }


        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} debe de ser diligenciado")]
        public string Name { get; set; }

        [NotMapped]
        [JsonIgnore]
        public int IdDepartment{get;set;}
    }

}
