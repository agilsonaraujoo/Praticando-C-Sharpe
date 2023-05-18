 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;

 namespace exemplo.models;

 public class PessoaFisica
 {
     public string Nome {get; set;}
     public int Idade {get; set;}

     public void Apresentar()
     {
         Console.WriteLine($"Hello, my name is {Nome}, i have {Idade} years.");
     }

 }
