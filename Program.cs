using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_ventas_mPhones = 0;
            int total_devolucion_mPhones = 0;
            int total_ventas_mPads = 0;
            int total_devolucion_mPads = 0;
            int total_ventas_MAPBrooks = 0;
            int total_devolucion_MAPbrooks = 0;
            int total_ventas_mWatches = 0;
            int total_devolucion_mWatches = 0;
            int total_ventas_productos;
            int altern;
            int altern_a;
            int altern_b;
            int altern_c;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;


            do
            {
                altern = Formula01.menu_principal();
                Console.Clear();
                switch (altern)
                {
                    case 1:

                        Formula01.mPhone_3000_a();
                        altern_a = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (altern_a)
                        {
                            case 1:

                                Formula01.form_abc();
                                Console.WriteLine("un mPhone 3000 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_b = int.Parse(Console.ReadLine());

                                if (altern_b == 1)
                                {
                                    total_ventas_mPhones++;
                                }

                                Console.Clear();
                                break;

                            case 2:

                                Formula01.form_a();
                                Console.WriteLine("un mPhone 3000 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_c = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (altern_c == 1)
                                {
                                    total_devolucion_mPhones++;
                                }
                                break;
                        }
                        total1 = total_ventas_mPhones - total_devolucion_mPhones;
                        break;

                    case 2:

                        Formula01.mPad_3500_a();
                        altern_a = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (altern_a)
                        {
                            case 1:
                                Formula01.form_abc();
                                Console.WriteLine("un mPad 3500 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_b = int.Parse(Console.ReadLine());

                                if (altern_b == 1)
                                {
                                    total_ventas_mPads++;
                                }

                                Console.Clear();
                                break;

                            case 2:

                                Formula01.form_a();
                                Console.WriteLine("un mPad 3500 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_c = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (altern_c == 1)
                                {
                                    total_devolucion_mPads++;
                                }
                                break;
                        }
                        total2 = total_ventas_mPads + total_devolucion_mPads;
                        break;

                    case 3:

                        Formula01.MAPBrook_3800_a();
                        altern_a = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (altern_a)
                        {
                            case 1:

                                Formula01.form_abc();
                                Console.WriteLine("un MAPBrook 3800 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_b = int.Parse(Console.ReadLine());

                                if (altern_b == 1)
                                {
                                    total_ventas_MAPBrooks++;
                                }

                                Console.Clear();
                                break;

                            case 2:

                                Formula01.form_a();
                                Console.WriteLine("un MAPBrook 3800 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_c = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (altern_c == 1)
                                {
                                    total_devolucion_MAPbrooks++;
                                }
                                break;
                        }
                        total4 = total_ventas_MAPBrooks - total_devolucion_MAPbrooks;
                        break;

                    case 4:

                        Formula01.mWatch_8000_a();
                        altern_a = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (altern_a)
                        {
                            case 1:

                                Formula01.form_abc();
                                Console.WriteLine("un mWatch 8000 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_b = int.Parse(Console.ReadLine());

                                if (altern_b == 1)
                                {
                                    total_ventas_mWatches++;
                                }

                                Console.Clear();
                                break;

                            case 2:

                                Formula01.form_a();
                                Console.WriteLine("un mWatch 8000 ¿Desea Continuar?");
                                Formula01.form_ab();
                                altern_c = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (altern_c == 1)
                                {
                                    total_devolucion_mWatches++;
                                }
                                break;
                        }
                        total4 = total_ventas_mWatches - total_devolucion_mWatches;
                        break;

                    case 5:

                        Console.WriteLine("================================");
                        Console.WriteLine("Reporte Final");
                        Console.WriteLine("================================");
                        Console.WriteLine("Productos Vendidos | Cantidad");
                        Console.WriteLine("================================");
                        Console.WriteLine("mPhones            | " + total_ventas_mPhones);
                        Console.WriteLine("mPads              | " + total_ventas_mPads);
                        Console.WriteLine("MAPBrooks          | " + total_ventas_MAPBrooks);
                        Console.WriteLine("mWatches           | " + total_ventas_mWatches);
                        total_ventas_productos = total1 + total2 + total3 + total4;
                        Console.WriteLine("================================");
                        Console.WriteLine("Total              | " + total_ventas_productos);
                        Console.WriteLine("================================\n" +
                            "¡Hasta Luego!\n\n\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Diseñado por: Juan David Q.A.");
                        Console.ReadKey();
                        break;
                }
            }
            while (altern != 5);
            {

            }
        }
    }
}
