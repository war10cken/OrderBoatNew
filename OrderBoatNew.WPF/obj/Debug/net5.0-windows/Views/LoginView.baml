   M S B A M L   `   `   `  ����J  FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components  5      K GOrderBoatNew.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:OrderBoatNew.WPF.ViewsOrderBoatNew.WPF.Views 5      &    OrderBoatNew.WPF.Views.LoginView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:OrderBoatNew.WPF.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $��18(�5      ��5      �� 5   
     �� Opacity$	  0.8Q�6      LightBlueColor �� Color# [  6(    � 	Resources 5         BooleanToVisibilityConverter��%   &	       �� 5   
   6'   5      .��5      �� $��25q�5   	    �� Padding$ 40q�5   	   $��Center=�5   	   $��Center=�5   	   
�������  	BlueBrush#��[ 5   	   $��2q�5   	    �� CornerRadius$ 3��5   	   ._�5    
   �  � IsSharedSizeScope$
 True��6    � RowDefinitions 5!      �� 5"      $
��auto �6    �� 5#      $
��auto �6    .+�5&      �� $��0��5'      $��Center=�5(      $��21(�5)      $��Форт Тартуга��5*      � 5,      $��1��6   $
��0,20q�6     5-      �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$   �� 52      $
��auto �6$   .+�54      � $��0��6   $
��0,10q�6$    � ColumnDefinitions 55      �� 56      $
��Auto �6+    z� SharedSizeGroup$ Label��68   �� 57      $	��200 �6+   .+�59      �� $��0��5:      $��Center=�5;      $��
Username: ��5<      �� 5=      $��1��5>      $��20,0,0,0q�5?      ��5@      �� *
Username+	 �� UpdateSourceTrigger$	 PropertyChanged=�5A      � 5C      $��1��6   $
��0,10q�6$    5D      �� 5E      $
��Auto �6+   $ Label��68   �� 5F      $	��200 �6+   .+�5H      �� $��0��5I      $��Center=�5J      $��
Password: ��5K      4   .PasswordBoxMVVM.Components.BindablePasswordBox  5L      $��1��5M      $��20,0,0,0q�5N      
   Password
 5O      �� *
Password+5P      �� 5R      $��2��5S      $
��0,10q�5T      $��Center=�5U      $��
Войти��5W       �� 	IsDefault$
 True��5X      ��5V      �� *LoginCommand+5X      �� 5Z      $��3��5[      $��0,10,0,0q�5\      $��Center=�5]      
������ $*��$Зарегистрироваться��5`      ��5_      �� *ViewRegisterCommand+5`      �� 5b      $��4��5c      $��0,10,0,0q�5d      $��Center=�5e      
���  �� � DataContext 5f      �� *ErrorMessageViewModel+��5h      �� *	Message+y�5i      �� *
HasMessage+ �� 	Converter# [ 5j      5k      5l      5m      