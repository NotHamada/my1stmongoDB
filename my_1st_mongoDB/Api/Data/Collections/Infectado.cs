using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections 
{
    public class Infectado
    {
        public Infectado(DateTime datanascimento, string sexo, double latitude, double longitude) 
        {
            this.Datanascimento = datanascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude); 
        }
        public DateTime Datanascimento { get; set; }
        public string Sexo { get; set;}
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}