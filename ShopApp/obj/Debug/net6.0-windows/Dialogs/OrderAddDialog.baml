   M S B A M L   `   `   `  ����B  >ShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ShopAppShopApp  5   	       ShopApp.OrderAddDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ShopApp     5   	     � Title$  	Add Order��5   	   $	��200��6   $	��400��6(    � 
ResizeMode$ NoResize=�64    � 	Resources 5	       �� 
TargetType �� Property �� Value��%G  '��       '�� �     '�� }    '��     �� 5
   
   " ��6   .�5      ��  � ��$ 0,3,5,5q�6'   �� 5       � ��$ 0,0,0,5q�6(   �� 5       � ��
 �   �6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 0,0,0,5q�6'   �� 5       � ��
 ��  �6+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 0,0,0,5q�6'   �� 5       � ��
 ��  �6+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 70��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 5,0,0,0q�6'   �� 5       � ��
 �����6+   �� 5        � �� �	#FF3629906+   �� 5!       � ��$ 12(�6)   5"      5#      .��5%      � $��10q�6    � ColumnDefinitions 5&   
   �� 5'      $
��Auto �6   �� 5(       � RowDefinitions 5+   
   �� 5,      $��1* �6   �� 5-      $��1* �6   �� 5.      $��1* �6   �� 5/      .+�52   
   �� $��0��6   $��0��6    .��6.   	Client:67   �� 54   
   -   5        $��clients��54      $��1��6"   $��0��62    �� DisplayMemberPath$
 Name��6?   	 �� SelectedValuePath$	 Id��6Y   �� 56   
   $��0��6   $��1��6    $��2��6-   $��Center=�6A   .��6e   Order Details:6u   �� 57   
   $��0��6   $��2��6    $��2��6-   $��Center=�6A   .��6e   97You can add order details later, by editing your order.6�   �� 5<   
   $��0��6   $��2��6%   $��3��69   
 �� Orientation$
 
Horizontal=�6F   $��Right=�6_   .+�5=      �� -   5        $��okButton��5=      .��66   Add6;   �� 5>      -   5        $��cancelButton��5>       �� IsCancel$
 True��6)   .��69   Cancel6A   5?      5@      5A      