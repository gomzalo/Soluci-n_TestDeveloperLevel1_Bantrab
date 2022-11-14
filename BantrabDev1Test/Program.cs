internal class Program
{
    private static void Main(string[] args)
    {
        // Gonzalo Antonio García Solares
        Console.WriteLine(
            "::::::::::::::::::::::::::::::::::::::::" +
            "\nSolución a prueba para Developer level 1" +
            "\n\t\tGonzalo García" +
            "\n\t\tBANTRAB" +
            "\n::::::::::::::::::::::::::::::::::::::::\n");
        // Declarando y creando matriz de 10 x 3 (filas y columnas)
        int[,] matriz;
        // Agregando datos predeterminados a las columnas 1 y 2
        matriz = new int[10, 3]
        {
            { 1, 2, 0 },
            { 2, 3, 0 },
            { 3, 4, 0 },
            { 4, 5, 0 },
            { 5, 6, 0 },
            { 6, 7, 0 },
            { 7, 8, 0 },
            { 8, 9, 0 },
            { 9, 10, 0 },
            { 10, 11, 0 }
        };
        // Mostrando la matriz con los datos
        Console.WriteLine("Matriz inicial\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Llenando la columna 3 con la suma de las columnas 1 y 2
        for (int i = 0; i < 10; i++)
        {
            matriz[i, 2] = matriz[i, 0] + matriz[i, 1];
        }
        // Mostrando la matriz con los datos
        Console.WriteLine("\nLlenando la columna 3 con la suma de las columnas 1 y 2.\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Creando la variable "total"
        int total = 0;
        // Sumando los valores de la columna 3 y guardando en la variable "total"
        for (int i = 0; i < 10; i++)
        {
            total += matriz[i, 2];
        }
        Console.WriteLine("\nLa suma de los valores de la columna 3 es: " + total + "\n");
        // Creando dos filas vacias y una nueva columna
        int[,] newMatriz;
        newMatriz = new int[12, 4];
        // Copiando los valores de la matriz original a la nueva matriz
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                newMatriz[i, j] = matriz[i, j];
            }
        }
        // Mostrando nueva matriz
        Console.WriteLine("Matriz redimensionada, con 2 filas y 1 columna agregadas.\n");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(newMatriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Trasladando los valores de las [filas 1 y 2][columna 1] hacia las filas nuevas.
        for (int i = 0; i < 2; i++)
        {
            if(i == 0)
            {
                newMatriz[10, 0] = newMatriz[i, 0];
                newMatriz[i, 0] = 0;
            }
            else if (i == 1)
            {
                newMatriz[11, 0] = newMatriz[i, 0];
                newMatriz[i, 0] = 0;
            }
        }
        // Mostrando matriz con filas trasladadas
        Console.WriteLine("\nMatriz con [filas 1 y 2][columna 1] trasladadas a nuevas filas.\n");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(newMatriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Calculando el total de las [filas 1 y 2][columna 2]
        int totalF1y2C2 = newMatriz[0, 1] + newMatriz[1,1];
        // Eliminando el total de las [filas 1 y 2][columna 2]
        newMatriz[0, 1] = 0;
        newMatriz[1, 1] = 0;
        // Mostrando el total
        Console.WriteLine("\nTotal de [filas 1 y 2][columna 2]: " + totalF1y2C2);
        // Dividiendo el total del inciso anterior y colocar en partes iguales en las [filas 3 a 7][columna 4]
        int numFilasC4 = 5; // Número de filas (3 a 7 = 5) a llenar en la columna 4.
        int valorFilasC4 = totalF1y2C2 / numFilasC4; // Valor a colocar en las [filas 3 a 7][columna 4]
        // Llenando las [filas 3 a 7][columna 4]
        for (int i = 2; i < 7; i++)
        {
            newMatriz[i, 3] = valorFilasC4;
        }
        // Mostrando matriz con las [filas 3 a 7][columna 4] llenas
        Console.WriteLine("\nMatriz con las [filas 3 a 7][columna 4] llenas.\n");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(newMatriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Llenar la columna 3 con la suma de las columnas 1, 2 y 4
        for (int i = 0; i < 12; i++)
        {
            newMatriz[i, 2] = newMatriz[i, 0] + newMatriz[i, 1] + newMatriz[i, 3];
        }
        // Calcular el total de la columna 3 en la variable "total"
        total = 0;
        for (int i = 0; i < 12; i++)
        {
            total += newMatriz[i, 2];
        }
        // Mostrando el total
        Console.WriteLine("\nTotal de la columna 3: " + total + "\n");
        // Mostrando la matriz final
        Console.WriteLine("\nMatriz final\n");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(newMatriz[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}