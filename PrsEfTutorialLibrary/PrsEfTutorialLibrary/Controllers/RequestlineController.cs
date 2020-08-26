using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PrsEfTutorialLibrary.Models;

namespace PrsEfTutorialLibrary.Controllers {

    public class RequestlineController {

        private readonly AppDbContext context = new AppDbContext();

        private void RecalcRequestTotal(int requestId) {
            var request = context.Requests.Find(requestId);
            request.Total = request.Requestlines.Sum(x => x.Quantity * x.Product.Price);
            //var total = context.Requestlines.Where(rl => rl.RequestId == requestId)
            //                                .Sum(rl => rl.Quantity * rl.Product.Price);
            //request.Total = total;
            context.SaveChanges();
        }

        public IEnumerable<Requestline> GetAll() {
            return context.Requestlines.ToList();
        }
        public Requestline GetByPk(int id) {
            if(id < 1) throw new Exception("Id must be GT zero");
            return context.Requestlines.Find(id);
        }
        public Requestline Insert(Requestline requestline) {
            if(requestline == null) throw new Exception("Requestline cannot be null");
            // edit checking here
            context.Requestlines.Add(requestline);
            try {
                context.SaveChanges();
                RecalcRequestTotal(requestline.RequestId);
            } catch(DbUpdateException ex) {
                throw new Exception("Code must be unique", ex);
            } catch(Exception) {
                throw;
            }
            return requestline;
        }
        public bool Update(int id, Requestline requestline) {
            if(requestline == null) throw new Exception("Requestline cannot be null");
            if(id != requestline.Id) throw new Exception("Id and Requestline.Id must match");

            context.Entry(requestline).State = EntityState.Modified;
            try {
                context.SaveChanges();
                RecalcRequestTotal(requestline.RequestId);
            } catch(DbUpdateException ex) {
                throw new Exception(ex.Message, ex);
            } catch(Exception) {
                throw;
            }
            return true;
        }
        public bool Delete(int id) {
            if(id <= 0) throw new Exception("Id must be GT zero");
            var requestline = context.Requestlines.Find(id);
            return Delete(requestline);
        }
        public bool Delete(Requestline requestline) {
            context.Requestlines.Remove(requestline);
            context.SaveChanges();
            RecalcRequestTotal(requestline.RequestId);
            return true;
        }
    }
}
