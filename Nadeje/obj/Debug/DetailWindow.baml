   M S B A M L   `   `   `  ����A  =Nadeje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NadejeNadeje  5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       Nadeje.DetailWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:Nadeje     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Detail Klienta��5   	   $	��600��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   (  "MahApps.Metro.Controls.MetroWindow   SaveWindowPosition .    AccentColorBrush#���   5      $��1q�5	       � Icon$ Pictures/ubulhara.ico��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $	��150 �6   �� 5      $��40 �6   �� 5      $	��220 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Jméno:��6-   $��0q�6>   $��Center=�6J   �� 5   
   $��0��6   $��1��6   $��Příjmení:��6-   $��0q�6A   $��Center=�6M   �� 5   
   $��0��6   $��2��6   $��Rok narození:��6-   $��0q�6E   $��Center=�6Q   �� 5    
   $��0��6   $��3��6   $��Služby cizinci:��6-   $��0q�6G   $��Center=�6S   �� 5!   
   $��0��6   $��4��6   $��	Pohlaví:��6-   $��0q�6@   $��Center=�6L   �� 5#   
   -   5        $��txbFirstName��5#   G   $��1��6   $��0��6   $	��100��6/   $��25��6;   6G   �� 5$   
   -   5        $��txbLastName��5$   G   $��1��6   $��1��6   $	��100��6/   $��25��6;   6G   �� 5%   
   -   5        $��txbBirthYear��5%   G   $��1��6   $��2��6   $	��100��6/   $��25��6;   6G   )  #MahApps.Metro.Controls.ToggleSwitch  5&   
   -   5        $��switchServices��5&       $��1��66   $��3��6C   $��Center=�6S   $��Center=�6p      OffLabel$ NEVYČERPÁNO��6�      OnLabel$ VYČERPÁNO��6�   $��10(�6�   �� 5'   
   -   5        $��imgGenre��5'   -   $��1��6   $��4��6   $��35��6=   6I   �� 5)   
   $��2��6   $��0��6   $��5��6-   $ ��Jednorázová první pomoc��6A   $
��Bold"�6c   $��Bottom=�6u   &   System.Windows.Controls.DataGrid  5*   
   -   5        $��dataFirstAid��5*   D   $��3��6   $��0��6    $��5��60      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Od��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *From+ �� StringFormat$ {0:dd.MM.yyyy}��  5-      $ Do��6%   $ 80 61    6<   �� *To+$ {0:dd.MM.yyyy}��  5.      $ Datum vystavení��6%   $	 150 6>    6J   �� *	Created+$ {0:dd.MM.yyyy HH:mm:ss}��  5/      $ Přidal��6%   $	 125 65    6A   �� *
WhoCreated+51      �� 54   
   $��4��6   $��0��6   $��5��6-   $��Přerušení služby��6A   $
��Bold"�6\   $��Bottom=�6n     55   
   -   5        $��dataServiceInterruption��55   D   $��5��6   $��0��6    $��5��60    .  	 . 
 56        57      $ Od��6%   $	 100 61    6=   �� *From+$ {0:dd.MM.yyyy}��  58      $ Do��6%   $	 100 61    6=   �� *To+$ {0:dd.MM.yyyy}��  59      $ Důvod��6%   $	 100 64    6@   �� *Reason+  5:      $ 	Poznámka��6%   $	 100 67    6C   �� *Note+  5;      $ Datum vystavení��6%   $	 150 6>    6J   �� *	Created+$ {0:dd.MM.yyyy HH:mm:ss}��  5<      $ Přidal��6%   $	 125 65    6A   �� *
WhoCreated+5>      �� 5@   
   $��6��6   $��0��6"   $��5��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   $��Center=�6z   .+�5A      �� -   5        $��btnAddJP��5A      $��40��6%   $	��110��61   $��	10,5,10,5q�6=   $��
Přidat JP��6P   6}   �� 5B      -	   5        $��btnAddServices��5B      $��40��6+   $	��110��67   $��	10,5,10,5q�6C   $��Přerušené služby��6V   6�   �� 5C      -
   5        $��btnSave��5C      $��40��6$   $	��110��60   $��	10,5,10,5q�6<   $��Uložit��6O   6x   5D      5E      5F      