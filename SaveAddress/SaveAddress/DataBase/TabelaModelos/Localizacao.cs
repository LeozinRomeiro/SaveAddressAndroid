using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SaveAddress.DataBase.TabelaModelos
{
    [Table("Localizacoes")]
    public class Localizacao
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; } = 0;
        [NotNull] public string Nome { get; set; } = string.Empty;
        [NotNull] public double Latitude { get; set;} = 0;
        [NotNull] public double Longitude { get; set; } = 0;
    }
}
