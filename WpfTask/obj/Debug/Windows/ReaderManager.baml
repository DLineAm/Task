   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	   #    WpfTask.Windows.ReaderManager   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  ReaderManager��5   	   $	��450��6   $	��800��6,   $	��150��68   $	��400��6H   $	��800��6W   $
��1055��6f    � WindowStartupLocation$ CenterScreen=�6w   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   $��50��6(   69   �� 5      6   �� 5      $��60 �6   $��60��6(   69   .+�5   
   �� $��0��6   ���#FF63476!   �� 5   
   $��0��6   
���   �$��Bottom=�6.   $��2��6I   �� 5   
   $!��Учет читателей��6   $��Stretch=�6)   $��Stretch=�6G   $��Center=�6c   $��Center=�6�   $��20(�6�   ���#F5FFFA6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ReaderDG��5       $��1��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 61      AutoGenerateColumns .     
IsReadOnly . ��6]   �� *a+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   -   5        Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   =   �� 	 �� Path$	 Id�6]     5      $ Имя��6%   -   5        LastName�� 5   D   �� $	 LastName�6j     5      $ Фамилия��6%   -   5        	FirstName�� 5   I   �� $	 	FirstName�6p     5      $ Отчетсво��6%   -   5        
MiddleName�� 5   K   �� $	 
MiddleName�6s   5      �� 5   
   $��0��6   $��1��6$   $��Stretch=�6/   $��Bottom=�6M   �� 5   
   $��2��6   
 �� Orientation$
 
Horizontal=�6#   $��10q�6<   .+�5      �� -   5        $��	CreateBtn��5      $��Добавить��6'   $	��120��6:   $��31��6F   6R   �� 5      -   5        $��	ChangeBtn��5      $��Изменить��6'   $	��120��6:   $��31��6F   $��10,0,0,0q�6j   �� 5      -   5        $��	DeleteBtn��5      $��Удалить��6'   $	��120��69   $��31��6E   $��10,0,0,0q�6i   5       �� 5!   
   -	   5        $��BackBtn��5!      $��0��6   $��
Назад��6-   $
��Left=�6=   $	��Top=�6X   $��10, 10, 0, 0q�6p   $	��120��6�   $��31��6�   6�   5#      5$      