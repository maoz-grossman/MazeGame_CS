
//-------------------------------------//
//            optional:                //
//_____________________________________//
// for background music I can use this //
// it is the mortal combat theme song. //
//-------------------------------------//



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mortal_combat
    {
        const int C2 = 65;//do
        const int Db2 = 69;//re bimol
        const int D2 = 73;//re
        const int Eb2 = 78;//mi bimol
        const int E2 = 82;//mi
        const int F2 = 87;//fa
        const int Gb2 = 93;//sol bimol
        const int G2 = 98;//sol
        const int Ab2 = 104;//la bimol
        const int AA2 = 110;//la
        const int Bb2 = 117;//si bimol
        const int B2 = 123;//si
        const int C3 = 131;//do
        const int Db3 = 139;//re bimol
        const int D3 = 147;//re 
        const int Eb3 = 156;//mi bimol
        const int E3 = 165;//mi
        const int F3 = 175;//fa
        const int Gb3 = 185;//sol bimol
        const int G3 = 196;//sol 
        const int Ab3 = 208;//la bimol
        const int AA3 = 220;//la 
        const int Bb3 = 233;//si bimol
        const int B3 = 247;//si
        const int C4 = 262;//do
        const int Db4 = 277;//re bimol
        const int D4 = 294;//re
        const int Eb4 = 311;//mi bimol
        const int E4 = 330;//mi
        const int F4 = 349;//fa
        const int Gb4 = 370;//sol bimol
        const int G4 = 392;//sol
        const int Ab4 = 415;//la bimol
        const int AA4 = 440;//la
        const int Bb4 = 466;//si bimol
        const int B4 = 494;//si
        const int C5 = 523;//do
        const int Db5 = 554;//re bimol
        const int D5 = 587;//re
        const int Eb5 = 622;//mi bimol
        const int E5 = 659;//mi
        const int F5 = 698;//fa
        const int Gb5 = 740;//sol bimol
        const int G5 = 784;//sol
        const int Ab5 = 831;//la bimol
        const int AA5 = 880;//la
        const int Bb5 = 932;// si bimol
        const int B5 = 988;//si
        const int C6 = 1047;//do
        const int Db6 = 1109;//re bimol
        const int D6 = 1175;//re
        const int Eb6 = 1245;//mi bimol
        const int E6 = 1319;//mi
        const int F6 = 1397;//fa
        const int Gb6 = 1480;//sol bimol
        const int G6 = 1568;//sol
        const int Ab6 = 1661;//la bimol
        const int AA6 = 1760;//la
        const int Bb6 = 1865;//si bimol
        const int B6 = 1976;//si
        public Mortal_combat()
        {

        }
        private void beep(int note, int duration)
        {
            Console.Beep(note, duration);
        }
       public  void firstSection()
        {
            int running_time = 2;
            int i = 0;
            while (true)
            {
                while (i < running_time)
                {


                    beep(AA3, 200);
                    beep(AA3, 200);
                    beep(C4, 200);
                    beep(AA3, 200);
                    beep(D4, 200);
                    beep(AA3, 200);
                    beep(E4, 200);
                    beep(D4, 200);
                    beep(C4, 200);
                    beep(C4, 200);
                    beep(E4, 200);
                    beep(C4, 200);
                    beep(G4, 200);
                    beep(C4, 200);
                    beep(E4, 200);
                    beep(C4, 200);
                    beep(G3, 200);
                    beep(G3, 200);
                    beep(B3, 200);
                    beep(G3, 200);
                    beep(C4, 200);
                    beep(G3, 200);
                    beep(D4, 200);
                    beep(C4, 200);
                    beep(F3, 200);
                    beep(F3, 200);
                    beep(AA3, 200);
                    beep(F3, 200);
                    beep(C4, 200);
                    beep(F3, 200);
                    beep(C4, 200);
                    beep(B3, 200);
                    i++;
                }
                secondSection();
            }
        }
        public void secondSection()
        {
            for (int i = 0; i < 2; i++)
            { 
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(G3, 200);
            beep(C4, 200);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(G3, 200);
            beep(E3, 200);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(G3, 200);
            beep(C4, 200);
            beep(AA3, 325);
            beep(AA3, 325);
            beep(AA3, 200);
            beep(AA3, 75);
            beep(AA3, 325);
            beep(AA3, 450);
            }
            thirdSection();
        }

        public void thirdSection()
        {
            for (int i = 0; i < 2; ++i)
            {
                beep(AA3, 75);
                beep(E4, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 75);
                beep(G3, 200);
                beep(AA3, 75);
                beep(E4, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 75);
                beep(G3, 200);
                beep(AA3, 75);
                beep(E4, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(AA3, 75);
                beep(Bb3, 75);
                beep(G3, 200);
                beep(AA3, 75);
                beep(E4, 200);
                beep(AA3, 75);
                beep(C4, 200);
                beep(G3, 75);
                beep(G3, 200);
                beep(G3, 75);
                beep(AA3, 200);
                beep(AA3, 450);
            }
        }

    }
}
