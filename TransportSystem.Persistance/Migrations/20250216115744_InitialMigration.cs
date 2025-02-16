using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportSystem.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    IdMotorista = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    CNH = table.Column<string>(type: "TEXT", nullable: true),
                    ValidadeCNH = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.IdMotorista);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Placa = table.Column<string>(type: "TEXT", nullable: true),
                    Ano = table.Column<string>(type: "TEXT", nullable: true),
                    Capacidade = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                });

            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    IdViagem = table.Column<int>(type: "INTEGER", nullable: false),
                    MotoristaIdMotorista = table.Column<int>(type: "INTEGER", nullable: true),
                    VeiculoIdVeiculo = table.Column<int>(type: "INTEGER", nullable: true),
                    DataHoraPartida = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataHoraChegada = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.IdViagem);
                    table.ForeignKey(
                        name: "FK_Viagens_Motoristas_MotoristaIdMotorista",
                        column: x => x.MotoristaIdMotorista,
                        principalTable: "Motoristas",
                        principalColumn: "IdMotorista");
                    table.ForeignKey(
                        name: "FK_Viagens_Veiculos_VeiculoIdVeiculo",
                        column: x => x.VeiculoIdVeiculo,
                        principalTable: "Veiculos",
                        principalColumn: "IdVeiculo");
                });

            migrationBuilder.CreateTable(
                name: "Passageiros",
                columns: table => new
                {
                    IdPassageiro = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ViagemIdViagem = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.IdPassageiro);
                    table.ForeignKey(
                        name: "FK_Passageiros_Viagens_ViagemIdViagem",
                        column: x => x.ViagemIdViagem,
                        principalTable: "Viagens",
                        principalColumn: "IdViagem");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passageiros_ViagemIdViagem",
                table: "Passageiros",
                column: "ViagemIdViagem");

            migrationBuilder.CreateIndex(
                name: "IX_Viagens_MotoristaIdMotorista",
                table: "Viagens",
                column: "MotoristaIdMotorista");

            migrationBuilder.CreateIndex(
                name: "IX_Viagens_VeiculoIdVeiculo",
                table: "Viagens",
                column: "VeiculoIdVeiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Passageiros");

            migrationBuilder.DropTable(
                name: "Viagens");

            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
