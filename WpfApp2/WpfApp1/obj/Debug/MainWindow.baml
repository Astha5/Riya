   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��30* �6   6-   �� 5      $	��70* �6   6-   .+�5   
   �� $
��Name��6   $��0��6    $��0��6-   $
��20px(�6=   $��Right=�6M   $��Center=�6i   
���i��6�   �� 5   
   $��Email��6   $��1��6!   $��0��6.   $
��20px(�6>   $��Right=�6N   $��Center=�6j   
���i��6�   �� 5   
   $��Phone No��6   $��2��6$   $��0��61   $
��20px(�6A   $��Right=�6Q   $��Center=�6m   
���i��6�   �� 5   
   -   5        $��txtCustName��5   �   $�� ��6   $��0��6   $��1��6'   $
��28px(�67   $
��Left=�6G   $��Center=�6b   
���i��$��10q�6�   $��300px��6�   6�   �� 5   
   -   5        $��txtEmail��5   �   $�� ��6   $��1��6   $��1��6'   $
��28px(�67   $
��Left=�6G   $��Center=�6b   
���i��$��350px��6�   $��10q�6�   6�   �� 5    
   -   5        $��txtPhone��5    �   $�� ��6   $��2��6   $��1��6'   $
��28px(�67   $
��Left=�6G   $��Center=�6b   
���i��$��250px��6�   $��10q�6�   6�   �� 5"   
   -   5        $��btnLoad��5"   �   $��3��6   $��0��6   $
��15px(�6/   $��Center=�6?   $��Center=�6\   
���i��$��100px��5#      $��68,50,70,20q�6    $��35��65   .��6A   Load6G   �� 5$   
   -   5        $��btnSave��5$   u   $��3��6   $��1��6   $
��15px(�6/   $
��Left=�6?   $��Center=�6Z   
���i��$��100px��5%      $��116,50,0,20q�6    $��35��65   .��6A   Save6G   5)      5*      