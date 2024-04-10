int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3}");
Console.WriteLine($"Sub Total: {subtotal:C}");
Console.WriteLine($"taxPercentage: {taxPercentage:P2}");
Console.WriteLine($"Total: {total:C}");