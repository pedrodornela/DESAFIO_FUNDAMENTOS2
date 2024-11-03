using DESAFIO_FUNDAMENTOS2.Models;

// Cria os modelos de hóspedes e cadastra na lita de hóspedes
List<Pessoa> hospedes = new();

Pessoa p1 = new (nome: "Pedro");
Pessoa p2 = new (nome: "Carlos");
Pessoa p3 = new (nome: "Rafael");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);


//Cria suite
Suite suite= new (tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new (diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");