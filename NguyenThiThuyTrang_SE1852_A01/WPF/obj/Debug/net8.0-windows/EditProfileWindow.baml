   M S B A M L   `   `   `  ����P  LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	   $    Presentation.EditProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$(  "Chỉnh sửa thông tin cá nhân��5   	   $	��400��6-   $	��500��6:    � WindowStartupLocation$ CenterScreen=�6F   .��5	      � $��24q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $(��"Chỉnh sửa thông tin cá nhân��6   $��20(�67   $
��Bold"�6E   ���#273c75$��0,0,0,18q�6l   �� 5   
   $��1��6   $��0,0,0,12q�6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,8q�62   .+�5      �� $��Tên liên hệ:��6   $	��120��60   $��Center=�6<   �� 5      -   5         ��Name$ txtContactName��5      $	��250��62   5      �� 5      $ 
Horizontal=�6   $��0,0,0,8q�62   .+�5      �� $��	Công ty:��6   $	��120��6,   $��Center=�68   �� 5      -   5        $ txtCompanyName��5      $	��250��62   5      �� 5      $ 
Horizontal=�6   $��0,0,0,8q�62   .+�5      �� $��Địa chỉ:��6   $	��120��6,   $��Center=�68   �� 5      -   5        $ 
txtAddress��5      $	��250��6.   5      �� 5      $ 
Horizontal=�6   $��0,0,0,8q�62   .+�5      �� $��Số điện thoại:��6   $	��120��62   $��Center=�6>   �� 5      -   5        $ txtPhone��5      $	��250��6,   5       5!      �� 5"   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5#      �� -   5         ��Name$ btnSave��5#      $
��Lưu��6&   $	��100��64   $��0,0,8,0q�6@   6Q   �� 5$      -   5        $ 	btnCancel��5$      $��Hủy��6(   $��80��66   6A   5%      5&      5'      