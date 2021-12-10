using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraApiWorkshop.Models {

    /*
        Por padrão os nomes em banco de dados são snake_case.
        A notação "Table" denota a classe como uma tabela do banco de dados
    */
    /*
        Modelo, que nada mais é do que a "representação" da tabela do banco de dados na nossa aplicação.
        Porém, nem todo modelo precisa necessariamente ser uma tabela de banco. Alguns sistemas podem usar modelos
        intermediários para realizar algumas ações específicas e algumas implementações necessárias.
    */
    [Table("tb_vehicle")]
    public class Vehicle {
        
        [Key] //PK, PrimaryKey
        [Column("id")]
        public long Id { get; set;}

        [Column("marca")]
        public string Marca {get; set;}

        [Column("modelo")]
        public string Modelo {get; set;}

        [Column("ano")]
        public DateTime Ano {get; set;}

        [Column("cidade_fabricacao")]
        public string CidadeFabricacao {get; set;}

    }

}