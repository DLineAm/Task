   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	   "    WpfTask.Windows.ReportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  Report��5   	   $	��450��6   $	��800��6%   $	��150��61   $	��400��6A   $	��800��6P   $
��1055��6_    � WindowStartupLocation$ CenterScreen=�6p   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   $��50��6(   69   �� 5      6   .+�5   
   �� $��0��6   ���#FF63476!   �� 5   
   $��0��6   
���   �$��Bottom=�6.   $��1��6I   �� 5   
   $��0��6   $��
Отчет��6   $��Center=�6-   $��Stretch=�6H   $��Center=�6f   $��Center=�6�   $��18(�6�   ���#F5FFFA6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ReportDG��5       $��1��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 61      AutoGenerateColumns .     
IsReadOnly . ��6]   �� *a+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Название книги��6%   -   5        
BookId��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   M   �� 	 �� Path$	 BookName�  5      $' !Количетсво взятий��6%   -   5        	Count�� 5   O   �� $	 Count�5      �� 5   
   -   5        $��BackBtn��5      $��0��6   $��
Назад��6-   $
��Left=�6=   $	��Top=�6X   $��	10,10,0,0q�6p   $	��100��6�   $��30��6�   6�   5      5      