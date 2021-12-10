using System;
using System.Collections.Generic;
using System.Linq;

using PrimeiraApiWorkshop.DataBase;
using PrimeiraApiWorkshop.Models;

namespace PrimeiraApiWorkshop.Repository {

/*
    Repository é a classe responsável por estar manipulando o banco de dados,
    persistindo as mudanças e sincronizando o contexto da aplicação.
*/

/*
    Temos o famoso "CRUD":
    CREATE
    READ
    UPDATE
    DELETE
*/
    public class VehicleRepository {

        protected NpgContext _context;

        public VehicleRepository(NpgContext context) {
            this._context = context;
        }

        //Create
        public virtual Vehicle Save(Vehicle entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw new Exception("Falha ao atualizar veículo: ", ex);
            }

            return entity;
        }
        
        //Read
        public virtual List<Vehicle> Get() => _context.Set<Vehicle>().ToList(); //todos veículos

        public virtual Vehicle Get(Vehicle entity) => _context.Set<Vehicle>().SingleOrDefault(v => v.Id == entity.Id);

        public virtual Vehicle Get(long? id) => _context.Set<Vehicle>().SingleOrDefault(v => v.Id == id);

        //Update
        public virtual Vehicle Update(Vehicle entity) {

            try {   
                _context.Attach<Vehicle>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            } catch (Exception ex) {
                throw new Exception("Falha ao atualizar veículo: ", ex);
            }

            return entity;
        }

        //Delete
        public virtual bool Delete(Vehicle entity) {
            try {
                _context.Remove(entity);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw new Exception("Falha ao tentar excluir o veículo", ex);
            }

            return true;
        }

        //Delete
        public virtual bool Delete(long? id) {
            try {
                _context.Remove(id);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw new Exception("Falha ao tentar excluir o veículo", ex);
            }

            return true;
        }

        

    }

}