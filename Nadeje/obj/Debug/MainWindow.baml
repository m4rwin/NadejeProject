   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   
 Nadeje   Nadeje.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  U Bulhara 2016��5   	   $	��600��6    $	��440��6-    � WindowStartupLocation$ CenterScreen=�5   	   (   "MahApps.Metro.Controls.MetroWindow   SaveWindowPosition .    AccentColorBrush#���   5      $	��1.5q�5	       � Icon$ Pictures/ubulhara.ico��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��50 �6   �� 5       $��50 �6   �� 5!      $��20 �6   .+�5$   
   �� $��0��6   $��0��6   $��Jméno:��6-   $��Center=�6>   $��Center=�6Y   $��0q�6v   �� 5%   
   $��0��6   $��1��6   $��Příjmení:��6-   $��Center=�6A   $��Center=�6\   $��0q�6y   �� 5&   
   $��0��6   $��2��6   $
��Rok:��6-   $��Center=�6<   $��Center=�6W   $��0q�6t   �� 5(   
   -   5        $��txbFirstName��5(   F   $��1��6   $��0��6   $��80��6/   $��25��6:   $��0q�6Z   6f   �� 5)   
   -   5        $��txbLastName��5)   F   $��1��6   $��1��6   $��80��6/   $��25��6:   $��0q�6Y   6e   �� 5*   
   -   5        $��txbBirdYear��5*   F   $��1��6   $��2��6   $��80��6/   $��25��6:   $��0q�6Y   6e   �� 5+   
   -   5        $��btnFind��5+   �   $��0��6   $��3��6   $��2��6.   $��2��6B   $��Vyhledat��6S   $��Right=�6f   $��40��6�   $��80��6�   $��0,10,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  50   
   -   5        $��dataGrid��50   D   $��2��6   $��0��6    $��6��60   $��0,15,0,0q�6T      AutoGenerateColumns .     
IsReadOnly .    Columns 51      4  .System.Windows.Controls.DataGridTemplateColumn  52      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Pohlaví��6)   
   CellTemplate
 53      �� 54      .R�55      �� $��20��6D   ��6$   �� *GenrePicture+6D   56      58      0  *System.Windows.Controls.DataGridTextColumn  59      $	 Ev. č.��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+  5:      $	 Jméno��6%    64   �� *	FirstName+  5;      $	 Příjmení��6%    67   �� *
LastName+  5<      $	 Rok Narození��6%    6;   �� *	BirthYear+5>      �� 5@   
   $��3��6   $��0��6"   $��6��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   $��Center=�6z   $��0,5,0,5q�6�   .+�5A      �� -   5        $��btnAddClient��5A      $��Přidat klienta��6)   $��40��6B   $	��100��6N   6Z   5B      a� 5D   
   $��4��6   $��0��6$   $��6��64   
�������$��Center=�6^   .+�5E      �� $ 
Horizontal=�6   .+�5F      �� -   5        $��
lblToolBar��5F      
�������6*   5G      5H      5I      5J      