   M S B A M L   `   `   `  ����D  @ShellSort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShellSort	ShellSort  5   	       ShellSort.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShellSort     5   	     � Title$  
Shell Sort��5   	   $	��600��6   $	��800��6)   .��5	      �  � ShowGridLines .   � ColumnDefinitions 5
   
   �� 5      $��0.05* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��0.05* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $
��0.1* �6   .+�5   
   �� -   5        $��canvas��5      $��1��5      $��1��6!   $��2��6.   $	��740��6B   $	��400��6N   
���   �}�. 5   5   �� 5   
   $��2��6   $��1��6   $	��100��6-   $��25��69   $��0 0 258 110q�5      .��6%   Array:6-   �� 5   
   -   5        $��TbArray��5       $��2��5      $��1��6   $	��350��6/   $	��105��6;   $��0 20 0 0q�5      " �� VerticalScrollBarVisibility$
 Auto=�5       �� TextWrapping$
 Wrap=�5    !    �� 
IsReadOnly . 5!   &   �� 5#   
   -   5        $��resetButton��5%   +   $��2��5#      $��2��6   $	��100��6.   $��30��6:   $��
260 0 0 20q�5$      .��5%   >   Reset6E   �� 5&   
   -   5        $��
sortButton��5(   *   $��2��5&      $��2��6   $	��100��6.   $��30��6:   $��
260 0 0 90q�5'      .��5(   <   
Start Sort6H   �� 5)   
   -   5        $��randomButton��5+   ,   $��2��5)      $��2��6   $	��100��6.   $��30��6:   $��
260 50 0 0q�5*      .��5+   @   Random6H   �� 5-   
   $��2��6   $��2��6   $	��170��6-   $��25��69   $��0 0 190 110q�5.      .��6%   Number of array comparisons:6C   �� 50   
   -   5        $��lblSwapCount��52      $��2��50      $��2��6   $��75��6-   $��25��68   $��
40 0 0 110q�51      .��52   $   06'   53      54      