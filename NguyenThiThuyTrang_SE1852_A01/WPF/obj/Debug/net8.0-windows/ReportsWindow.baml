   M S B A M L   `   `   `  ����P  LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	        Presentation.ReportsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  Thống kê đơn hàng��5   	   $	��500��6#   $	��900��60   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   $	��Top=�6   $��25��64   .@�5      m� -   5        $��Thoát��5      6&   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   $
��Left=�6M   .+�5      �� $��Từ ngày:��6   $��Center=�6(   $��0,0,5,0q�6C   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpFrom��5      $	��120��6)   $��0,0,10,0q�65   �� 5      $��Đến ngày:��6   $��Center=�6)   $��0,0,5,0q�6D     5      -   5        $
 dpTo��5      $	��120��6'   $��0,0,10,0q�63   �� 5      -   5         ��Name$ 	btnReport��5      $��Thống kê��6(   $	��100��6;   6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgReport��5      $��2��6%      AutoGenerateColumns$ False��62      
IsReadOnly$
 True��6N      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Mã đơn��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 80 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	OrderId+6Q     5      $	 Khách hàng��6%   $	
 100 6Z    69   �� *CustomerName+6Z     5      $	 Nhân viên��6%   $	
 100 6Y    68   �� *EmployeeName+6Y     5      $	 Ngày đặt��6%   $	
 120 6n    67   �� *	OrderDate+ �� StringFormat$ 
dd/MM/yyyy��6n   5       5!      5"      