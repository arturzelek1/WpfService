   M S B A M L   `   `   `  ����B  >ShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ShopAppShopApp  5   	       ShopApp.ProductAddDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ShopApp     5   	     � Title$  Add Product��5   	   $	��280��6   $	��400��6*    � 
ResizeMode$ NoResize=�66   .��5	      � $��10q�6    � 	Resources 5
   
    �� 
TargetType �� Property �� Value��%q  '��       '�� �     '��     '�� b    �� 5      " ��6   .�5      ��  � ��$ 0,3,5,5q�6+   �� 5       � ��$ 0,0,0,5q�6,   �� 5       � ��
 �����6/   �� 5       � �� �	#FF3629906/   5      �� 5      " ��6   .�5      ��  � ��$ 0,0,0,5q�6+   5      �� 5      " ��6   .�5      ��  � ��$ 0,0,0,5q�6+   5      �� 5      " ��6   .�5      ��  � ��$ 70��6*   �� 5       � ��$ 25��6+   �� 5       � ��$ 5,0,0,0q�6+   �� 5       � ��
 �����6/   �� 5       � �� �	#FF3629906/   5      5       � ColumnDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#       � RowDefinitions 5&   
   �� 5'      $��1* �6   �� 5(      $��1* �6   �� 5)      $��1* �6   �� 5*      $��1* �6   �� 5+      $��1* �6   �� 5,      $��1* �6   �� 5-      .+�50   
   �� $��0��6   $��0��6    .��6-   Product Name:6<   �� 51   
   -   5        $��productName��51      $��1��6%   $��0��65   �� 53   
   $��0��6   $��1��6    .��6-   Product Description:6C   �� 54   
   -   5        $��productDescription��54      $��1��6,   $��1��6<   $��3��6I    �� AcceptsReturn$
 True��6Z   "	 �� VerticalScrollBarVisibility$
	 Auto=�6o   �� 56   
   $��0��6   $��4��6    .��6.   	Category:69   �� 58   
   -   5        $��productCategory��58      $��1��6*   $��4��6:   
 �� DisplayMemberPath$

 Name��6G    �� SelectedValuePath$ Id��6a   �� 5:   
   $��0��6   $��5��6    .��6-   Price (zł):6:   �� 5;   
   -   5        $��productPrice��5;      $��1��6&   $��5��66   6C   �� 5=   
   $��0��6   $��2��6%   $��6��69    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   .+�5>      �� -   5        $��okButton��5>      .��68   Add6=   �� 5?      -   5        $��cancelButton��5?       �� IsCancel$
 True��6)   .��69   Cancel6A   5@      5A      5B      