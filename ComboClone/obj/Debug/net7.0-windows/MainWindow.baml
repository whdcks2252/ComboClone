   M S B A M L   `   `   `  ����E  AComboClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ComboClone
ComboClone  5   	   1clr-namespace:ComboClone.ViewComboClone.View  5   	       ComboClone.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ComboClone     5   	   .viewclr-namespace:ComboClone.View     5   	     � Title$  
MainWindow��5	   	   $	��900��6   $
��1600��6)    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5      
������  � AllowsTransparency$
 True��5      .��5      � .+�5   
   �� ���#ECF0F1 �� CornerRadius$ 10��5   
   �� 5   
   ���#5C5C5C$	��Top=�5   
   $
��Left=�5   
   $ 
10,0,100,0��5   
   $��80��5   
   $
��1500��5   
   5      � 5    
    � RowDefinitions 5!      �� 5"      $��80 �6    �� 5#      .+�5%         ComboClone.View.Category  $��0��6    � DataContext 6)   �� *CategoryViewModel+�� 5'      -   5         ��Name$ Pages��5'   *   $��1��6   ��5(      �� *SelectedViewModel+5)         ComboClone.View.Modal  5+   
   $��2��6   $��3��6&   	 K� ZIndex$	 10��6;   
   ShadowColor$
 Black��6M      IsOpen 6a   �� *IsCalculatorModalOpen+ �� Mode$ TwoWay=�.��5,      � $	��500��6   $	��500��6   .+�5-          ComboClone.View.Calculator   6"   �� *CalculatorViewModel+5.      5/      51      52      