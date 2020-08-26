using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PrsEfTutorialLibrary.Models;

namespace PrsEfTutorialLibrary.Controllers {
    
    public class UserController {

        private readonly AppDbContext context = new AppDbContext();

        public User Login(string username, string password) {
            return context.Users
                .SingleOrDefault(u => u.Username == username && u.Password == password);
            //return (from u in context.Users
            //           where u.Username == username && u.Password == password
            //           select u).FirstOrDefault();
        }

        public IEnumerable<User> GetAll() {
            return context.Users.ToList();
        }
        public User GetByPk(int id) {
            if(id < 1) throw new Exception("Id must be GT zero");
            return context.Users.Find(id);
        }
        public User Insert(User user) {
            if(user == null) throw new Exception("User cannot be null");
            // edit checking here
            context.Users.Add(user);
            try {
                context.SaveChanges();
            } catch(DbUpdateException ex) {
                throw new Exception("Username must be unique", ex);
            } catch(Exception) {
                throw;
            }
            return user;
        } 
        public bool Update(int id, User user) {
            if(user == null) throw new Exception("User cannot be null");
            if(id != user.Id) throw new Exception("Id and User.Id must match");
            
            context.Entry(user).State = EntityState.Modified;
            try {
                context.SaveChanges();
            } catch(DbUpdateException ex) {
                throw new Exception("Username must be unique", ex);
            } catch(Exception) {
                throw;
            }
            return true;
        }
        public bool Delete(int id) {
            if(id <= 0) throw new Exception("Id must be GT zero");
            var user = context.Users.Find(id);
            return Delete(user);
        }
        public bool Delete(User user) {
            context.Users.Remove(user);
            context.SaveChanges();
            return true;
        }
    }
}
