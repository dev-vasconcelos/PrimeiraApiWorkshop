using System;
using System.Collections.Generic;

using PrimeiraApiWorkshop.DataBase;
using PrimeiraApiWorkshop.Repository;
using PrimeiraApiWorkshop.Models;

namespace PrimeiraApiWorkshop.Services {

    public class VehicleService {
        protected VehicleRepository _repository;
        protected NpgContext _context;

        public VehicleService(NpgContext context) {
            this._context = context;
            _repository = new VehicleRepository(context);
        }

        public VehicleService() {}

        //CRUD

        //Create
        public virtual Vehicle Save(Vehicle entity) {
            try {
                _repository.Save(entity);
                return entity;
            }catch (Exception ex) {
                throw new Exception("Exception: ", ex);
            }
        }

        //Read
        public virtual List<Vehicle> Get() {
            return _repository.Get();
        } 
        public virtual Vehicle Get(Vehicle entity) {
            return _repository.Get(entity);
        }

        public virtual Vehicle Get(long? id) {
            return _repository.Get(id);
        }

        //Update
        public virtual Vehicle Update(Vehicle entity) {
            try {
                _repository.Update(entity);
                return entity;
            }catch (Exception ex) {
                throw new Exception("Exception: ", ex);
            }
        }

        //Delete
        public virtual bool Delete(Vehicle entity) => _repository.Delete(entity);
        public virtual bool Delete(long? id) => _repository.Delete(id);
        }
        
    }
