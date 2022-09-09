﻿using API.Domain;
using API.Entities;
using API.Entities.Enums;
using Xunit;

namespace API_tests.Entites
{
    public class NewsTests
    {
        // Validação do tamanho do título
        [Fact]
        public void News_Validate_Title_Length()
        {
            var result = Assert.Throws<DomainException>(() => new News(
            "Entretenimento",
            "A Band preparou uma série de atrações para agitar o fim de ano. Nesta terça-feira (21), às 22h30, o público acompanha o MasterChef Especial de Natal com a presença de vários famosos. Na primeira prova, Adriana Birolli e Toni Garrido enfrentam Negra Li e Felipe Titto. A dupla que fizer o melhor hambúrguer com acompanhamento e molho vence a disputa.\n\nNo segundo desafio, as gêmeas nadadoras Bia e Branca Feres encaram os gêmeos lutadores Rodrigo Minotauro e Rogério Minotouro. Os irmãos terão de preparar receitas natalinas de família.\n\n",
            "A Band preparou uma série de atrações para agitar o fim de ano. Nesta terça-feira (21), às 22h30, o público acompanha o MasterChef Especial de Natal com a presença de vários famosos. Na primeira prova, Adriana Birolli e Toni Garrido enfrentam Negra Li e Felipe Titto. A dupla que fizer o melhor hambúrguer com acompanhamento e molho vence a disputa.\n\nNo segundo desafio, as gêmeas nadadoras Bia e Branca Feres encaram os gêmeos lutadores Rodrigo Minotauro e Rogério Minotouro. Os irmãos terão de preparar receitas natalinas de família.\n\n",
            "Da Redação",
            "http://localhost:5005/img/f168c0e0-790a-4247-934e-1f9d32bf4a5e.webp",
            status: Status.Active));

            Assert.Equal("O título deve ter até 90 caracteres", result.Message);
        }

        // Validação do tamanho do chapéu
        [Fact]
        public void News_Validate_Hat_Length()
        {
            var result = Assert.Throws<DomainException>(() => new News(
            "Fim de ano da Band traz programas especiais, filmes e shows exclusivos",
            "Fim de ano da Band traz programas especiais, filmes e shows exclusivos",
            "A Band preparou uma série de atrações para agitar o fim de ano. Nesta terça-feira (21), às 22h30, o público acompanha o MasterChef Especial de Natal com a presença de vários famosos. Na primeira prova, Adriana Birolli e Toni Garrido enfrentam Negra Li e Felipe Titto. A dupla que fizer o melhor hambúrguer com acompanhamento e molho vence a disputa.\n\nNo segundo desafio, as gêmeas nadadoras Bia e Branca Feres encaram os gêmeos lutadores Rodrigo Minotauro e Rogério Minotouro. Os irmãos terão de preparar receitas natalinas de família.\n\n",
            "Da Redação",
            "http://localhost:5005/img/f168c0e0-790a-4247-934e-1f9d32bf4a5e.webp",
            status: Status.Active));

            Assert.Equal("O chapéu deve ter até 40 caracteres", result.Message);
        }

        // Validação do título está vazio
        [Fact]
        public void News_Validate_Title_Empty()
        {
            var result = Assert.Throws<DomainException>(() => new News(
            "Entretenimento",
            String.Empty,
            "A Band preparou uma série de atrações para agitar o fim de ano. Nesta terça-feira (21), às 22h30, o público acompanha o MasterChef Especial de Natal com a presença de vários famosos. Na primeira prova, Adriana Birolli e Toni Garrido enfrentam Negra Li e Felipe Titto. A dupla que fizer o melhor hambúrguer com acompanhamento e molho vence a disputa.\n\nNo segundo desafio, as gêmeas nadadoras Bia e Branca Feres encaram os gêmeos lutadores Rodrigo Minotauro e Rogério Minotouro. Os irmãos terão de preparar receitas natalinas de família.\n\n",
            "Da Redação",
            "http://localhost:5005/img/f168c0e0-790a-4247-934e-1f9d32bf4a5e.webp",
            status: Status.Active));

            Assert.Equal("O título não pode está vazio", result.Message);
        }

        // Validação do título está vazio
        [Fact]
        public void News_Validate_Hat_Empty()
        {
            var result = Assert.Throws<DomainException>(() => new News(
            string.Empty,
            "Fim de ano da Band traz programas especiais, filmes e shows exclusivos",
            "A Band preparou uma série de atrações para agitar o fim de ano. Nesta terça-feira (21), às 22h30, o público acompanha o MasterChef Especial de Natal com a presença de vários famosos. Na primeira prova, Adriana Birolli e Toni Garrido enfrentam Negra Li e Felipe Titto. A dupla que fizer o melhor hambúrguer com acompanhamento e molho vence a disputa.\n\nNo segundo desafio, as gêmeas nadadoras Bia e Branca Feres encaram os gêmeos lutadores Rodrigo Minotauro e Rogério Minotouro. Os irmãos terão de preparar receitas natalinas de família.\n\n",
            "Da Redação",
            "http://localhost:5005/img/f168c0e0-790a-4247-934e-1f9d32bf4a5e.webp",
            status: Status.Active));

            Assert.Equal("O chapéu não pode está vazio", result.Message);
        }

        // Validação da descrição está vazia
        [Fact]
        public void News_Validate_Description_Empty()
        {
            var result = Assert.Throws<DomainException>(() => new News(
            "Entretenimento",
            "Fim de ano da Band traz programas especiais, filmes e shows exclusivos",
            String.Empty,
            "Da Redação",
            "http://localhost:5005/img/f168c0e0-790a-4247-934e-1f9d32bf4a5e.webp",
            status: Status.Active));

            Assert.Equal("O descrição não pode está vazio", result.Message);
        }
    }
}
