   M S B A M L   `   `   `  ????C  ?RentACar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:RentACar.Domain.Views.UserControls"RentACar.Domain.Views.UserControls  5      6    0RentACar.Domain.Views.UserControls.UserShowCarUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:RentACar.Domain.Views.UserControls     5      .??5	      ? 
???????  ? ColumnDefinitions  5
   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? 
???   ?$??10q?6#    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%g   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 5??65   5      5      5      .??5      ?? $??/Images/camaroWhite.jpg??6   $
??Fill=?65   5      5      ?? 5   
   $??1??6   $??Center=?6%   $??Center=?6B   .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?62   .+?5      ?? $??18(?6   $
??Bold"?6&   ??68   ?? *	Car.Brand+6X   ?? 5      $
??Bold"?6   $??Center=?6*   $??18(?6N   .??6\   (5!      ?? 5"      $
??Bold"?6   $??Center=?6*   $??18(?6N   ??6\   ?? *
Car.Year+5$      ?? 5%      $
??Bold"?6   $??Center=?6*   $??18(?6N   .??6\   )5'      5(      ?? 5*      $??0,10,0,0q?6   $ 
Horizontal=?6+   $??Center=?6D   .+?5+      ?? .+?5,      ?? 
???   ?$??1q?61   ._?5-      ?? .+?5.      ?? $??DemiBold"?6$   $??Center=?6:   .??6^   
1-2 Days50      51      52      ?? 54      
???????$??1q?60   ._?55      ?? 
???????$ 
Horizontal=?6<   .+?56      ?? $??10,0,0,0q?6$   $??DemiBold"?66   $??Center=?6L   ??57   $   ?? *Car.RentPriceOneDay+59      ?? 5:      $??DemiBold"?6$   $??Center=?6:   .??6^   $5<      5=      5>      5?      ?? 5A      .+?5B      ?? 
???   ?$??1q?61   ._?5C      ?? .+?5D      ?? $??DemiBold"?6$   $??Center=?6;   .??6_   
3-5 Days5F      5G      5H      ?? 5J      
???????$??1q?60   ._?5K      ?? 
???????$ 
Horizontal=?6<   .+?5L      ?? $??10,0,0,0q?6$   $??DemiBold"?66   $??Center=?6L   ??6p   ?? *Car.RentPriceThreeDays+5N      ?? 5O      $??DemiBold"?6$   $??Center=?6:   .??6^   $5Q      5R      5S      5T      ?? 5W      .+?5X      ?? 
???   ?$??1q?61   ._?5Y      ?? .+?5Z      ?? $??DemiBold"?6$   $??Center=?6;   .??6_   
6-7 Days5\      5]      5^      ?? 5`      
???????$??1q?60   ._?5a      ?? 
???????$ 
Horizontal=?6<   .+?5b      ?? $??10,0,0,0q?6$   $??DemiBold"?66   $??Center=?6L   ??5c   $   ?? *Car.RentPriceOneWeek+5e      ?? 5f      $??DemiBold"?6$   $??Center=?6:   .??6^   $5h      5i      5j      5k      5l      5m      ?? 5p   
   $??3??6   $??Center=?6%   $??Center=?6B   .+?5q      ?? $??Order??6   $??	50,5,50,5q?6%   $??25(?69   
??? ? ?
???????$
??Bold"?5r   ,   ??6>   ?? *OrderCommand+ 5s      ??%h   '??       ?? 5t      " ??6   .?5u      ??  ?@??CornerRadius$ 10??69   5w      5x      5y      5z      ?? 5|      $??0,10,0,0q?6   $??Detailed Info??6'   $??	50,5,50,5q?6?   $??25(?6S   
??? ???
???????$
??Bold"?5}   ,   ??6>   ?? *DetailCommand+ 5~      ??%h   '??       ?? 5      " ??6   .?5?      ??  ?@??CornerRadius$ 10??69   5?      5?      5?      5?      5?      5?      5?      