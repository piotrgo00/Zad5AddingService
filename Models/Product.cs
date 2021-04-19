using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad5AddingService.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        [Column(TypeName = "nvarchar(2000)")]
        public string Image { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string Url { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
