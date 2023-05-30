using AppCuadrado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppCuadrado.ViewModels
{
    public class ViewModelCuadrado
    {
        public ViewModelCuadrado()
        {
            crear = new Command(() => {

                Cuadrado C = new Cuadrado(lado);
                Resultado = C.ToString();

            });
        }

        double lado;
        public double Lado {

            get => lado;
            set { 

                lado = value;
                var args = new PropertyChangedEventArgs(nameof(Lado));
                PropertyChanged?.Invoke(this, args);

            }
        
        }

        string resultado;

        public string Resultado{

            get => resultado;
            set
            {

                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);

            }

        }

        public Command crear { get; }


        public event PropertyChangedEventHandler PropertyChanged;

    }
}
