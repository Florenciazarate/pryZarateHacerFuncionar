using System.Drawing;
using System.IO;

namespace pryFernandezIES.Properties
{
    internal static class Resources
    {
        private static string GetPath(string fileName)
        {
            return Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
        }

        private static Bitmap LoadBitmap(string fileName)
        {
            return (Bitmap)Image.FromFile(GetPath(fileName));
        }

        internal static Bitmap archivo_removebg_preview => LoadBitmap("archivo-removebg-preview.png");
        internal static Bitmap Blue => LoadBitmap("Blue.gif");
        internal static Bitmap candado__1_ => LoadBitmap("candado (1).png");
        internal static Bitmap carpeta_removebg_preview => LoadBitmap("carpeta-removebg-preview.png");
        internal static Bitmap cerrar => LoadBitmap("cerrar.png");
        internal static Bitmap circle_1700_512 => LoadBitmap("circle-1700_512.gif");
        internal static Bitmap flecha_izquierda => LoadBitmap("flecha-izquierda.png");
        internal static Bitmap imgLogoSeguro => LoadBitmap("imgLogoSeguro.jpg");
        internal static Bitmap logo_bbva_fondo_2 => LoadBitmap("logo-bbva-fondo-2.jpg");
        internal static Bitmap minimazar => LoadBitmap("minimazar.png");
        internal static Bitmap numero_1__1_ => LoadBitmap("numero-1 (1).png");
        internal static Bitmap numero_2__1_ => LoadBitmap("numero-2 (1).png");
        internal static Bitmap usuario__3_ => LoadBitmap("usuario (3).png");
    }
}
