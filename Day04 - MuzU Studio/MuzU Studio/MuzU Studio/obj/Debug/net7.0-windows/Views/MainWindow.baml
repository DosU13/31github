   M S B A M L   `   `   `  ����F  BMuzU Studio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MuzU_Studio.ViewModelsMuzU_Studio.ViewModels  5   	   5clr-namespace:MuzU_Studio.ViewsMuzU_Studio.Views  5   	   "    MuzU_Studio.Views.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3vm$clr-namespace:MuzU_Studio.ViewModels     5   	   0viewclr-namespace:MuzU_Studio.Views     5   	   Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5	   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5
   	   $	��900��5   	   $
��1600��6      MainWindowStyle#���   5   	    � 	Resources 5        TransparentTextBox �� 
TargetType �� Property �� Value  ListViewFitWidth��%�   &	       &	 p     �� 5   
   " ��6+   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 ���� 6,   5      �� 5   
   " ��6)   .�5      ��  � ��$ Stretch=�6;   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5       $
��Auto �6#   �� 5!      $��* �6#   .+�5#      �� $	��200��6   $��0��6$   $��17(�64   $
��Bold"�6B   $��Center=�5%      ��5$      �� *ProjectName+ �� Mode$ OneWay=� � ToolTip 5&      �� *ProjectPath+$ OneWay=�o� 5'      $��1��6   $��5q�6#   
������ ��5)      �� 5*      .R�5+      �  5,      �� 5-   "   $
��Auto �63   �� 5.   "   $
��Auto �63   �� 5/   "   $��* �63   �� 50   "   $
��Auto �63   �� 51   "   $
��Auto �63   53      54      .@�56      m� $��1��6   $��Project Properties��6,   $��16(�57      {�58      �� *ProjectExists+$ OneWay=�m� 59      $��3��6   $
��Save��6,   {�5:      �� *ProjectExists+$ OneWay=�m� 5;      $��4��6   $�� ☰ ��6,   $��Right=�69   .@�5<      m� $��New Project��6   m� 5=      $��New Project from MIDI��6   �� 5>      m� 5?      $
��Open��6   �� 5@      m� 5A      $
��Save��6   {�5B      �� *ProjectPathExists+$ OneWay=�m� 5C      $��Save as��6   {�5D      �� *ProjectExists+$ OneWay=�5E      5F      5G      5H      � 5I   
   $��1��6    5J      �� 5K      $
��Auto �6#   �� 5L      $��5 �6#   �� 5M      $��* �6#   .+�5O      � $��Stretch=�6    5P      �� 5Q      $
��Auto �6$   �� 5R      $��5 �6$   �� 5S      $��* �6$   .+�5U      �� !  Prism.Regions.RegionManager	   
RegionName$	 SequenceListRegion��6!   $��0��5V   !   �� 5W      $��1��6   $��5��6,   $��Stretch=�67   �� 5X      $	 PropertiesRegion��6!   $��2��6S   5Y      �� 5Z      $��1��6   $��Stretch=�6+   $��5��6G   � 5[      $��2��6    5\      �� 5]      $
��0.9* �6$   �� 5^      $��5 �6$   �� 5_      $
��0.1* �6$   .+�5a      �  5b      �� 5c      $��30 �6(   �� 5d      $��60 �6(   �� 5e      $��* �6(   �� 5f      $��5 �6(   �� 5g      $��50 �6(   $	��150��64   .+�5i      �� $	 PianoRollRegion��6%   $��Stretch=�5j   %   5k      �� 5l      $��1��6   $��5��6,   $��Stretch=�67   �� 5m      $	 VisualizerRegion��6!   $��2��5n   !   5o      5p      5q      5r      