   M S B A M L   `   `   `  ????C  ?RentACar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RentACar.Domain.Views.WindowsRentACar.Domain.Views.Windows  5   	   0    *RentACar.Domain.Views.Windows.InsertWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:RentACar.Domain.Views.Windows     5   	     ? Title$  InsertWindow??5   	   $	??425??6   $	??400??6+   .??5	      ? 
???????.+?5
   
   ?? -   5        $??insertStackPanel??5
      $??Center=?6-   .+?5      ?? .+?5      ?? $??Black"?6   $??Center=?6+   
???  ??.??6`   Data Insert Forum6s   5      ?? 5      
??????? ?? Orientation$ 
Horizontal=?5      .+?5      ?? $??0,5,0,0q?6   .??6)   Brand60   ?? 5      $	??200??5      $??100,10,10,10q?6!   ??5      ?? *	Car.Brand+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=?5   9   5      ?? 5      
???????$ 
Horizontal=?5      .+?5      ?? $??0,5,0,0q?6   .??6)   	Mileage62   ?? 5      $	??200??5      $??
88,10,0,10q?6'   ??5      ?? *Car.Mileage+$ TwoWay=?$ PropertyChanged=?5   =   5      ?? 5      
???????$ 
Horizontal=?5      .+?5      ?? $??0,5,0,0q?6   .??6)   Year6/   ?? 5       $	??200??5!      $??108,10,0,10q?6'   ??5       ?? *
Car.Year+$ TwoWay=?$ PropertyChanged=?5!   >   5#      ?? 5%      
???????$ 
Horizontal=?5&      .+?5'      ?? $??0,5,0,0q?6   .??6)   Type6/   ?? 5(      $	??200??5)      $??105,10,0,10q?6'   ??5(      ?? *
Car.Type+$ TwoWay=?$ PropertyChanged=?5)   >   5*      ?? 5,      
???????$ 
Horizontal=?5-      .+?5.      ?? $??0,5,0,0q?6   .??6)   Color60   ?? 5/      $	??200??50      $??101,10,0,10q?6'   ??5/      ?? *	Car.Color+$ TwoWay=?$ PropertyChanged=?50   >   51      ?? 53      
???????$ 
Horizontal=?54      .+?55      ?? $??0,5,0,0q?6   .??6)   	Fuel Type64   ?? 56      $	??200??57      $??
80,10,0,10q?6'   ??56      ?? *Car.FuelType+$ TwoWay=?$ PropertyChanged=?57   =   58      ?? 5:      
???????$ 
Horizontal=?5;      .+?5<      ?? $??0,5,0,0q?6   .??6)   Rent Price 1 Day6;   ?? 5=      $	??200??5>      $??
45,10,0,10q?6'   ??5=      ?? *Car.RentPriceOneDay+$ TwoWay=?$ PropertyChanged=?5>   =   5?      ?? 5A      
???????$ 
Horizontal=?5B      .+?5C      ?? $??0,5,0,0q?6   .??6)   Rent Price 3 Days6<   ?? 5D      $	??200??5E      $??
40,10,0,10q?6'   ??5D      ?? *Car.RentPriceThreeDays+$ TwoWay=?$ PropertyChanged=?5E   =   5F      ?? 5I      
???????$ 
Horizontal=?5J      .+?5K      ?? $??0,5,0,0q?6   .??6)   Rent Price 7 Days6<   ?? 5L      $	??200??5M      $??
40,10,0,10q?6'   ??5L      ?? *Car.RentPriceOneWeek+$ TwoWay=?$ PropertyChanged=?5M   =   5N      5P      5R      5S      