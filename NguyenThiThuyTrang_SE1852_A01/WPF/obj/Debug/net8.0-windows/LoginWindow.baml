   M S B A M L   `   `   `  ����P  LNguyenThiThuyTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	       Presentation.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   	� -   5         	�Name$ 
rbEmployee��5      $��Employee Login��6*   $��0��6C   $��1��6P   $��10q�6`   $
��Left=�6�   $��Center=�6�   $��5q�6�   	� 5   
   -   5        $ 
rbCustomer��5      $��Customer Login��6*   $��1��6C   $��1��6P   $��10q�6`   $
��Left=�6�   $��Center=�6�   $��5q�6�   �� 5   
   $��2��6   $��0��6   $��Username / Phone:��6-   $��Center=�6I   $��Right=�6d   $��10q�6�   �� 5"   
   -   5         ��Name$ txtUsername��5"      $��2��6'   $��1��64   $	��200��6D   $��10q�6P   $y�Visible=�6\   $��Stretch=�6q   �� 5%   
   -   5        $ txtPhone��5%      $��2��6$   $��1��61   $	��200��6A   $��10q�6M   $y�	Collapsed=�6Y   $��Stretch=�6p   �� 5(   
   $��3��6   $��0��6   $��	Password:��6-   $��Center=�6A   $��Right=�6\   $��10q�6x   G� 5+   
   -   5         G�Name$ txtPassword��5+      $��3��6+   $��1��68   $	��200��6H   $��10q�6T   $y�	Collapsed=�6`   $��Stretch=�6w   �� 5.   
   -   5         ��Name$ btnLogin��5.      $��4��6#   $��1��60   $��Login��6@   $��72��6P   $
��Left=�6[   $	��Top=�6v   $��
233,20,0,0q�6�    J� RenderTransformOrigin$ 1.159,-0.184&�6�   �� 51   
   -   5        $ 	btnCancel��51      $��4��6$   $��1��61   $��Cancel��6A   $��75��6R   $
��Left=�6]   $	��Top=�6x   $��
362,20,0,0q�6�   52      54      