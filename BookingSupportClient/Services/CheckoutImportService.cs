using System.Text.Json;
using BookingSupportClient.Data;
using BookingSupportClient.Models;

namespace BookingSupportClient.Services;

public sealed class CheckoutImportService
{
    private readonly BookingRepository _repository;

    public CheckoutImportService(BookingRepository repository)
    {
        _repository = repository;
    }

    public BookingRecord ImportFromJsonFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var payload = JsonSerializer.Deserialize<CheckoutPayload>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        if (payload is null)
        {
            throw new InvalidOperationException("A checkout fájl nem értelmezhető.");
        }

        Validate(payload);
        return _repository.UpsertCheckout(payload);
    }

    private static void Validate(CheckoutPayload payload)
    {
        if (string.IsNullOrWhiteSpace(payload.CheckoutReference))
        {
            throw new InvalidOperationException("A checkoutReference mező kötelező.");
        }

        if (string.IsNullOrWhiteSpace(payload.CustomerName))
        {
            throw new InvalidOperationException("A customerName mező kötelező.");
        }

        if (string.IsNullOrWhiteSpace(payload.ProductCode))
        {
            throw new InvalidOperationException("A productCode mező kötelező.");
        }
    }
}
