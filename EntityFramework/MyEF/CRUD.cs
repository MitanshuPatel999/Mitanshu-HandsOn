using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyEF.Data;
using MyEF.Models;

namespace CRUD{
    class Program{
        static void Main(){
            using(var context=new MyDBContext()){
                var newUser=new User();
                // newUser.Id=1;
                newUser.Name="Mitanshu";
                context.Users.Add(newUser);
                context.SaveChanges();
                Console.WriteLine("User data added!");

                Console.WriteLine("Reading data and printing below!");
                var users=context.Users.ToList();
                foreach(var user in users){
                    Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
                }

                var oldUser=context.Users.FirstOrDefault(u=>u.Name=="Mitanshu");
                if(oldUser!=null){
                    oldUser.Name="Mitanshu_1";
                    Console.WriteLine("User updated successfully!");
                }
                else{
                    Console.WriteLine("User not found!!!");
                }
                var users1=context.Users.ToList();
                foreach(var user in users1){
                    Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
                }

                var delUser=context.Users.FirstOrDefault(u=>u.Id==1);
                if(delUser!=null){
                    context.Users.Remove(delUser);
                    context.SaveChanges();
                    Console.WriteLine("User deleted successfully!");
                }
                else{
                    Console.WriteLine("User not found!!!");
                }
                var users2=context.Users.ToList();
                foreach(var user in users2){
                    Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
                }
            }
        }
    }
}