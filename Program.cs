Hospede h = new Hospede();
h.ReceberDados();

Reserva r = new Reserva();
r.ReceberDadosReserva();
r.CalcularTotal();

h.MostrarDados();
r.MostrarReserva();

Console.WriteLine("\nPressione qualquer tecla para fechar...");
Console.ReadKey();