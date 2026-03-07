// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

using System;
using FactoryMethod.NotificationCreators;

namespace DesignPatternChallenge
{
    // Contexto: Sistema de notificações que envia mensagens para clientes
    // Cada tipo de notificação tem requisitos e formatação diferentes
    
    public class NotificationManager
    {
        public void SendOrderConfirmation(string recipient, string orderNumber, string notificationType)
        {
            NotificationCreatorFactory
                .GetCreator(notificationType, recipient, "Confirmação de Pedido", $"Seu pedido {orderNumber} foi confirmado!")
                .Notify();
        }

        public void SendShippingUpdate(string recipient, string trackingCode, string notificationType)
        {
            NotificationCreatorFactory
                .GetCreator(notificationType, recipient, "Pedido Enviado", $"Pedido enviado! Rastreamento: {trackingCode}")
                .Notify();
        }

        public void SendPaymentReminder(string recipient, decimal amount, string notificationType)
        {
            NotificationCreatorFactory
                .GetCreator(notificationType, recipient, "Lembrete de Pagamento", $"Você tem um pagamento pendente de R$ {amount:N2}")
                .Notify();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações ===\n");

            var manager = new NotificationManager();

            // Cliente 1 prefere Email
            manager.SendOrderConfirmation("cliente@email.com", "12345", "email");
            Console.WriteLine();

            // Cliente 2 prefere SMS
            manager.SendOrderConfirmation("+5511999999999", "12346", "sms");
            Console.WriteLine();

            // Cliente 3 prefere Push
            manager.SendShippingUpdate("device-token-abc123", "BR123456789", "push");
            Console.WriteLine();

            // Cliente 4 prefere WhatsApp
            manager.SendPaymentReminder("+5511888888888", 150.00m, "whatsapp");

            // Perguntas para reflexão:
            // - Como adicionar novos tipos de notificação (Telegram, Slack) sem modificar NotificationManager?
            // - Como evitar duplicação da lógica condicional em cada método?
            // - Como permitir que subclasses decidam qual tipo de notificação criar?
            // - Como tornar o código mais extensível e manutenível?
        }
    }
}
