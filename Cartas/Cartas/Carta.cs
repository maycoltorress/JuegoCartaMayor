using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cartas
{
    class Carta
    {
        int pozoJugador1;
        int pozoJugador2;

        public Carta(){
        }

        public Carta(int pozoJugador1, int pozoJugador2){
            this.pozoJugador1 = pozoJugador1;
            this.pozoJugador2 = pozoJugador2;
        }

        public int getpozoJugador1()
        {
            return pozoJugador1;
        }


        public int getpozoJugador2()
        {
            return pozoJugador2;
        }

        public void setpozojugador1(int pozoJugador1)
        {
            this.pozoJugador1 = pozoJugador1;
        }
        public void setpozojugador2(int pozoJugador2)
        {
            this.pozoJugador2 = pozoJugador2;
        }
    }
}
