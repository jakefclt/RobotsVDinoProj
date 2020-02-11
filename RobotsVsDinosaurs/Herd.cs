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
            Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 20);
            DinoHerd.Add(spinosaurus);
            Dinosaur troodon = new Dinosaur("Troodon", 15);
            DinoHerd.Add(troodon);
            Dinosaur allosaurus = new Dinosaur("Allosurus", 10);
            DinoHerd.Add(allosaurus);
        }

        //member method
        public Dinosaur ChooseDinosaur()
        {
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                                       
                    Console.WriteLine("You have chosen Spinosaurus");
                    return DinoHerd[0];                    

                case "2":
                    if (DinoHerd.Count > 1)
                    {
                    Console.WriteLine("You have chosen Troodon");
                    return DinoHerd[1];
                    }
                    else
                    {
                        goto default;
                    }
                                 

                case "3":
                    if(DinoHerd.Count > 2)
                    {
                    Console.WriteLine("You have chosen Allosaurus");
                    return DinoHerd[2];
                    }
                    else
                    {
                        goto default;
                    }
                    
                default :
                    Console.WriteLine("Not a valid dinosaur");
                    return ChooseDinosaur();
                    
                    

                
               
            }
            
         
        
       
        }
    }
}