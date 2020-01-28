using System;

namespace killamonster
{
    class Monster
        {

        private string _name;
        private int _hp = 0;

        // Constuctor
        public Monster(string name, int hp) {
            this._hp = hp;
            this._name = name;
        }

        public int hp {
            get { return this._hp; }
            set { 
                if (value <= 0) {
                    this._hp = 0;
                    return;
                }                                                                                    
                this._hp = value;                                                                                     
                }                                                                                    
        }                                                                                    
            
        public string Naam {                                                                                    
            get { return this._name ;}                                                                                    
        }

        public void writeNameAndHP() {
            if (this._hp <= 0) {
                // als hij dood is maak hem rood
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(this._name + "  " + this._hp);
            } else {
                // als hij leeft maak hem groen.
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this._name + "  " + this._hp);
            }
        }
    }
}