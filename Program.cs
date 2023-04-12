//void matriz()
//{
//    string[] nombre = new string[]
//    {
//   "Anderson","Brandon","Yeimi","Fatima","Vivian"
//    };

//    foreach (string n in nombre)
//    {
//        Console.WriteLine("nombre=" + n);
//    }

//    int[] notas = new int[]
//    {
//        50,90,85,73,61
//    };
//    int promedio = 0;
//    int maxNota = notas[0];
//    string nombreMaxNota = nombre[0];
//    foreach (int n in notas)
//    {
//        if (n > maxNota)
//        {
//            maxNota = n;
//            nombreMaxNota = nombre[Array.IndexOf(notas, n)];
//        }
//        promedio += n;
//    }

//    promedio = promedio / notas.Length;
//    Console.WriteLine("el promedio=" + promedio);
//    Console.WriteLine("la nota maxima es = " + maxNota + " y la persona es " + nombreMaxNota);

//}

//matriz();

void matriz()
{
    Console.Write("Ingrese la cantidad de alumnos: ");
    int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

    string[] nombre = new string[cantidadAlumnos];
    int[] notas = new int[cantidadAlumnos];

    for (int i = 0; i < cantidadAlumnos; i++)
    {
        Console.Write("Ingrese el nombre del alumno " + (i + 1) + ": ");
        nombre[i] = Console.ReadLine();

        Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }

    int promedio = 0;
    int maxNota = notas[0];
    string nombreMaxNota = nombre[0];
    int minNota = notas[0];
    string nombreMinNota = nombre[0];

    foreach (int n in notas)
    {
        if (n > maxNota)
        {
            maxNota = n;
            nombreMaxNota = nombre[Array.IndexOf(notas, n)];
        }

        if (n < minNota)
        {
            minNota = n;
            nombreMinNota = nombre[Array.IndexOf(notas, n)];
        }

        promedio += n;
    }

    promedio = promedio / notas.Length;
    Console.WriteLine("el promedio=" + promedio);
    Console.WriteLine("la nota maxima es = " + maxNota + " y la persona es " + nombreMaxNota);
    Console.WriteLine("la nota minima es = " + minNota + " y la persona es " + nombreMinNota);
}

matriz();