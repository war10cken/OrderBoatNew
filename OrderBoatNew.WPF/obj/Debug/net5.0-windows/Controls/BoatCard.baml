   M S B A M L   `   `   `  ����K  GOrderBoatNew.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:OrderBoatNew.WPF.ControlsOrderBoatNew.WPF.Controls  5      (    "OrderBoatNew.WPF.Controls.BoatCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:OrderBoatNew.WPF.Controls     5      .��5
      � .+�5   
   ��   �� Orientation$  
Horizontal=�6   
�������.+�5      � $��	15 15 0 0q�6    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$ 0 20 0 0q�5   !   �� 5       � ��$
 Left=�5   !   �� 5       � ��$	 150��5   !   5      5       � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5"      �� $��Модель:��6   $��0��5#      �� 5$      $��0��6    �� DisplayMemberPath$
 Name��5&      ��5%      �� *Models+5&      �� 5(      $��Дерево:��6   $��1��5)      �� 5*      $��1��6   $
 Name��5,      ��5+      �� *Woods+5,      �� 5.      $��2��6   .+�5/      �� $��	Цвет:��6    �� 50      $
 Name��51      $��0 5 0 0q�52      ��50      �� *Colors+52      ��54      �� 55      " ��6     �� Triggers 56      �� 57   "    �� Binding 6.   �� *
IsSelected+	 �� Value	 True58   .   .a�59   &   ��  � y�$ 	Collapsed=�5:   -   5;   #   �� 5<   "    6.   �� *
IsSelected+		 False5=   .   .a�5>   &   ��  � y�$ Visible=�5?   -   5@   #   5B      5D      �� 5F      $��3��6   $��	0 15 0 0 q�5G      $^��XЖелаете показать цвета за дополнительную плату?��5I      
 d� 	IsChecked
 5H      �� *
IsSelected+5I      �� 5J      $��3��6   $��0 35 0 0q�5K      .+�5L      �� $>��8Цвета за дополнительную плату:��5M      �� 5N      $
 Name��5P      $��0 5 0 0q�5Q      ��5O      �� *ColorsForAdditionalPrice+5R      ��5T      �� 5U      " ��6     5W      �� 5X   "    6.   �� *
IsSelected+	 True5Y   .   .a�5Z   &   ��  � y�$ Visible=�6C   5[   #   �� 5\   "    6.   �� *
IsSelected+		 False5]   .   .a�5^   &   ��  � y�$ 	Collapsed=�6C   5_   #   5a      5c      5d      5e      5f      5g      