﻿namespace PayWiseBackend.Domain.Models;

public class Conta : Entity
{
    public int ClienteId { get; set; }
    public int Numero { get; set; }
    public double Saldo { get; set; }
    public DateTime DataAbertura { get; set; }
    public string Agencia { get; set; } = null!;
    public int Pin { get; set; }
    public double LimitePixGeral { get; set; }
    public double LimitePixNoturno { get; set; }
    public int HistoricoId { get; set; }
    public virtual Historico? Historico { get; set; }
}
