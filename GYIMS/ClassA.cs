using System;
using Another_One;

namespace GYIMS
{
    class ClassA
    {
       public string Text = "Is that you?";
       private byte getalPrive = 45;
       public void ItIsYou()
           {
             Console.WriteLine("getalPrive: " + getalPrive);
           }

           public void Underneath()
           {
               int Hidden = 666;
               Console.WriteLine(Hidden);
           }
        }
    }

