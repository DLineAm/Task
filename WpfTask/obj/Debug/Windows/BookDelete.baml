   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	        WpfTask.Windows.BookDelete   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  
BookDelete��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   $��50��6(   69   �� 5      6   �� 5      $��60 �6   $��60��6(   69   .+�5   
   �� ���#FF6347$	��Top=�6#   $��50��6;   �� 5   
   
���   �$	��Top=�6!   $��1��69   $��0,50,0,0q�6D   �� 5   
   -   5        $��TitleLb��5      $@��:Удаление книги из списка взятых��6   $	��Top=�6I   $��Stretch=�6a   $��Center=�6   $��Center=�6�   $��50��6�   $��18(�6�   ���#F5FFFA6�   �� 5   
   -   5        $��BackBtn��5      $��0��6   $��
Назад��6-   $��Center=�6=   $
��Left=�6X   $��10q�6s   $��30��6   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��BooksDG��5       $��1��6      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   ��6[   �� *a+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ 	Book.Name�  5      $ Дата взятия��6%      Width$
 0.5* 6\    6:   �� $ TakeDate�6\     5      $ Дата возврата��6%   $
 0.5* 6^    6<   �� $ GiveDate�6^   5      �� 5   
   -   5        $��ApplyBtn��5      $��2��6   $��Удалить��6.   $��Center=�6@   $
��Left=�6[   $��10q�6v   $��30��6�   6�   5      5      