   M S B A M L   `   `   `  ����B  >ShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ShopAppShopApp  5   	       ShopApp.ClientEditDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ShopApp     5   	     � Title$  Edit Client��5   	   $	��220��6   $	��400��6*    � 
ResizeMode$ NoResize=�66    � 	Resources 5	       �� 
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
   �� 5,      $��1* �6   �� 5-      $��1* �6   �� 5.      $��1* �6   �� 5/      $��1* �6   �� 50      .+�53   
   �� $��0��6   $��0��6    .��6-   Client Name:6;   �� 54   
   -   5        $��
clientName��54      $��1��6$   $��0��64   �� 56   
   $��0��6   $��1��6    .��6-   Client Address:6>   �� 57   
   -   5        $��clientAddress��57      $��1��6'   $��1��67   $��2��6D    �� AcceptsReturn$
 True��6U   "	 �� VerticalScrollBarVisibility$
	 Auto=�6j   �� 59   
   $��0��6   $��3��6    .��6-   Discount (%):6<   �� 5:   
   -   5        $��clientDiscount��5:      $��1��6(   $��3��68   6E   �� 5<   
   $��0��6   $��2��6%   $��4��69   
 �� Orientation$
 
Horizontal=�6F   $��Right=�6_   .+�5=      �� -   5        $��okButton��5=      .��68   Edit6>   �� 5>      -   5        $��cancelButton��5>       �� IsCancel$
 True��6)   .��69   Cancel6A   5?      5@      5A      