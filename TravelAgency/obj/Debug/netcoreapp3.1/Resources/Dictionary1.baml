   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   BorderStyle �� Property �� Value  BackgroundColor3   -System.Windows.Media.Effects.DropShadowEffect    RenderingBias    	Direction  TitleBarHeight  TbStyle �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value  WindowBackgroundBrush �� Color  	MainColor  MainColorDark  BorderMainBrush  BorderDarkMainBrush 	 BackgroundGrayDark 
 BackgroundGrayLight  ForegroundDisabledBrush  ComboBoxToggleButton � ColumnDefinitions'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState  ForegroundColor �� CornerRadius F�Name �� 
TargetName �� Value �� Binding �� RelativeSource �� Mode �� Mode  ComboBoxTextBox d�Name �� 	ClickMode d� 	IsChecked ��Name �� SelectionBoxItem �� SelectionBoxItemTemplate J� IsHitTestVisible ��Name �� 
IsReadOnly  �� 
IsReadOnly! �Name" � AllowsTransparency# �� IsDropDownOpen$ �Name% �� MaxDropDownHeight& � ActualWidth-  'System.Windows.Input.KeyboardNavigation'   DirectionalNavigation( K� IsItemsHost  	FontStyle) J� Opacity* N� EnterActions+ �� TargetProperty, �� 
TargetName- W� From	. W� To/ g� Duration0 N� ExitActions  BackgroundButton1 ��Name  
LabelStyle�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      7system,clr-namespace:System;assembly=System.Runtime  5      %)   &	        &	 �    &	 �    &	 0    &	 U    &	 z    &	 �    &	 �    &		 �    &	
 �    &	 #    &	 D    7  7  7  7  7  7  7  &	     '�� m    7  7  &	 �    '�� \    &	 A    '�� b    &	 �    �� 5      "  ��6   .�5   
   ��  � ��$ 10q�6#   60   �� 5	   
    � ��# �  6'   6S   �� 5
   
    �@��CornerRadius$ 15��6)   66   �� 5   
    �@J�SnapsToDevicePixels$
 True��60   6?   �� 5   
    �@�UseLayoutRounding$
 True��6.   6=   �� 5   
    �@J�Effect 5         5      $ Quality=�6#   $	 290Q�5   #   65   5      5      X�5      25Q�6/   �� 5      "  d�6   .�5   
   ��  � �� 5      �� 5      " d�6"   .R�5      �� $ Border��6   $��0q�5      #��z��5      $
 True��5      ._�5      �� #��z��6)   5        5!      P� 5"      	 �@d�	IsChecked$

 TrueY�6D   . �5#      ��  � �� 5$   "   �� 5%   &   $-��'/Resources/icons8-sort-amount-up-32.png��6,   $
��None=�5&   ,   6=   5(      5)      P� 5*      	 �@d�	IsChecked$
 FalseY�6D   . �5+      ��  � �� 5,   "   �� 5-   &   $0��*/Resources/icons8-ascending-sorting-32.png��6,   $
��None=�5.   ,   6=   50      51      53      55      56      �� 5:      $ Transparent��64   �� 5<      $ DeepSkyBlue��6(   �� 5=      $ #00A7DF��6,   �� 5?      $ White��6.   �� 5@      $ White��62   �� 5B      $ Transparent��61   �� 5C      $ Transparent��62   �� 5E      $ DimGray��66   �� 5G      " d�63   .R�5H      �  5I      �� 5J      �� 5K      $��20 �6'    5M        5N      CommonStates��. 5O        
Normal��6&     5P      	MouseOver��6&     5Q      Pressed��6&     5R      Disabled��6&   5S      .+�5U      �� $ Border��6   $
 True��6)   $��2��6D   #��� 	 6X   #���  6�   $��1q�6�   $ 3��6�   �� 5V      $ Border2��6   $��0��6*   $
 True��6:   $��1q�6U   8��  #���  6�   $��0,0,1,0q�6�   F� 5W      $ Arrow��6   $��1��6&   "����        � 	=  	= � z     	#���  6Q   $��Center=�6z   $��Center=�6�   5X       5Y      P� 5Z      	 �@J�IsMouseOver$

 true��6>   . �5[      �� $ Border��63   # �  6G    � ���� 5\      $ Border��64   # �  6H    � ���� 5]      $ Border2��64   # �  6I    � ���� 5^      $ Arrow��6-    � ��
 �����6@   5_      P� 5`      	 �@d�	IsChecked$

 trueY�6<   . �5a      �� $ Border��63    � ��
 ���� 6G   �� 5b      $ Border��64   8   � ��6H   �� 5c      $ Border2��64   8   � ��6I   �� 5d      $ Arrow��6-   # �  6@    � ��5e      P� 5f      	 � {�$
 False��6/   . �5g      �� $ Border��63   # � 
 6G    � ���� 5h      $ Border��64   8   � ��6H   �� 5i      8   � ��63   5j      �� 5k      $
 True��6�    6   �� *IsKeyboardFocusWithin+ �� $ TemplatedParent=�$ OneWay=�.a�5l      �� $ Border��63    � ��
 ���� 6G   �� 5m      $ Border��64   8   � ��6H   �� 5n      $ Border2��64   8   � ��6I   �� 5o      $ Arrow��6-    � ��
 �����6@   5p      5r      �� 5t   
   " ��62   .R�5u      �� $ PART_ContentHost��6   #��z��6/   $|�False��6Y   5v      �� 5x      "  ��6   .�5y   
   ��  �@=�ErrorTemplate 65   Z� �� 5z   
    � ��$ Center=�6.   �� 5{   
    �@�OverridesDefaultStyle$
 true��62   �� 5|   
    �@J�SnapsToDevicePixels$
 true��60   �� 5}   
    � ��$
 Auto=�6G   �� 5~   
    � ��$
 Auto=�6E   �� 5   
    � ��$
 true��6:   �� 5�   
    � ��$ 2q�6#   �� 5�   
    � ��$ 20��6&   �� 5�   
    � ��
 �����67   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �  5�        5�      CommonStates��. 5�   "     
Normal��6.     5�   "   	MouseOver��6.     5�   "   Disabled��6.   5�      .+�5�      d� $ ToggleButton��6'   $��2��5�   '   $ Press=�5�   '   $|�false��5�   '   8��   5�      �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5�      �� 5�      $ ContentSite��5�   /   $��3,3,23,3q�5�   /   #��z 6A   #��z 5�   /   #��z��5�   /   $
��Left=�5�   /   $ False��5�   /   $��Center=�5�   /   �� 5�      $ PART_EditableTextBox��5�   "   $��3,3,23,3q�5�   "   
������ $
|�True��5�   "   $
��Left=�5�   "   #  z 5�   "   8�� $��Center=�5�   "   $y�Hidden=�5�   "   
���������5�   "   Z� 5�   "   � 5�      $! Popup��5�       $
" True��5�       $|�False��5�       #��z# 5�       $��Bottom=�5�       $
��Fade=�5�       .��5�      � $$ DropDown��5�   #   #��z% 5�   #   #��z& 5�   #   $
 True��5�   #   .+�5�   "   �� $ DropDownBorder��6)   #���  5�   )   #���  5�   )   $��1q�5�   )   $ 0��5�   )   �� 5�   "   $��2q�6/   $
 True��5�   /   .��5�   &   �� $' 	Contained=�61   $
( True��5�   1   #���  5�   1   5�   #   5�      5�      5�       5�      P� 5�      	 �@��HasItems$
 false��66   . �5�      �� $ DropDownBorder��6:    � ��$ 95��6V   5�      P� 5�      	 �@��
IsGrouping$

 true��68   . �5�      ��  � ��$ false��6N   5�      P� 5�      	 �@��
IsEditable$

 true��68   . �5�      ��  � ��$ false��6:   �� 5�      $ PART_EditableTextBox��6;    � y�$ Visible=�6]   �� 5�      $ ContentSite��6;    � y�$ Hidden=�6T   �� 5�      $ PART_EditableTextBox��6;    � ��
 �����6]   5�      5�      5�      5�      �� 5�      "  ��6   .�5�   
   ��  � ��$ Center=�6.   6?   �� 5�   
    � ��$
 Left=�60   6?   �� 5�   
    � ��# �  6'   6S   �� 5�   
    � ��$ 20(�6%   62   5�      �� 5�      "  ��6   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      �� $��Border��6   
������ #���  5�      $ 2��5�      $
 True��5�      $��1q�5�      #��z��5�      #��z��5�      $) .5Q�5�      ._�5�      �� $��Content��5�   )   #��z��5�   )   #���  5�   )   $��Center=�5�   )   $��Center=�5�   )   5�      5�       5�      P� 5�      	 �@J�IsMouseOver$

 True��6=   * 5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $+ Opacity�6>   $, Border��5�   >   - .55�   >   . 15�   >   $/ 0:0:0.1D�5�   >   6S   5�   +   5�   '   0 5�   "   �� 5�   &   .��5   *   �� .��5  .   W� $+ Opacity�6>   $, Border��5  >   - 15  >   . .55  >   $/ 0:0:0.1D�5  >   6S   5  +   5  '   . �5	  "   �� $ Border��6?    � ��
 ���� 6i   5
     P� 5     	 �@J�IsMouseOver$
 False��6=   . �5  "   �� $ Border��6<    �@J�Opacity$ .5Q�6P   6]   �� 5  "   $ Border��6?    � ��
 ���� 6i   5     P� 5     	 � ��$

 True��67   . �5     �� $ Border��6;   # �  6O    � ��6{   �� 5     $ Content��6;   # �  6P    � ��6|   5     5     5     5     �� 5     "  ��6   .�5  
   ��  � �� 5     �� 5     " ��6"   .R�5     �� $��Border��6   
������ 
�������$ 2��5!     $
 True��5"     $��1q�5#     #��z��5$     #��z��5%     ._�5&     �� #��z��6)   
�������$��Center=�5(  )   $��Center=�5)  )   5+     5,      5-     P� 5.     	 �@J�IsMouseOver$

 True��6@   . �5/     �� $ Border��6;    � ��
 �����6^   �� 50     $ Border��6<    � ��
 �����6_   51     53     55     56     �� 58     "  ��6   .�59  
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5:  
    �@��
CaretBrush
 �����67   �� 5;  
    � �� 5<     �� 5=     " ��6"   .R�5>     �� 
������ 
�������$��1q�5@     $ 3��5A     ._�5B     �� $1 PART_ContentHost��6'   #��z��5C  '   #��z��5D  '   5E     5F     5H     5I     �� 5K     "  ��6   .�5L  
   ��  � ��$ 16(�6%   �� 5M  
    � ��# �  6'   5N     5R     