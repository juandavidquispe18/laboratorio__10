using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio__10
{
    internal class Formula01
    {
        static int totalVentasMPhones = 0;
        static int totalVentasMPads = 0;
        static int totalVentasMAPBrooks = 0;
        static int totalVentasMWatches = 0;
        static int totalVentasProductos = 0;

        public static int menu_principal()
        {

            Console.WriteLine("" +
                "================================\n" +
                "Productos de mPhone:\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5: Salir\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return altern_1();
        }

        public static int mPhone_3000_a()
        {

            Console.WriteLine("" +
                    "================================\n" +
                    "Registrar Venta de mPhone 3000\n" +
                    "================================\n" +
                    "1: Registrar Venta\n" +
                    "2: Registrar Devolución\n" +
                    "3: Menu Principal\n" +
                    "================================\n" +
                    "Ingrese una opción:\n");
            return altern_1();
        }

        public static int mPad_3500_a()
        {

            Console.WriteLine("" +
                    "================================\n" +
                    "Registrar Venta de mPad 3500\n" +
                    "================================\n" +
                    "1: Registrar Venta\n" +
                    "2: Registrar Devolución\n" +
                    "3: Menu Principal\n" +
                    "================================\n" +
                    "Ingrese una opción:\n");
            return altern_1();
        }

        public static int MAPBrook_3800_a()
        {

            Console.WriteLine("" +
                "================================\n" +
                "Registrar Venta de MAPBrook 3800\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return altern_1();
        }

        public static int mWatch_8000_a()
        {
            Console.WriteLine("" +
                "================================\n" +
                "Registrar Venta de mWatch 8000\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return altern_1();
        }

        public static int altern_1()
        {

            string opciontexto = Console.ReadLine();
            Console.Clear();
            return int.Parse(opciontexto);
        }

        public static void form_a()
        {

            Console.WriteLine("" +
                "================================\n" +
                "Registrar devolución de:\n" +
                "================================\n" +
                "Se va a registrar la devolución de");
            return;
        }

        public static void form_ab()
        {

            Console.WriteLine("" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return;
        }

        public static void form_abc()
        {

            Console.WriteLine("" +
                "================================\n" +
                "Registrar venta de:\n" +
                "================================\n" +
                "Se va a registrar la venta de");
            return;
        }
    }
}
