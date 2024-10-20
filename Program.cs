using segundoDesafioCSharp.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Vitor", sobrenome: "Bittencourt");
Pessoa p2 = new Pessoa(nome: "Nome", sobrenome: "Sobrenome");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150M);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da diária: R${reserva.CalcularValorDiaria()}");
