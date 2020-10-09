using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desktop_UI
{
    public class WinApi
    {
        // Hace que una ventana sea hija (o esté contenida) en otra
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        // Devuelve el Handle (hWnd) de una ventana de la que sabemos el título
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        // Cambia el tamaño y la posición de una ventana
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static int MoveWindow(IntPtr hWnd, int x, int y,
                int nWidth, int nHeight, int bRepaint);
    }
}
