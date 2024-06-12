using bytebank.Modelos.ADM.Funcionarios;
using bytebank.Modelos.ADM.Utilitario;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;
using System;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavesPix(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}


