using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace snake_game
{
    public class Comida
    {
        private int x, y, width, height; // posicion y coordenadas
        private SolidBrush pincel;// dibuja la comida
        public Rectangle comidarec;//la comida

        public Comida(Random randFood) // creacion de la primera comida
        {
            x = randFood.Next(0, 29) * 10;// posicion aleatoria de izquierda o derecha
            y = randFood.Next(0, 29) * 10;// posicion aleatoria de arriba o abajo
            pincel = new SolidBrush(Color.Red); // color de la comida
            width = 10; // ancho de la comida
            height=10;  // alto de la comida
            comidarec = new Rectangle(x, y, width, height); // se crea el objeto comida con sus parametros
}
        public void locaciondecomida(Random randFood) // posicion de la comida
        {
            x = randFood.Next(0, 29) * 10;// posicion aleatoria de izquierda o derecha
            y = randFood.Next(0, 29) * 10;// posicion aleatoria de arriba o abajo
        
        }

        public void dibujodecomida(Graphics paper)// dibujo de la comida en el papel (campo de juego)
        {
            comidarec.X = x;// posicion aleatoria de izquierda o derecha
            comidarec.Y = y;// posicion aleatoria de arriba o abajo

            paper.FillRectangle(pincel, comidarec); // dibujo de la comida en el papel 
        }
        
    }
}
