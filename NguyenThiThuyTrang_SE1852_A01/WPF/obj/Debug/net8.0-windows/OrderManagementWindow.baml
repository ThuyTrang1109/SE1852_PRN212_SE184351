   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      P LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation 5   	   (   "Presentation.OrderManagementWindow   5   	   .sys&clr-namespace:System;assembly=mscorlib  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  Quản lý đơn hàng��5	   	   $	��600��6"   $
��1000��6/   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   o� $��0��6   $	��Top=�6   $��25��64   .@�5      m� -   5        $��Thoát��5      6&   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgOrders��5      $��1��6%      AutoGenerateColumns$ False��62      
IsReadOnly$
 True��6N      SelectionMode$ Single=�6`      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã đơn��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 60 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *	OrderId+6Q     5      $ Khách hàng��6%   $		 100 6Z   
 69   �� *CustomerName+6Z     5      $ Nhân viên��6%   $		 100 6Y   
 68   �� *EmployeeName+6Y     5      $ Ngày đặt��6%   $		 120 6n   
 67   �� *	OrderDate+ �� StringFormat$ 
dd/MM/yyyy��6n   5        5!   
   -   5        $ dgOrderDetails��5!      $��2��6+   $ False��68   $
 True��6T   $ Single=�6f    5"        5#      $ Sản phẩm��6%   $		 100 6W   
 67   �� *ProductName+6W     5$      $ 
Đơn giá��6%   $	 80 6T   
 66   �� *	UnitPrice+6T     5%      $ Số lượng��6%   $	 80 6T   
 67   �� *
Quantity+6T     5&      $ Giảm giá��6%   $	 80 6T   
 67   �� *
Discount+6T   5(      �� 5*   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��0,10,0,0q�6;   $��Center=�6M   .+�5+      �� $ Vertical=�6   $��0,0,10,0q�60   .+�5,      �� $��Khách hàng��6   �� 5-      -   5         ��Name$ 
cbCustomer��5-      $	��150��6/    �� DisplayMemberPath$ ContactName��6;    �� SelectedValuePath$ 
CustomerId��6[   5.      �� 5/      $ Vertical=�6   $��0,0,10,0q�60   .+�50      �� $��Nhân viên��6   �� 51      -   5        $ 
cbEmployee��51      $	��150��6/   $
 Name��6;   $ 
EmployeeId��6T   52      �� 53      $ Vertical=�6   $��0,0,10,0q�60   .+�54      �� $��Ngày đặt��6   (  "System.Windows.Controls.DatePicker  55      -   5          Name$ dpOrderDate��55      $	��120��62   56      �� 57      $ Vertical=�6   $��0,0,10,0q�60   .+�58      �� $��Sản phẩm��6   �� 59      -   5        $ 	cbProduct��59      $	��150��6.   $ ProductName��6:   $ 	ProductId��6Z   5:      �� 5;      $ Vertical=�6   $��0,0,10,0q�60   .+�5<      �� $��Số lượng��6   �� 5=      -   5         ��Name$ txtQuantity��5=      $��80��6/   5>      �� 5?      $ Vertical=�6   $��0,0,10,0q�60   .+�5@      �� $��
Đơn giá��6   �� 5A      -	   5        $ txtUnitPrice��5A      $��80��60   5B      �� 5C      $ Vertical=�6   $��0,0,10,0q�60   .+�5D      �� $��Giảm giá��6   �� 5E      -
   5        $ txtDiscount��5E      $��80��6/   5F      �� 5G      -   5         ��Name$ btnAddOrder��5G      $��Tạo đơn��6*   $	��100��6<   $��10,0,0,0q�6H   6Z   5H      5I      5J      