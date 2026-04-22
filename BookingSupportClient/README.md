# Booking Support Client

Ez a projekt a megvalósíthatósági tanúsítvány alapján készült `C# WinForms` kliensalkalmazás.

Fő funkciók:

- foglalások rögzítése, szerkesztése és törlése
- megjegyzések és feljegyzések külön kezelése
- keresés és státusz szerinti szűrés
- `secure checkout` JSON payload automatikus SQL adatbázisba mentése
- SQL Server LocalDB adatbázis automatikus létrehozása induláskor

## Indítás

```powershell
dotnet build
dotnet run
```

## Secure checkout import

Az alkalmazás `Checkout import` gombja egy JSON fájlt vár. Minta payload:

`[SampleData/checkout-sample.json](SampleData/checkout-sample.json)`

Az import egyedi `checkoutReference` alapján upserteli a foglalást a `Bookings` táblába.

## SQL séma

A létrejövő táblák sémája megtalálható itt:

`[database-schema.sql](database-schema.sql)`
