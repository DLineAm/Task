   M S B A M L   `   `   `  ����B  >WpfTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfTask.WindowsWpfTask.Windows  5   	   &     WpfTask.Windows.ReaderAccounting   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfTask.Windows     5   	     � Title$  ReaderAccounting��5   	   $��378.324��6"   $��431.702��63    � 
ResizeMode$ NoResize=�6C   .��5	      � .+�5
   
   �� ���#FF6347$	��Top=�6#   $��50��6;   �� 5   
   
���   �$	��Top=�6!   $��1��69   $��0,50,0,0q�6D   �� 5   
   -   5        $��TitleLb��5      $��Читатель №��6   $	��Top=�64   $��Stretch=�6L   $��Center=�6j   $��Center=�6�   $��50��6�   $��18(�6�   ���#F5FFFA6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��10q�6I   .+�5      �� -   5        $��ApplyBtn��5      $��Принять��6%   $��30��67   6C   �� 5      -   5        $��
AddBookBtn��5      $��Выдать книгу��6'   $��10,0,0,0q�6?   6Q   �� 5      -   5        $��DeleBookBtn��5      $��Изъять книгу��6(   $��10,0,0,0q�6@   6R   5      �� 5   
   -   5        $��FirstNameTB��5      $��Center=�6&   $��Center=�6C   $��114,121,42,141q�6^   $��30��6v    �� TextWrapping$
 Wrap=�6�   $	��243��6�   $��18(�6�   �� 5   
   $��Имя��6   $
��Left=�6   $��Center=�6:   $��20,150,0,169q�6U   $��Right=�6k   $��Center=�6�   $��30��6�   $��18(�6�   $	��104��6�   �� 5   
   -   5        $��
LastNameTB��5      $��Center=�6%   $��Center=�6B   $��78,81,6,181q�6]   $��30��6r   $
 Wrap=�6~   $	��243��6�   $��18(�6�   �� 5   
   $��Фамилия��6   $
��Left=�6#   $��Center=�6>   $��20,110,0,209q�6Y   $��Right=�6o   $��Center=�6�   $��30��6�   $��18(�6�   $	��104��6�   �� 5   
   -   5        $��MiddleNameTB��5      $��Center=�6'   $��Center=�6D   $��114,158,42,104q�6_   $��30��6w   $
 Wrap=�6�   $	��243��6�   $��18(�6�   �� 5   
   $��Отчество��6   $
��Left=�6$   $��Center=�6?   $��20,187,0,132q�6Z   $��Right=�6p   $��Center=�6�   $��30��6�   $��18(�6�   $	��104��6�   �� 5   
   $��Взятые книги: ��6   $
��Left=�6)   $��Center=�6D   $��
0,222,0,97q�6_   $
��Left=�6s   $��Center=�6�   $��30��6�   $��18(�6�   $	��124��6�   �� 5   
   -   5         ��Name$ BooksTB��5   2   $ WrapWithOverflow=�6   $��Center=�6C   $��Center=�6^   $��10,252,10,45q�6{   $��52��6�   $	��400��6�    �� 
IsReadOnly . 6�   5      5      