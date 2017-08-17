using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Alien
    {   
        private int dir = 1;

        private int posX;
        public int PosX 
        { 
            get 
            {
                return posX;
            } 
        }

        private int posY;
        public int PosY 
        {
            get
            {
                return posY;
            }
        }

        public void Andar() 
        {
           
            if((dir % 2) == 1)
                AndDir();

            else
                AndEsq();

            if (posX == 1024 || posX == 0)
            {
                dir++;
                posY--;
            }
        }

        private void AndDir()
        {
            posX++;
        }

        private void AndEsq()
        {
            posX--;
        }

        public void Atirar()
        {
            Disparo tiroNave = new Disparo();
        }
        
        public Alien(int posIn)
        {
            posX = posIn;
            posY = 0;
        }
    }
}
