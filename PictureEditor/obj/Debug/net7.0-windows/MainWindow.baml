   M S B A M L   `   `   `  ����  PictureEditor    PictureEditor.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��450��5   	   $
��1080��5	   	   $	��800��5
   	   $
��1920��5   	    � WindowStyle$ SingleBorderWindow=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   � $��0��6   
�������$	��150��66   $
��Left=�6B   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5        $+��%Выбрать изображение��5      $	��130��67   $��25��6C   $��5,10,5,5q�6O   $	��Top=�6a    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 5��6=   5      5      5      �� 5      -   5        $-��'Исходное изображение��5      $	��130��5      $��25��5      $��5,0,5,5q�5      $	��Top=�5        5!      ��%^   '��       �� 5"      " ��6    .�5#      ��  �@��CornerRadius$ 5��6=   5$      5%      5&      �� 5'      -   5        $5��/Обработанное изображение��5'      $	��130��5(      $��25��5)      $��5,0,5,5q�5*      $	��Top=�5+       5-      ��%^   '��       �� 5.      " ��6    .�5/      ��  �@��CornerRadius$ 5��6=   50      51      52      53      55      � 56   
   $��1��6   
�������.+�57       � -   5          �Name$ Picture��57      $
��auto��58      $
��auto��59      	  � NavigationUIVisibility$	 Hidden=�5:      5;      5?      5@      