using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace HeroesAPI.Collections
{
    [Table("herois")]
    [BsonIgnoreExtraElements]
    public class Heroi
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("nome")]
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [BsonElement("time")]
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [BsonElement("idade")]
        [JsonPropertyName("idade")]
        public int Idade { get; set; }

        [BsonElement("genero")]
        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [BsonElement("habilidades")]
        [JsonPropertyName("habilidades")]
        public List<string> Habilidades { get; set; }

        [BsonElement("usaCapa")]
        [JsonPropertyName("usaCapa")]
        public bool UsaCapa { get; set; }

        [BsonElement("universo")]
        [JsonPropertyName("universo")]
        public string Universo { get; set; }
    }
}
