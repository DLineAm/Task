   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	   !    WpfTask.Windows.BookManager   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  BookManager��5	   	   $	��450��6   $	��800��6*   $	��150��66   $	��400��6F   $	��800��6U   $
��1055��6d    � WindowStartupLocation$ CenterScreen=�6u   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   $��50��6(   69   �� 5      6   �� 5      $��60 �6   $��60��6(   69   .+�5   
   �� $��0��6   ���#FF63476!   �� 5   
   $��0��6   
���   �$��Bottom=�6.   $��1��6I   �� 5   
   $��0��6   $��Учет книг��6   $��Center=�61   $��Stretch=�6L   $��Center=�6j   $��Center=�6�   $��18(�6�   ���#F5FFFA6�   �� 5   
   -   5        $��BackBtn��5      $��0��6   $��
Назад��6-   $
��Left=�6=   $	��Top=�6X   $��	10,10,0,0q�6p   $	��100��6�   $��30��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��BookDG��5       $��1��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6/      AutoGenerateColumns .     
IsReadOnly . ��6[   �� *a+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   -   5        Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   =   �� 	 �� Path$	 Id�6]     5      $ Имя��6%   -   5        Name�� 5   @   �� $
	 Name�6b     5      $ 
Автор��6%   -   5        
Author�� 5   D   �� $	 Author�6h   5      �� 5   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5        $��	CreateBtn��5      $��Добавить��6(   $
��Left=�6;   $	��120��6W   $��31��6c   6o   �� 5      -   5        $��	ChangeBtn��5      $��Изменить��6'   $
��Left=�6:   $	��120��6V   $��31��6b   $��10,0,0,0q�6n   6�   �� 5       -   5        $��	RemoveBtn��5       $��Удалить��6'   $
��Left=�69   $	��120��6U   $��31��6a   $��10,0,0,0q�6m   6   5!      5#      5$      