   M S B A M L   `   `   `  ????C  ?RentACar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:RentACar.Domain.Views.UserControls"RentACar.Domain.Views.UserControls  5      8    2RentACar.Domain.Views.UserControls.AdminShowCarsUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:RentACar.Domain.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6M   .??5	      ? 
???????.+?5   
   ?? $	??Top=?6   $
??Left=?6-   .+?5      ?? ??6   ?? *BackCommand+.??5      ?? $??45??6   $??/Images/leftarrow.png??6#   6D   5      5      ?? 5   
   
???   ?$??2q?6%   $	??Top=?6:   $??Center=?6R   $??0,45,0,0q?5        ?? Padding$  	45,0,45,0q?6#   ._?5      ?? .+?5      ?? $??Cars View Menu??6   $??Edwardian Script ITC)?61   $??55(?6S   
??? E??$??
ExtraBlack"?5   .   5      5      5      ?? 5   
   
???   ?$??2,3,2,2q?6%   $??Center=?5      $??Center=?6.   $??0,85,0,0q?6I   ._?5      ?? .+?5       ?? $	??250??6   $??10q?5"      
???????
???   ?$??5,0,5,5q?6E   ??5!      ?? *	AllCars+ ?? SelectedItem 61   ?? *SelectedCar+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5#      +  %Microsoft.Xaml.Behaviors.EventTrigger  5$         	EventName$ SelectionChanged??6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5%      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   ?? *SelectedCarCommand+6^   5&       ?? View 5(      ?? 5)      .P?5*      ?? $??ID??6-    ?? Width$	 200??69    ?? CellTemplate 5+   "   ?? 5,   &   .R?5-   *   ?? $??18(?64   $??Center=?6B   	 ?? Padding$		 5,2q?6_   ??6m   ?? *Id+6?   5.   '   50      ?? 51      $??	Car Brand??6-   $	 200??6@    52   "   ?? 53   &   .R?54   *   ?? $??18(?64   $??Center=?6B   $		 5,2q?6_   ??6m   ?? *Brand+6?   55   '   57      ?? 58      $
??Year??6-   $	 200??6;    59   "   ?? 5:   &   .R?5;   *   ?? 
 ?? Orientation$
 
Horizontal=?65   .+?5<   .   ?? $??18(?68   ??6F   ?? *Year+6_   5=   +   5>   '   5@      5A      5C      5D      5E      ?? 5H   
   $
??Left=?6   $??Bottom=?60   .+?5I      ?? $??
Rent a Car??6   $??Edwardian Script ITC)?6)   $??35(?6K   
??? E??$??
ExtraBlack"?5J   .   5L      5M      5N      5O      