using Microsoft.EntityFrameworkCore; //pacote EntityFrameworkCore, famigerado "ef" é o que gerencia esses contextos e a comunicação da api com banco e etc.
using PrimeiraApiWorkshop.Models;

namespace PrimeiraApiWorkshop.DataBase {

    public class NpgContext : DbContext {

        public NpgContext(DbContextOptions<NpgContext> options) : base(options) {

        }

        public DbSet<Vehicle> Vehicles {get; set;}

    }

}