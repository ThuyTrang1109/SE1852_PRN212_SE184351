   M S B A M L   `   `   `  ����P  LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	   +    %Presentation.CustomerManagementWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  Quản lý khách hàng��5   	   $	��520��6$   $	��900��61   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   $
��Left=�6M   .+�5      �� -   5         ��Name$ 	txtSearch��5      $	��200��6)   $��0,0,10,0q�65   �� 5      -   5         ��Name$ 	btnSearch��5      $��Tìm kiếm��6(   $��80��6;   $��0,0,10,0q�6F   6X   �� 5      -   5        $ btnMenu��5      $��Thoát��6&   $��80��66   6A   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCustomers��5      $��1��6(      AutoGenerateColumns$ False��65      
IsReadOnly$
 True��6Q      SelectionMode$ Single=�6c   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
CustomerId+6P     5      $
 Tên công ty��6%   $	 150 6Z    6:   �� *CompanyName+6Z     5      $
 Tên liên hệ��6%   $	 120 6Z    6:   �� *ContactName+6Z     5      $
 Chức vụ��6%   $	 100 6W    66   �� *ContactTitle+6W     5      $
 Địa chỉ��6%   $	 150 6R    66   �� *	Address+6R     5      $

 SĐT��6%   $	 100 6L    62   �� *Phone+6L   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��0,10,0,0q�6;   $��Center=�6M   $��Center=�6j   .+�5       �� $ Vertical=�6   $��0,0,10,0q�60   .+�5!      �� $��ID��6   �� 5"      -   5        $ txtCustomerId��5"      $��60��61   5#      �� 5$      $ Vertical=�6   $��0,0,10,0q�60   .+�5%      �� $��Tên công ty��6   �� 5&      -   5        $ txtCompanyName��5&      $	��120��62   5'      �� 5(      $ Vertical=�6   $��0,0,10,0q�60   .+�5)      �� $��Tên liên hệ��6   �� 5*      -   5        $ txtContactName��5*      $	��120��62   5+      �� 5,      $ Vertical=�6   $��0,0,10,0q�60   .+�5-      �� $��Chức vụ��6   �� 5.      -   5        $ txtContactTitle��5.      $	��100��63   5/      �� 50      $ Vertical=�6   $��0,0,10,0q�60   .+�51      �� $��Địa chỉ��6   �� 52      -	   5        $ 
txtAddress��52      $	��150��6.   53      �� 54      $ Vertical=�6   $��0,0,10,0q�60   .+�55      �� $
��SĐT��6   �� 56      -
   5        $ txtPhone��56      $	��100��6,   57      �� 58      $ Vertical=�6   $��0,0,0,0q�60   $��Bottom=�6A   .+�59      �� -   5        $ btnAdd��59      $��Thêm��6)   $��80��68   $��0,0,0,5q�6C   6T   �� 5:      -   5        $ 	btnUpdate��5:      $��Sửa��6,   $��80��6:   $��0,0,0,5q�6E   6V   �� 5;      -   5        $ 	btnDelete��5;      $
��Xóa��6,   $��80��6:   $��0,0,0,5q�6E   6V   �� 5<      -   5        $ btnClear��5<      $��
Làm mới��6+   $��80��6=   6H   5=      5>      5?      5@      