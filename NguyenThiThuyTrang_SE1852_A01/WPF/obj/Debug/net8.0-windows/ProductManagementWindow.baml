   M S B A M L   `   `   `  ����P  LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	   *    $Presentation.ProductManagementWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  Quản lý sản phẩm��5   	   $	��600��6"   $	��950��6/   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   $
��Left=�6M   .+�5      �� -   5         ��Name$ 	txtSearch��5      $	��200��6)   $��0,0,10,0q�65   �� 5      -   5         ��Name$ 	btnSearch��5      $��Tìm kiếm��6(   $��80��6;   $��0,0,10,0q�6F   6X   �� 5      -   5        $ btnMenu��5      $��Thoát��6&   $��80��66   6A   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgProducts��5      $��1��6'      AutoGenerateColumns$ False��64      
IsReadOnly$
 True��6P      SelectionMode$ Single=�6b   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductId+6O     5      $
 Tên sản phẩm��6%   $	 150 6[    6;   �� *ProductName+6[     5      $
 
Đơn giá��6%   $ 80 6T    66   �� *	UnitPrice+6T     5      $
 	Tồn kho��6%   $ 80 6W    66   �� *UnitsInStock+6W     5      $
 
Đơn vị��6%   $	 100 6Y    65   �� *QuantityPerUnit+6Y     5      $
 Đặt hàng��6%   $ 80 6X    67   �� *UnitsOnOrder+6X     5      $
 ReorderLevel��6%   $ 80 6\    6;   �� *ReorderLevel+6\   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 
Ngừng KD��6)   $ 80 6\    6;   �� *Discontinued+6\     5      $
 Supplier��6%   $	 100 6X    67   �� *SupplierName+6X     5       $
 Category��6%   $	 100 6X    67   �� *CategoryName+6X   5"      �� 5#   
   $��2��6   $ 
Horizontal=�6"   $��0,10,0,0q�6;   $��Center=�6M   $��Center=�6j   .+�5$      �� $ Vertical=�6   $��0,0,10,0q�60   .+�5%      �� $��ID��6   �� 5&      -   5        $ txtProductId��5&      $��60��60    �� 
IsReadOnly$
 True��6;   5'      �� 5(      $ Vertical=�6   $��0,0,10,0q�60   .+�5)      �� $��Tên sản phẩm��6   �� 5*      -   5        $ txtProductName��5*      $	��120��62   5+      �� 5,      $ Vertical=�6   $��0,0,10,0q�60   .+�5-      �� $��
Đơn giá��6   �� 5.      -   5        $ txtUnitPrice��5.      $��80��60   5/      �� 50      $ Vertical=�6   $��0,0,10,0q�60   .+�51      �� $��	Tồn kho��6   �� 52      -   5        $ txtUnitsInStock��52      $��80��63   53      �� 54      $ Vertical=�6   $��0,0,10,0q�60   .+�55      �� $��
Đơn vị��6   �� 56      -	   5        $ txtQuantityPerUnit��56      $	��100��66   57      �� 58      $ Vertical=�6   $��0,0,10,0q�60   .+�59      �� $��Đặt hàng��6   �� 5:      -
   5        $ txtUnitsOnOrder��5:      $��80��63   5;      �� 5<      $ Vertical=�6   $��0,0,10,0q�60   .+�5=      �� $��ReorderLevel��6   �� 5>      -   5        $ txtReorderLevel��5>      $��80��63   5?      �� 5@      $ Vertical=�6   $��0,0,10,0q�60   .+�5A      �� $��
Ngừng KD��6   �� 5B      -   5         ��Name$ chkDiscontinued��5B      $��80��64   5C      �� 5D      $ Vertical=�6   $��0,0,10,0q�60   .+�5E      �� $��Category��6   �� 5F      -   5         ��Name$ 
cbCategory��5F      $	��120��6/    �� DisplayMemberPath$ CategoryName��6;    �� SelectedValuePath$ 
CategoryId��6\   5G      �� 5H      $ Vertical=�6   $��0,0,10,0q�60   .+�5I      �� $��Supplier (ID)��6   �� 5J      -   5        $ txtSupplierId��5J      $��80��61   5K      �� 5L      $ Vertical=�6   $��0,0,0,0q�60   $��Bottom=�6A   .+�5M      �� -   5        $ btnAdd��5M      $��Thêm��6)   $��80��68   $��0,0,0,5q�6C   6T   �� 5N      -   5        $ 	btnUpdate��5N      $��Sửa��6,   $��80��6:   $��0,0,0,5q�6E   6V   �� 5O      -   5        $ 	btnDelete��5O      $
��Xóa��6,   $��80��6:   $��0,0,0,5q�6E   6V   �� 5P      -   5        $ btnClear��5P      $��
Làm mới��6+   $��80��6=   6H   5Q      5R      5S      5T      