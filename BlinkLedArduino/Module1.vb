Imports System.IO.Ports

Module Module1

    Sub Main()
        Dim USE_SERIAL As SerialPort
        USE_SERIAL = New SerialPort()
        Dim pinout As String
        Dim rta As String = "LOW"

        USE_SERIAL.PortName = "COM5"
        USE_SERIAL.Open()

        Console.WriteLine("En que pin se encuentra su led:")
        pinout = Console.ReadLine()
        USE_SERIAL.WriteLine(pinout + "p")

        While (rta = "HIGH" Or rta = "LOW")

            Console.WriteLine("Indique el estado del led(HIGH/LOW) en caso de finalizar, escriba fin")
            rta = Console.ReadLine()
            rta = rta.ToUpper()
            USE_SERIAL.WriteLine(rta)
        End While

        Console.WriteLine("Finalizando programa")

    End Sub

End Module
