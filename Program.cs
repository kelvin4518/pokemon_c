using System;

namespace pokemon {
   class pokemon {
      
      // member variables
      double hp = 112;
      double sp = 10.0;
      double defense = 50.0;
      double attack = 10.0;
      
      public double GetCP() {
         return (hp * sp + defense * attack); 
      }
      public double GetHP() {
         return hp; 
      }
      public double Attack() {
         if (sp > 0){
            sp = sp - attack;
            return attack * 2;
         }
         else{
            return attack;
         }
      }
      public void GetAttack(double harm){
         hp = hp - harm;
      }
   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         pokemon pikachu1 = new pokemon();
         double pikachu_cp = pikachu1.GetCP();
         Console.WriteLine(pikachu_cp);
         pokemon pikachu2 = new pokemon();

         double attack1 = pikachu1.Attack();
         pikachu2.GetAttack(attack1);
         Console.WriteLine(pikachu2.GetHP());
      }
   }
}
