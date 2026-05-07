

// Inputting
Console.WriteLine("Carpet Cleaning service Prices");
Console.WriteLine("");
Console.Write("Number of small carpets: ");
int smallCarpetsnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of large carpets: ");
int largeCarpetsnumber = Convert.ToInt32(Console.ReadLine());

//pricing & taxrate
decimal smallCarpetprice = 250;
decimal largeCarpetprice = 350;
decimal taxRate = 0.14M;
int expiryDays = 30;

// Calculations
decimal costSmall = smallCarpetsnumber * smallCarpetprice;
decimal costLarge = largeCarpetsnumber * largeCarpetprice;
decimal subtotal = costSmall + costLarge;
decimal taxAmount = subtotal * taxRate;
decimal totalEstimate = subtotal + taxAmount;

// Outputting
Console.WriteLine($"Price per small carpet: {smallCarpetprice:C}");
Console.WriteLine($"Price per large carpet: {largeCarpetprice:C}");
Console.WriteLine($"Cost: {subtotal:C}");
Console.WriteLine($"Tax: {taxAmount:C}");
Console.WriteLine("==========================");
Console.WriteLine($"Total: {totalEstimate:C}");
Console.WriteLine($"This offer is valid for {expiryDays} days");
