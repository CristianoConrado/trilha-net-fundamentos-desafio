using System;
using System.Collections.Generic;
namespace DesafioFundamentos.Models;
public class Estacionamento
{
    private decimal
        _precoInicial = 0,
        _precoPorHora = 0;
    private readonly List<string>
        _veiculos = [];
    public Estacionamento( decimal precoInicial, decimal precoPorHora )
    {
        _precoInicial = precoInicial;
        _precoPorHora = precoPorHora;
    }
    public void AdicionarVeiculo()
    {
        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        // Implementado
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(placa)|| string.IsNullOrEmpty( placa ) )
        {
            Console.WriteLine( "Placa inválida.\nTente novamente." );
            return;
        }
        _veiculos.Add(placa);
        Console.WriteLine( $"Veículo {placa} adicionado com sucesso." );
    }
    public void RemoverVeiculo()
    {
        Console.WriteLine( "Digite a placa do veículo para remover:" );
        // Pedir para o usuário digitar a placa e armazenar na variável placa
        // Implementado!
        string placa = Console.ReadLine();
        // Verifica se o veículo existe
        if ( _veiculos.Any(i => i.ToUpper() == placa.ToUpper()) && !string.IsNullOrWhiteSpace( placa ) && !string.IsNullOrEmpty( placa ) )
        {
            Console.WriteLine( "Digite a quantidade de horas que o veículo permaneceu estacionado:" );
            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            // Implementado!
            if ( int.TryParse( Console.ReadLine(), out int horas ) )
            {
                // TODO: Remover a placa digitada da lista de veículos
                // Implementado!
                _veiculos.Remove( placa );
                Console.WriteLine( $"O veículo {placa} foi removido e o preço total foi de: {_precoInicial + _precoPorHora * horas:c}" );
                return;
            }
        }
        Console.WriteLine( "Desculpe, esse veículo não está estacionado aqui.\nConfira se digitou a placa corretamente" );
    }
    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if ( _veiculos.Any() )
        {
            Console.WriteLine( "Os veículos estacionados são:" );
            // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            // Implementado!
            foreach ( var veiculo in _veiculos )
                Console.WriteLine( veiculo );
            return;
        }
        Console.WriteLine( "Não há veículos estacionados." );
    }
};