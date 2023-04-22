int[,] tablero = new int[5, 5];

void paso1_crear_tab()
{
    for(int f=0; f< tablero.GetLength(0); f++)
    {
        for (int c=0; c< tablero.GetLength(1); c++) { 
            tablero[f,c] = 0; }
    }
}

void paso2_colocar_barcos()
{
    tablero[4, 3] = 1;
    tablero[1,1] = 1;
    tablero[2,1] = 1;
    tablero[3,4] = 1;
    
}

void paso3_imprimir_tab()
{
    String caracter_imprimir;
    for (int f=0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:
                    caracter_imprimir = "~";
                    break;
                    case 1:
                    caracter_imprimir = "-";
                    break;
                case -1:
                    caracter_imprimir = "*";
                    break;
                case -2:
                    caracter_imprimir = "X";
                    break;
                default:
                    caracter_imprimir = "~";
                    break;

            }
            Console.Write(caracter_imprimir + " ");
        }
        Console.WriteLine();
    }
}

void paso4_ingreso_cords()
{
    int fila, columna = 0;
    Console.Clear();
    do
    {
        Console.WriteLine("Ingrese la Fila: ");
        fila=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la columna: ");
        columna=Convert.ToInt32(Console.ReadLine());
        if (tablero[fila, columna] == 1)
        {
            Console.Beep();
            tablero[fila, columna] = -1; //Bandera que ya le dio
        }
        else
        {
            tablero[fila,columna] = -2; //Fallo
        }
        Console.Clear ();
        paso3_imprimir_tab();
    } while(true);
}
//Gonzalo Isaí Jiménez García 0905-21-1116

paso1_crear_tab();
paso2_colocar_barcos();
paso3_imprimir_tab();
paso4_ingreso_cords();