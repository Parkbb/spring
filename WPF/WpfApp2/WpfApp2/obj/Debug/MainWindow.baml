   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         MyStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� ElementName �� Path	 �� Value��%�   &	        �� 5
   
   " ��6    .�5      ��  � y�$ Visible=�6+    5      �� 5       6   �� $	 cb1��$ 	IsChecked�	 True5      .a�5      ��  � y�$ Hidden=�63   5      5      5      .��5      �� .+�5   
   �� -   5        
 ��Name$	
 cb1��5      $��	Click Me!��6    $��20(�64   �� 5   
   $��
Hello WPF!��6   $��20(�6&   #��[  5      5      5      