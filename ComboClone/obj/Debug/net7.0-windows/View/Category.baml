   M S B A M L   `   `   `  ����E  AComboClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ComboClone.ViewComboClone.View  5          ComboClone.View.Category   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ComboClone.View     5        � 	Resources  5	         MenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  &	        �� 5
   
   " 	�6(   .�5      ��  � ��$	 180��5      �� 5       � ��$ 40��5      �� 5       � ��$ 0,3,0,0q�5      �� 5       � �� 5      �� 5      " 	�6&   .R�5      � $��0,0,0,0q�6    5      �� 5   "   $	��180 �63   .+�5      �� $ border��6%   
������ $ 5��5       $��0q�5!      �� 5#      $  SidebarRadioButtonMenuText��6(   $��1��5$       $	��120��5%       #��z��5&       $��Center=�5'       $
��Left=�5(       ���#F8F9FA$��18(�5*       $.��(Fonts/Roboto-Regular.ttf #Roboto Regular)�5+       $��60,0,0,0q�5,       �� 5.      $ Highlighter��6%   $��20��5/      $��4��50      ���#00AADA$ 2��52      $
��Left=�53      $��0,0,5,0q�54      $y�	Collapsed=�55      57      	 59      P� 5;      
 �@J�IsMouseOver$
 True��5<      . �5>   "   �� $ border��5?   !    � �� �#4141415@   !   5B      P� 5D      
 �@d�	IsChecked$
 TrueY�5E      . �5G   "   �� $ border��5H   !    � �� �#4141415I   !   �� 5L   "   $ Highlighter��5M   !    � y�$ Visible=�5N   !   5P      5S      5U      5V      5W      .��5Y      �  5Z   
   �� 5[      $	��200 �6   �� 5\      .+�5_   
   � .+�5`      �� Combo Analzer�� 5b      6   �� 5c      ��6   �� *Time+5d      5e      � 5g   
   $��1��6   .+�5h      �� ��6   �� *SourceCollection+��5i      �� 5j      .R�5k      ��  �� Orientation$ 
Horizontal=�6%   5l      ��5n      �� 5o      .R�5p      	� #��[  5s       	� 	GroupName$ CategoryGroup��5t      ��5p   &   �� *CategoryName+��5q      �� *CategoryName+��5r      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ DataContext.ChageView�5t      5u      5w      5x      5z      5{      