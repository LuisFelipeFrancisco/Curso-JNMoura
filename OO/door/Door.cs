using System;

/*
 * Crie uma classe que atenda aos requisitos abaixo:
 * Classe: Porta
 * Atributos: aberta, cor
 * Métodos: void abrir(), void fechar(), void pintar(string cor)
 * Para testar a classe, crie um objeto porta, abra e feche a mesma e pinte‐a de diversas cores.
 * Importante: Defina os tipos dos atributos conforme sua necessidade e lembre-se: uma porta que
 * já está aberta não pode abrir novamente, como também, uma porta que já está fechada não pode ser fechada novamente.
*/

namespace door
{
    internal class Door
    {
        private bool Open;
        private string Color;

        public Door()
        {
            this.Open = false;
            this.Color = null;
        }

        public Door(bool open, string color)
        {
            this.Open = open;
            this.Color = color;
        }

        public void OpenDoor()
        {
            this.Open = true;
        }

        public void CloseDoor()
        {
            this.Open = false;
        }

        public void PaintDoor(string color)
        {
            this.Color = color;
        }

        public string getColor()
        {
            return this.Color;
        }

        public bool isOpen()
        {
            return this.Open;
        }

        public void PrintDoor()
        {
            Console.WriteLine($"Door is open: {this.Open}");
            Console.WriteLine($"Door color: {this.Color}");
        }
    }
}
