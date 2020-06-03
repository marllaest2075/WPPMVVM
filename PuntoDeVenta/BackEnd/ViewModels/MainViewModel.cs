using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Text;
using System.Windows.Input;
using Utilerias;

namespace ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private byte[] logo;

        public byte[] Logo
        {
            get { return logo; }
            set
            {
                if (logo == value)
                    return;
                logo = value;
                Notify();
            }
        }

        private string cabecera;

        public string Cabecera
        {
            get { return cabecera; }
            set
            {
                if (cabecera == value)
                    return;
                cabecera = value;
                Notify();
            }
        }

        private string fb;

        public string FB
        {
            get { return fb; }
            set
            {
                if (fb == value)
                    return;
                fb = value;
                Notify();
            }
        }

        public MainViewModel()
        {
            fb = "#FFD10C0C";

            var url = @"C:\Users\Marti\Pictures\35140f718f9adc99514e055ab7d325e4.jpg";
            logo = Imagenes.FileTo_Bytes(url);
            cabecera = "Punto de Venta";
        }

        private ICommand VerdeCommand;
    }
}