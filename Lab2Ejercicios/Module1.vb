Module Module1

    Sub Main()
        FunVelocidad()
        FunInfracciones()
        FunModulo()
        FunNumbers()

        Console.WriteLine("")
        Console.WriteLine("Estdiante: Luis Enrique Lopez Alvarado")
    End Sub
    Sub FunVelocidad()
        'Un corredor de maratón ha hecho un recorrido de 42,195 Km en un tiempo T
        '(dado en horas y en minutos). 

        Console.WriteLine("CALCULO DE VELOCIDAD DE CORREDOR")
        Dim h As Integer
        Dim m As Integer

        Dim tiempoH, tiempoM, tiempoS, kmh, kmm, kms, mt_m, M_s As Double

        Console.WriteLine("Ingrese el numero de horas")
        h = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad en minutos")
        m = Console.ReadLine()

        tiempoH = h + (m / 60)
        tiempoM = (h * 60) + m
        tiempoS = (h * 3600) + (m * 60)

        kmh = 42.195 / tiempoH
        kmm = 42.195 / tiempoM
        kms = 42.195 / tiempoS
        mt_m = 42195 / tiempoM
        M_s = 42195 / tiempoS

        Console.WriteLine("El promedio de km/h es : " & kmh)
        Console.WriteLine("El promedio de km/m es : " & kmm)
        Console.WriteLine("El promedio de km/s es : " & kms)
        Console.WriteLine("El promedio de m/min es : " & mt_m)
        Console.WriteLine("El promedio de m/s es : " & M_s)

    End Sub

    Sub FunInfracciones()
        'Un policía de tránsito reporta a la central un promedio de N infracciones en el mes,
        'de las cuales el 20% se producen en las horas de la mañana, el 35% se producen en horas
        'de la tarde y el 45% restante se producen en horas de la noche. 

        Console.WriteLine("CALCULO DE INFRACCIONES POR TURNO")
        Dim Infracciones As Integer
        Dim Infraccion1, Infraccion2, Infraccion3 As Double

        Console.WriteLine("Estudiante ingrese la cantidad de infracciones ")
        Infracciones = Console.ReadLine()

        'Calculando los promedios

        Infraccion1 = (Infracciones * 0.2) / 30
        Infraccion2 = (Infracciones * 0.35) / 30
        Infraccion3 = (Infracciones * 0.45) / 30

        Console.WriteLine("El promedio diario matutino de  infracciones  es de : " & Math.Round(Infraccion1, 2))
        Console.WriteLine("El promedio diario en la tarde de  infracciones  es de : " & Math.Round(Infraccion2, 2))
        Console.WriteLine("El promedio diario nocturno de  infracciones  es de : " & Math.Round(Infraccion3, 2))

    End Sub

    Sub FunModulo()

        Console.WriteLine("CALCULO DE NUMERO DIVISOR")
        'programa que determine, al recibir como datos dos números enteros, si un número es divisor de otro. 

        Dim N1, N2 As Integer

        Console.WriteLine("Ingrese el primer numero")
        N1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        N2 = Console.ReadLine()

        If (N1 Mod N2) = 0 Then

            Console.WriteLine("El numero " & N2 & " es divisor de " & N1)

        Else

            Console.WriteLine("El numero " & N2 & " no es divisor de " & N1)

        End If

    End Sub

    Sub FunNumbers()

        Console.WriteLine("CALCULO DE NUMERO MAYOR - MEDIO - MENOR")
        'programa que, al recibir como datos de entrada tres valores enteros diferentes entre sí,
        'determine cual es el mayor, medio, menor, sin importar el orden de entrada.

        Dim a, b, c As Integer

        Console.WriteLine("ingrese el primer dato")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo dato")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer dato")
        c = Console.ReadLine()

        If a > b And a > c Then
            Console.WriteLine("El numero mayor es " & a)
            If b > c Then
                Console.WriteLine("El numero intermedio es " & b)
                Console.WriteLine("El numero menor es " & c)
            Else
                Console.WriteLine("El numero intermedio es " & c)
                Console.WriteLine("El numero menor es " & b)

            End If

        End If

        If b > a And b > c Then
            Console.WriteLine("El numero mayor es  " & b)
            If a > c Then
                Console.WriteLine("El numero intermedio es " & a)
                Console.WriteLine("El numero menor es " & c)
            Else
                Console.WriteLine("El numero intermedio es " & c)
                Console.WriteLine("El numero menor es " & a)

            End If

        End If

        If c > a And c > b Then
            Console.WriteLine("El numero mayor es  " & c)

            If a > b Then
                Console.WriteLine("El numero intermedio es " & a)
                Console.WriteLine("El numero menor es " & b)
            Else
                Console.WriteLine("El numero intermedio es " & b)
                Console.WriteLine("El numero menor es " & a)

            End If
        End If
    End Sub

End Module
