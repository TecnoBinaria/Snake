using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; // using que se usa para  dibujar

namespace snake_game
{
   public class snake
   {
       private Rectangle[] snakeRec;// la serpiente
       private SolidBrush pincel; // "pincel" con el que se pinta 
       private int x, y, width, height;// coordenadas y posicion
      
       public Rectangle[] SnakeRec // returna la serpiente actual
       {
           get { return snakeRec; }
       
       }

       public snake()
       {
           snakeRec = new Rectangle[3];// tamaño inicial de la serpiente
           pincel = new SolidBrush(Color.Black);// color de la serpiente

           x = 20; // posicion de izquierda o derecha
           y = 0; // posicion de arriba o abajo
           width = 10; // ancho
           height = 10; //altura
           for (int i = 0; i < snakeRec.Length; i++) // creacion de cada rectangulo que comprende ala serpiente
           {
               snakeRec[i] = new Rectangle(x, y, width, height);// se guarda en el arreglo serpiente cada uno se sus rectangulos
               x -= 10;
           }
       }
       public void dibujaSnake(Graphics papel) // dibuja ala serpiente en el "papel" (campo de juego)
       {
           foreach (Rectangle rec in snakeRec)
           {
               papel.FillRectangle(pincel, rec);// dibuja ala serpiente en el "papel"
           }
       }

       public void dibujaSnake() // dibuja ala serpiente en el "papel" (campo de juego) -- REPOCISIONA
       
       {
           for (int i = snakeRec.Length - 1; i > 0; i--)
           {
               snakeRec[i] = snakeRec[i - 1];// dibuja ala serpiente en el "papel"  -- REPOCISIONA
           }
       }

       // movimiento de la serpiente
       public void movimientoabajo()// pocisiona la cabeza hacia abajo
       {
           dibujaSnake();
           snakeRec[0].Y += 10; // suma 10 en la posicion "y" por lo que baja 
       }
       public void movimientoarriba()// pocisiona la cabeza hacia arriba
       {
           dibujaSnake();
           snakeRec[0].Y -= 10; // resta 10 en la posicion "y" por lo que sube 
       }
       public void movimientoizquierda()// pocisiona la cabeza hacia la izquierda
       {
           dibujaSnake();
           snakeRec[0].X -= 10;// resta 10 en la posicion "x" por lo que va ala izquierda
       }
       public void movimientoderecha()// pocisiona la cabeza hacia la derecha
       {
           dibujaSnake();
           snakeRec[0].X += 10;// suma 10 en la posicion "x" por lo que va ala derecha
       }
       public void crecimientodeSnake()// agrega un rectangulo mas ala serpiente
       {
           List<Rectangle> rec = snakeRec.ToList();
           rec.Add(new Rectangle(snakeRec[snakeRec.Length-1].X,snakeRec[snakeRec.Length-1].Y,width,height));
           snakeRec = rec.ToArray();
       
       }
    }
}
