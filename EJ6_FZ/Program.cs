
int[,] bingo = new int[3,9];
Random random = new Random();
int[] valores = new int[15];

int lengthFilas = bingo.GetUpperBound(0) + 1;
int lengthColumnas = bingo.GetUpperBound(1) + 1;
int aux = 0;

for (int i = 0; i < valores.Length; i++)
{
    bool randomPos = true;
    bool loop = true;
    int randomFila = 0;
    int randomColumna = 0;

    while (randomPos == true)
    {
        int vColumna = 0;
        int vFila = 0;
        randomFila = random.Next(lengthFilas);
        randomColumna = random.Next(lengthColumnas);
        while (bingo[randomFila, randomColumna] != 0)
        {
            randomFila = random.Next(lengthFilas);
            randomColumna = random.Next(lengthColumnas);
        }
        for (int filas = 0; filas < lengthFilas; filas++)
        {
            if (bingo[filas, randomColumna] != 0)
                vColumna++;
        }
        for (int columnas = 0; columnas < lengthColumnas; columnas++)
        {
            if (bingo[randomFila, columnas] != 0)
                vFila++; 
        }
        if (vFila >= 5 || vColumna >= 2)
        {
            randomPos = true;
        }
        else
        {
            randomPos = false;
        }
    }
    while (loop == true)
    {
            switch (randomColumna)
        {
            case 0:
                aux = random.Next(1, 9);
                break;
            case 1:
                aux = random.Next(10, 19);
                break;
            case 2:
                aux = random.Next(20, 29);
                break;
            case 3:
                aux = random.Next(30, 39);
                break;
            case 4:
                aux = random.Next(40, 49);
                break;
            case 5:
                aux = random.Next(50, 59);
                break;
            case 6:
                aux = random.Next(60, 69);
                break;
            case 7:
                aux = random.Next(70, 79);
                break;
            case 8:
                aux = random.Next(80, 90);
                break;
        }
        for (int k = 0; k < valores.Length; k++)
        {
            if (valores[k] == aux)
            {
                loop = true;
                break;
            }
            else
            {
                loop = false;
            }
        }
    }
    bingo[randomFila, randomColumna] = aux;
    valores[i] = bingo[randomFila, randomColumna];
}

for (int filas = 0; filas < lengthFilas; filas++)  
{
    Console.WriteLine("----------------------------------------------");
    for (int columnas = 0; columnas < lengthColumnas; columnas++)
    {
    Console.Write($"| {(bingo[filas, columnas] < 10 ? (bingo[filas, columnas] == 0 ? "  " : $"0{bingo[filas, columnas]}") : bingo[filas, columnas])} ");
    }
    Console.Write("|\n");
}
Console.WriteLine("----------------------------------------------");
Console.ReadKey();