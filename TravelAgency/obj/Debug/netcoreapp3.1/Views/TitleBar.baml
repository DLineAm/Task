   M S B A M L   `   `   `  ����G  CTravelAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TravelAgency.ViewsTravelAgency.Views  5      A%clr-namespace:TravelAgency.ViewModelsTravelAgency.ViewModels  5      =#clr-namespace:TravelAgency.ServicesTravelAgency.Services  5      !    TravelAgency.Views.TitleBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TravelAgency.Views     5      4vm%clr-namespace:TravelAgency.ViewModels     5      1s#clr-namespace:TravelAgency.Services     5        � 	Resources  5         TitleBarButton �� 
TargetType'  !System.Windows.Shell.WindowChrome �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6'   .�5      ��   �@ IsHitTestVisibleInChrome$
 True��6F   �� 5       � ��$ 0q�6(   �� 5       � ��$ False��6*   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ titleBorder��6!   
������ 
������ $
 True��5   !   ._�5      �� $ ContentControl��5   -   #��z��5   -   #{�z{�5   -   $��Center=�5   -   $��Center=�5   -   $��22��5   -   $��22��5   -   #��z��5   -   $|�False��5   -   5!      5"       5#      P� 5$      	 �@J�IsMouseOver$

 True��6D   . �5%   "   �� $ titleBorder��6?    � ��
 �����6g   �� 5&   "   $ titleBorder��6@    � ��
 �����6h   5'      5)      5+      5,      5-      .��5.      �   TitleBarHeight#��[ 6     BackgroundColor#���  5/      .+�50      �� $��Center=�51      $��Center=�52        ForegroundColor#���  53      ��50      ��  �� RelativeSource ��  �� AncestorType" � �� Path$ DataContext.Title�53      �� 54       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�56      �� $��0,0,0,0q�6   #��[  57      
�������$
 True��5;      ��59      �� *MinimizeCommand+��5:      ��  �� " ���5<      F� 5=      #���  6   =���� 	=  	= р� 	= р���� 	= ��� $� ��� р�[ ��� 	$	��1.2��6   5?      �� 5@      $��0,0,0,0q�6   #��[  5A      
�������$
 True��5F      ��5C      �� *MaximizeCommand+��5D      ��  �� " �{�5E      �� *
IsMaximize+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5G      F� 5H      #���  6   +���� 	=  	= р� 	= р���� 	= ��	$	��1.2��6o   5J      �� 5K      $��0,0,0,0q�6   #��[  6*   #���  5L       �� EdgeMode$ Aliased=�5O      $
 True��5P      ��5M      �� *CloseCommand+��5N      ��  �� " ���5Q      F� 5R      #���  6   O���� 	=  	= р� 	= р���� 	= �����j ��j ���� ��� ���� ��j ���j ��� 	$	��1.1��6�   5T      5U      5V      5W      