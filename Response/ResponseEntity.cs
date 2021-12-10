using System;
using System.Collections.Generic;

namespace PrimeiraApiWorkshop.Response {

    public class ResponseEntity<T> {
        public IEnumerable<string> Errors {get; }
        public T data {get; set;}

        public ResponseEntity(T data, string messageError) {
            var list = new List<string>();
            list.Add(messageError);
            Errors = list;
            this.data = data;
        }

        public ResponseEntity(T data, IEnumerable<string> errors) {
            this.data = data;
            Errors = errors;
        }

        public ResponseEntity(T data, Exception ex) {
            var list = new List<string>();
            list.Add(ex.Message);
            Errors = list;
            this.data = data;
        }

        public ResponseEntity(T data) {
            this.data = data;
        }

        public ResponseEntity() {}
    }

}