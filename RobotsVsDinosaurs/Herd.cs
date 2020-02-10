using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd 
    {
        //member variable(Has A)
        public List<Dinosaur> DinoHerd = new List<Dinosaur>();


        //consructor
        public Herd()
        {             

        }

        //member method
        public void ChooseDinosaur()
        {
            Console.WriteLine("Choose your dinosaur for battle. \n 1. Spinosaurus 2. Troodon 3. Allosaurus");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    
                   
                    Console.WriteLine("You have chosen Spinosaurus");
                    Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 3, 3);
                    DinoHerd.Add(spinosaurus);
                    break; 


                case "2":
                    
                    Console.WriteLine("You have chosen Troodon");
                    Dinosaur troodon = new Dinosaur("Troodon", 2, 2);
                    DinoHerd.Add(troodon);
                    break;


                case "3":
                  
                    Console.WriteLine("You have chosen Allosaurus");
                    Dinosaur allosaurus = new Dinosaur("Allosurus", 1, 1);
                    DinoHerd.Add(allosaurus);
                    break;
                
               
            }
            
         
        
       
        }
    }
}