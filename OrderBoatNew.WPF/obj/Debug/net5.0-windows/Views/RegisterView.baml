   M S B A M L   `   `   `  ����J  FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components  5      K GOrderBoatNew.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:OrderBoatNew.WPF.ViewsOrderBoatNew.WPF.Views 5      )   #OrderBoatNew.WPF.Views.RegisterView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:OrderBoatNew.WPF.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $��18(�5        � 	Resources  5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      ��5      �� 5   
    �� Opacity$	 0.8Q�6     LightBlueColor �� Color# [ 6(   .��5      �� $��25q�5   	    �� Padding$ 40q�5   	   $��Center=�5   	   $��Center=�5   	   
�������  	BlueBrush#��[ 5   	   $��2q�5   	    �� CornerRadius$ 3��5   	   ._�5   
   �  � IsSharedSizeScope$
 True��6    � RowDefinitions 5       �� 5!      $
��auto �6    �� 5"      $
��auto �6    .+�5%      �� $��0��5&      $��Center=�5'      $��21(�5(      $��Форт Тартуга��5)      � 5+      $��1��6   $
��0,20q�6     5-      �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$   �� 52      $
��auto �6$   �� 53      $
��auto �6$   �� 54      $
��auto �6$   .+�57      � $��0��6   $
��0,10q�6$    � ColumnDefinitions 58      �� 59      $
��Auto �6+    z� SharedSizeGroup$ Label��68   �� 5:      $	��200 �6+   .+�5<      �� $��0��5=      $
��Left=�5>      $��Email: ��5?      �� 5@      $��1��5A      $��20,0,0,0q�5B      ��5C      �� *Email+	 �� UpdateSourceTrigger$	 PropertyChanged=�5D      � 5F      $��1��6   $
��0,10q�6$    5G      �� 5H      $
��Auto �6+   $ Label��68   �� 5I      $	��200 �6+   .+�5K      �� $��0��5L      $
��Left=�5M      $��
Username: ��5N      �� 5O      $��1��5P      $��20,0,0,0q�5Q      ��5R      �� *
Username+$	 PropertyChanged=�5S      � 5U      $��2��6   $
��0,10q�6$    5V      �� 5W      $
��Auto �6+   $ Label��68   �� 5X      $	��200 �6+   .+�5Z      �� $��0��5[      $
��Left=�5\      $��
Password: ��5]      4   .PasswordBoxMVVM.Components.BindablePasswordBox  5^      $��1��5_      $��20,0,0,0q�5`      
   Password
 5a      �� *
Password+5b      � 5d      $��3��6   $
��0,10q�6$    5e      �� 5f      $
��Auto �6+   $ Label��68   �� 5g      $	��200 �6+   .+�5i      �� $��0��5j      $
��Left=�5k      $��Confirm Password: ��5l        5m      $��1��5n      $��20,0,0,0q�5o      
 5p      �� *ConfirmPassword+5q      �� 5s      $��4��5t      $
��0,10q�5u      $��Center=�5v      $*��$Зарегистрироваться��5x       �� 	IsDefault$
 True��5y      ��5w      �� *RegisterCommand+5y      �� 5{      $��5��5|      $��0,10,0,0q�5}      $��Center=�5~      
������ $��
Назад��5�      ��5�      �� *ViewLoginCommand+5�      �� 5�      $��6��5�      $��0,10,0,0q�5�      $��Center=�5�      
���  �� � DataContext 5�      �� *ErrorMessageViewModel+��5�      �� *	Message+y�5�      �� *
HasMessage+ �� 	Converter# [  5�      5�      5�      5�      