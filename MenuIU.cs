/// <summary>
/// Introducción de un menú
/// </summary>
static void IUMenu()
        {
            while (opcion != 3)
            {
            	Console.WriteLine("1. Opción 1");
            	Console.WriteLine("2. Opción 2");
            	Console.WriteLine("3. Opción 3");
            	Console.WriteLine("4. Opción 4");
            	Console.WriteLine("5. Salir");
            
            	// Elegir opción para el menú
              opcion = ObtenerNum(0, 6);
              Console.WriteLine("Has elegido la opción " + opcion);
              Console.ReadLine();
              Console.Clear();

            	 // Si la opción no es de salida...
            	 if (opcion != 5)
            	 {
            	     GestionOp(opcion);
            	 }
             
             }
             
            Console.WriteLine("Saliendo del programa...");
            Console.ReadLine();
        }

/// <summary>
/// Obteniendo números
/// </summary>
/// <param name="min">Mínimo a introducir</param>
/// <param name="max">Máximo a introducir</param>
/// <returns>Número resultante</returns>
        static int ObtenerNum(int min, int max)
        {
            int num = 0;

            Console.Write("Introduzca su número: ");

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Número no válido");
            }
            while (num <= min || num >= max)
            {
                Console.Write("Número no válido, ha de ser entre {0} y {1}: ", min, max);
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Número no válido");
                }
            }
            return num;

        }
