   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��600��6)    � 	Resources 5	         WpfApp3.Duties 
  duties  
MyTemplate ��Name � RowDefinitions � ColumnDefinitions �� Path  GrayBlueGradientBrush �� 
StartPoint �� EndPoint � Color	 � Offset
 �� 
TargetType �� Property �� Value��%V  &	        &	      &	 �    '�� �    7    5
   
   6   �� 5   
   .R�5      �� $ border��6   ._�5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $��0��6    $��0��6-   $��
Duty Name:��6=   �� 5      $��0��6    $��1��6-   ��6=   �� $ DutyName��� 5      $��1��6    $��0��6-   $��	DutyType:��6=   �� 5      $��1��6    $��1��6-   ��6=   �� $ DutyType�5      5      5      �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $ DarkGray��6   $	 0Q�6,   � 5       $ #CCCCFF��6   $		 0.5Q�6+   � 5!      $ DarkGray��6   $	 1Q�6,   5"      �� 5$   
   "
 ��6   .�5%      ��  � ��8   6+   �� 5&       � ��$ 80��6&   �� 5'       � ��$ 10q�6'   5(      5)      .��5*      �� .+�5+   
   �� -   5         ��Name$	 Add��5+      .��64   직무 추가6;   �� 5,   
   $��10,0,0,0q�6   #!직무타입을 선택 하세요.65   �� 5-   
   -   5         ��Name$ 
myListBox1��5-       �� SelectedIndex$ 0��5.      $��	10,0,10,0q�6$   .@�5/      �� .��6   	Outside6#   �� 50      .��6   Inner6!   51      �� 52   
   $��10,10,0,-10q�6   직무6-   �� 53   
   -   5        $��
myListBox2��53   *   $	��400��6   $��10q�6   $��Stretch=�54      #��[ 56      ��55      �� 57      58      59      