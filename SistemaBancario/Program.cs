using System;

// ============================================================
//  ABSTRACCIÓN — clase abstracta que define el contrato
//  de cualquier cuenta bancaria
// ============================================================
abstract class CuentaBancaria
{
    private string _numeroCuenta;
    private double _saldo;

    public string NumeroCuenta
    {
        get { return _numeroCuenta; }
        private set { _numeroCuenta = value; }
    }

    public double Saldo
    {
        get { return _saldo; }
        protected set { _saldo = value; }
    }

    public string Titular { get; private set; }

    public CuentaBancaria(string numeroCuenta, string titular, double saldoInicial)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldoInicial;
    }

   
    public void Depositar(double monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser mayor a cero.");
            return;
        }
        Saldo += monto;
        Console.WriteLine($"  Depósito de {monto:C} realizado. Saldo actual: {Saldo:C}");
    }


    public abstract void Retirar(double monto);

    
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"  Cuenta   : {NumeroCuenta}");
        Console.WriteLine($"  Titular  : {Titular}");
        Console.WriteLine($"  Saldo    : {Saldo:C}");
    }
}

// ============================================================
//  HERENCIA — CuentaAhorros hereda de CuentaBancaria
// ============================================================
class CuentaAhorros : CuentaBancaria
{
    public double TasaInteres { get; private set; }

    public CuentaAhorros(string numeroCuenta, string titular,
                         double saldoInicial, double tasaInteres)
        : base(numeroCuenta, titular, saldoInicial)
    {
        TasaInteres = tasaInteres;
    }

   
    public override void Retirar(double monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto debe ser mayor a cero.");
            return;
        }
        if (monto > Saldo)
        {
            Console.WriteLine("  Saldo insuficiente para el retiro.");
            return;
        }
        Saldo -= monto;
        Console.WriteLine($"  Retiro de {monto:C} realizado. Saldo actual: {Saldo:C}");
    }

    public void AplicarInteres()
    {
        double interes = Saldo * TasaInteres;
        Saldo += interes;
        Console.WriteLine($"  Interés aplicado ({TasaInteres:P0}): +{interes:C}. Saldo: {Saldo:C}");
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"  Tipo     : Cuenta de Ahorros");
        Console.WriteLine($"  Interés  : {TasaInteres:P0}");
    }
}

// ============================================================
//  HERENCIA — CuentaCorriente hereda de CuentaBancaria
// ============================================================
class CuentaCorriente : CuentaBancaria
{
    public double LimiteDescubierto { get; private set; }

    public CuentaCorriente(string numeroCuenta, string titular,
                           double saldoInicial, double limiteDescubierto)
        : base(numeroCuenta, titular, saldoInicial)
    {
        LimiteDescubierto = limiteDescubierto;
    }
    public override void Retirar(double monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto debe ser mayor a cero.");
            return;
        }
        if (monto > Saldo + LimiteDescubierto)
        {
            Console.WriteLine("  Retiro supera el límite de descubierto permitido.");
            return;
        }
        Saldo -= monto;
        Console.WriteLine($"  Retiro de {monto:C} realizado. Saldo actual: {Saldo:C}");
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"  Tipo       : Cuenta Corriente");
        Console.WriteLine($"  Descubierto: {LimiteDescubierto:C}");
    }
}

// ============================================================
//  ENCAPSULAMIENTO — clase con datos privados y acceso
//                    controlado mediante métodos y propiedades
// ============================================================
class Cliente
{
    private string _nombre;
    private string _cedula;
    private string _email;

    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("El nombre no puede estar vacío.");
            else
                _nombre = value;
        }
    }

    public string Cedula
    {
        get { return _cedula; }
        private set { _cedula = value; }
    }

 
    public string Email
    {
        get { return _email; }
        set
        {
            if (value.Contains("@"))
                _email = value;
            else
                Console.WriteLine("Email inválido.");
        }
    }

    public Cliente(string nombre, string cedula, string email)
    {
        Nombre = nombre;
        Cedula = cedula;
        Email = email;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"  Cliente  : {Nombre}");
        Console.WriteLine($"  Cédula   : {Cedula}");
        Console.WriteLine($"  Email    : {Email}");
    }
}

// ============================================================
//  Clase de soporte — Transaccion (registro simple)
// ============================================================
class Transaccion
{
    public string Tipo { get; private set; }
    public double Monto { get; private set; }
    public string Cuenta { get; private set; }
    public DateTime Fecha { get; private set; }

    public Transaccion(string tipo, double monto, string cuenta)
    {
        Tipo = tipo;
        Monto = monto;
        Cuenta = cuenta;
        Fecha = DateTime.Now;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"  [{Fecha:dd/MM/yyyy HH:mm}] {Tipo} de {Monto:C} en cuenta {Cuenta}");
    }
}

// ============================================================
//  -------------------PROGRAMA PRINCIPAL----------------------
// ============================================================
class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA BANCARIO ===\n");

        Console.WriteLine(">> Creando clientes...");
        Cliente cliente1 = new Cliente("Ana Pérez", "001-1234567-8", "ana@email.com");
        Cliente cliente2 = new Cliente("Luis García", "002-9876543-1", "luis@email.com");
        cliente1.MostrarInfo();
        Console.WriteLine();
        cliente2.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine(">> Creando cuentas...");
        CuentaAhorros cuentaAna = new CuentaAhorros("AH-001", "Ana Pérez", 50000, 0.03);
        CuentaCorriente cuentaLuis = new CuentaCorriente("CC-002", "Luis García", 20000, 5000);

        Console.WriteLine("Info cuenta Ana:");
        cuentaAna.MostrarInfo();

        Console.WriteLine("Info cuenta Luis:");
        cuentaLuis.MostrarInfo();

        Console.WriteLine(">> Operaciones en cuenta de ahorros (Ana):");
        cuentaAna.Depositar(10000);
        cuentaAna.Retirar(5000);
        cuentaAna.AplicarInteres();

        Console.WriteLine(">> Operaciones en cuenta corriente (Luis):");
        cuentaLuis.Depositar(3000);
        cuentaLuis.Retirar(25000);   
        cuentaLuis.Retirar(30000);   

     
        Console.WriteLine("\n>> Listado polimórfico de cuentas:");
        CuentaBancaria[] cuentas = { cuentaAna, cuentaLuis };
        foreach (CuentaBancaria c in cuentas)
        {
            Console.WriteLine("---");
            c.MostrarInfo();           
        }

        Console.WriteLine("\n>> Historial de transacciones:");
        Transaccion t1 = new Transaccion("Depósito", 10000, "AH-001");
        Transaccion t2 = new Transaccion("Retiro", 5000, "AH-001");
        Transaccion t3 = new Transaccion("Depósito", 3000, "CC-002");
        Transaccion t4 = new Transaccion("Retiro", 25000, "CC-002");

        t1.MostrarInfo();
        t2.MostrarInfo();
        t3.MostrarInfo();
        t4.MostrarInfo();

        Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
    }
}