   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	       WpfTask.Windows.BookTake   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  BookTake��5   	   $��427.917��6   $��442.895��6+    � 
ResizeMode$ NoResize=�6;   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   $��50��6(   69   �� 5      6   �� 5      $��50 �6   $��50��6(   69   .+�5   
   �� ���#FF6347$	��Top=�6#   $��50��6;   �� 5   
   
���   �$	��Top=�6!   $��1��69   $��0,50,0,0q�6D   �� 5   
   -   5        $��TitleLb��5      $��Выдача книги��6   $	��Top=�66   $��Stretch=�6N   $��Center=�6l   $��Center=�6�   $��50��6�   $��18(�6�   ���#F5FFFA6�   �� 5   
   $��1��6   $��Дата выдачи��6   $
��Left=�63   $	��Top=�6N   $��5,5,0,0q�6f   $��Right=�6w   $��Center=�6�   $��30��6�   $��18(�6�   $	��129��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��GiveDP��5      $��1��6#   $	��Top=�60   $��150,40,85,0q�6H   $	��200��6]   $��30��6i   $��18(�6u   �� 5   
   $��1��6   $��Дата возврата��6   $
��Left=�65   $	��Top=�6P   $��5,40,0,0q�6h   $��Right=�6z   $��Center=�6�   $��30��6�   $��18(�6�   $	��129��6�     5   
   -   5        $��TakeDP��5      $��1��6#   {�.  $	��Top=�6B   $��
150,5,85,0q�6Z   $	��200��6n   $��30��6z   $��18(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
TakeBookDG��5      $��1��6%   $��Center=�62   $	��200��6M   $��0,65,0,0q�6Z      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6l      AutoGenerateColumns .     
IsReadOnly . ��6|   �� *a+   Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6!   -   5        Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   9   �� 	 �� Path$	 Id�6Y     5      $ Имя��6!   -   5        Name�� 5   <   �� $
	 Name�6^     5      $ 
Автор��6!   -   5        
Author�� 5   @   �� $	 Author�6d   5      �� 5    
   -   5        $��ApplyBtn��5       $��2��6!   $��Принять��6.   $��Bottom=�6@   $��Center=�6[   $��0,0,0,5q�6x   $��30��6�   6�   5!      5"      