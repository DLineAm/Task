   M S B A M L   `   `   `  ����G  CTravelAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TravelAgency.ResourcesTravelAgency.Resources  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   
ComboBoxTb  �� 
TargetType � ColumnDefinitions'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState ��Name J� SnapsToDevicePixels  BackgroundGrayDark �� CornerRadius  WindowBackgroundBrush F�Name �� Triggers	 P� Property
 P� Value �� 
TargetName  	MainColor �� Value �� Property  MainColorDark  BackgroundGrayLight  BorderMainBrush  ForegroundDisabledBrush �� Value �� Binding �� RelativeSource �� Mode �� Mode  ComboBoxTextBx �� 
TargetType 	 BackgroundComboBox d�Name �� 	ClickMode d� 	IsChecked ��Name �� SelectionBoxItem �� SelectionBoxItemTemplate J� IsHitTestVisible ��Name �� 
IsReadOnly �� 
IsReadOnly 
 ForegroundColor �Name � AllowsTransparency  �� IsDropDownOpen! �Name" �� MaxDropDownHeight# � ActualWidth  TabBackgroundColor-  'System.Windows.Input.KeyboardNavigation$   DirectionalNavigation% K� IsItemsHost�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .local$clr-namespace:TravelAgency.Resources  5      %�  &	        7  7  7  7  7  7  7  &	 �    &		 *    7   7  �� 5      "  d�6)   .R�5   
   �  5      �� 5      �� 5	      $��20 �6#    5        5      CommonStates��. 5        
Normal��6"     5      	MouseOver��6"     5      Pressed��6"     5      Disabled��6"   5      .+�5      �� $ Border��6   $
 True��6%   $��2��6@   #���  6T   
�������$��1q�6�   $ 3��6�   �� 5      $ Border2��6   $��0��6&   $
 True��66   $��1q�6Q   8��  
�������$��0,0,1,0q�6�   F� 5      $ Arrow��6   $��1��6"   "����        � 	=  	= � z     	
�������$��Center=�6Z   $��Center=�6w   5       5   
   P� 5      	 �@J�IsMouseOver$

 true��6:   . �5      �� $ Border��6/   # �  6C    � ���� 5      $ Border��60   # �  6D    � ���� 5      $ Border2��60   # �  6E    � ���� 5      $ Arrow��6)    � ��
 �����6<   5      P� 5      	 �@d�	IsChecked$

 trueY�68   . �5      �� $ Border��6/    � ��
 ���� 6C   �� 5       $ Border��60   8   � ��6D   �� 5!      $ Border2��60   8   � ��6E   �� 5"      $ Arrow��6)    � ��
 �����6<   5#      P� 5$      	 � {�$
 False��6+   . �5%      �� $ Border��6/   # �  6C    � ���� 5&      $ Border��60   8   � ��6D   �� 5'      8   � ��6/   5(      �� 5)      $
 True��6�    6   �� *IsKeyboardFocusWithin+ �� $ TemplatedParent=�$ OneWay=�.a�5*      �� $ Border��6/    � ��
 ���� 6C   �� 5+      $ Border��60   8   � ��6D   �� 5,      $ Border2��60   8   � ��6E   �� 5-      $ Arrow��6)    � ��
 �����6<   5.      50      �� 52      "  ��6-   .R�53   
   �� $ PART_ContentHost��6   #��z��6+   $|�False��6U   54      �� 56      " ��6   .�57   
   ��  �@=�ErrorTemplate 65   Z� �� 58   
    � ��$ Center=�6.   �� 59   
    �@�OverridesDefaultStyle$
 true��62   �� 5:   
    �@��
IsEditable$
 True��6'   �� 5;   
    �@J�SnapsToDevicePixels$
 true��60   �� 5<   
    � ��$
 Auto=�6G   �� 5=   
    � ��$
 Auto=�6E   �� 5>   
    � ��$
 true��6:   �� 5?   
    � ��$ 2q�6#   �� 5@   
    � ��$ 20��6&   �� 5A   
    � �� 5B      �� 5C      "  ��6"   .R�5D      �  5E        5F      CommonStates��. 5G   "     
Normal��6.     5H   "   	MouseOver��6.     5I   "   Disabled��6.   5J      .+�5L      d� $ ToggleButton��6'   $��2��6=   $ Press=�6M   $|�false��6_   8��   5M      �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5N      �� 5P      $ ContentSite��5S   M   $��3,3,23,3q�5P   +   #��z 6=   #��z 5Q      #��z��5R      $
��Left=�5S      $ False��64   $��Center=�5T      �� 5V      $ PART_EditableTextBox��63   $��3,3,23,3q�6Q   
������ $
|�True��5W      $
��Left=�6*   # z 6E   8�� $��Center=�5X   D   $y�Hidden=�6_   #��� 
 5Y      ��5V   "   Z� 5Y      � 5[      $ Popup��5^       $
 True��5[       $|�False��5\       #��z  5]       $��Bottom=�5^   /   $
��Fade=�5_       .��5`      � $! DropDown��5b   #   #��z" 5`   #   #��z# 5a   #   $
 True��5c   #   .+�5d   "   �� $ DropDownBorder��6)   #���  5e   )   #��� 
 5f   )   $��1q�5g   )   $ 0��6=   �� 5h   "   $��2q�6/   $
 True��6:   .��5i   &   �� $$ 	Contained=�61   $
% True��6f   #��� 
 6y   5j   #   5k      5l      5m       5n      P� 5o      	 �@��HasItems$
 false��66   . �5p      �� $ DropDownBorder��6:    � ��$ 95��6V   5q      P� 5r      	 �@��
IsGrouping$

 true��68   . �5s      ��  � ��$ false��6N   5t      P� 5u      	 �@��
IsEditable$

 true��68   . �5v      ��  � ��$ false��6:   �� 5w      $ PART_EditableTextBox��6;    � y�$ Visible=�6]   �� 5x      $ ContentSite��6;    � y�$ Hidden=�6T   �� 5y      $ PART_EditableTextBox��6;    � ��
 �����6]   5z      P� 5{      	 �@��
IsEditable$
 False��68   . �5|      �� $ PART_EditableTextBox��6;    � ��
 �����6]   5}      5      5�      5�      5�      