using System;
using System.Threading;

public class Program
{
    static void Main()
    {
        PacienteUCI paciente = new PacienteUCI();
        int ciclos = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("|---MONITOR UCI - SIGNOS VITALES----|");
        Console.WriteLine("=====================================");

        while (true)
        {
            ciclos++;
            Console.WriteLine($"--- CICLO {ciclos} ---");

            
            paciente.ActualizarSignosVitales();

            
            paciente.EvaluarEstado();

            
            paciente.MostrarEstadoPaciente();

            Console.WriteLine("(Presiona ESC para salir...)");
            Thread.Sleep(5000); 

            
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        Console.WriteLine("========================================");
        Console.WriteLine("|--------SIMULACIÓN FINALIZADA---------|");
        Console.WriteLine("========================================");
    }
}

public class PacienteUCI
{
    protected int FrecuenciaCardiaca;
    protected int PresionSistolica;

    private Random random = new Random();
    private string estado = "En monitoreo";
    private int ciclosEstables = 0;  
    public void ActualizarSignosVitales()
    {
        
        FrecuenciaCardiaca = random.Next(40, 151);    
        PresionSistolica = random.Next(60, 181);        

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"   FC: {FrecuenciaCardiaca} lpm  |  PS: {PresionSistolica} mmHg");
        Console.ResetColor();
    }

    public void EvaluarEstado()
    {
        
        if (FrecuenciaCardiaca > 120 && PresionSistolica < 90)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   [!] ¡ALERTA DE SHOCK CARDIOGÉNICO!");
            Console.ResetColor();
            estado = "Crítico";
            ciclosEstables = 0;  
        }
        
        else if (FrecuenciaCardiaca < 50 && PresionSistolica > 140)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   [!] ¡ALERTA DE BRADICARDIA HIPERTENSIVA!");
            Console.ResetColor();
            estado = "Crítico";
            ciclosEstables = 0;  
        }
   
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   Signos vitales en rango normal");
            Console.ResetColor();

            
            ciclosEstables++;

            
            if (ciclosEstables >= 4)
            {
                estado = "Estable";
            }
            else
            {
                estado = "En monitoreo";
            }
        }
    }

    public void MostrarEstadoPaciente()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"   Estado del paciente: {estado}");

        if (estado != "Crítico") 
        {
            Console.WriteLine($"   Ciclos estables: {ciclosEstables}/4");
        }

        Console.ResetColor();
    }
}
 