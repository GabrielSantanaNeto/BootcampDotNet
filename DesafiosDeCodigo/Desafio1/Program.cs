﻿ 
 
 int n = Convert.ToInt32(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
             p *= l;
             s += l;
             n /= 10;
           }

           Console.WriteLine(p-s);
        
