using System;
using System.Linq;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using MyEF.Data;
using MyEF.Models;

namespace Misc{
    class Program{
        static void Main(){
            using(var context=new MyDBContext()){
               
                for(int i=0;i<5;i++){
                    var newUser=new User();
                    newUser.Name=$"Mitanshu{i}";
                    context.Users.Add(newUser);
                    Console.WriteLine($"User{i} data added!");
                }
                context.SaveChanges();

                Console.WriteLine("Reading data and printing below!");
                var users=context.Users.ToList();
                foreach(var user in users){
                    Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
                }


                var oldUser=context.Users.FirstOrDefault(u=>u.Name=="Mitanshu");
                if(oldUser!=null){
                    oldUser.Name="Mitanshu1";
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