   M S B A M L   `   `   `  ����  	tetrisWPF    tetrisWPF.optionsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � AllowsTransparency  . 
������  � 
ResizeMode$ NoResize=�5   	   $	��330��6   $	��130��6,    � WindowStyle$
 None=�68   .��5      � -   5        $��mainGrid��5      .+�5   
   �� -   5        $��generalBorder��5      $
��auto��5      $
��auto��5      
���   �$��3q�5
       �� CornerRadius$ 20,20,20,20��5      ��5      �� 5      .��5      � � 5       � Color$ Lavender��6'    � Offset$	 0.0Q�69   � 5      $ 	BurlyWood��6'   $	 0.5Q�6:   � 5      $ Black��6'   $	 1.4Q�66   5      5      ._�5      � -   5        $��generalSpace��5      .+�5      �� -   5        $��closeOptButton��5   �   $��X��6   $��segoe print)�6%   $��12(�6>   $
��Bold"�6L   $
��Left=�6^   $��	10,10,0,0q�6y   $	��Top=�6�   $��20��6�   6�   � 5      -   5        $��
colorSpace��5      $��10,190,10,10q�5      .+�5      �� -   5        $��colorBorder��5      
���   �$��2q�5      ��5      �� 5       �� Color$ #9e9781��6.   5      �� 5       -   5        $��foneColorLabel��5       $��Цвет фигур��62   $��segoe print)�6G   $��12(�6`   $
��Bold"�6n   $
��Left=�6�   $��
-3,-27,0,0q�6�   $	��Top=�6�   �� 5!      -	   5        $��blueFone��5!   �   $��
Синий��6   $��segoe print)�6/   $��12(�6H   $
��Bold"�6V   $
��5,-4q�6h   $��5,10,00,100q�6w   6�   �� 5"      -
   5        $��redFone��5"   �   $��Красный��6   $��segoe print)�61   $��12(�6J   $
��Bold"�6X   $
��5,-4q�6j   $��
5,40,00,70q�6y   6�   �� 5#      -   5        $��	greenFone��5#   �   $��Зеленый��6   $��segoe print)�61   $��12(�6J   $
��Bold"�6X   $
��5,-4q�6j   $��	5,70,0,40q�6y   6�   �� 5$      -   5        $��	blackFone��5$   �   $��Черный��6   $��segoe print)�60   $��12(�6I   $
��Bold"�6W   $
��5,-4q�6i   $��
5,100,0,10q�6x   6�   5%      �� 5&      -   5        $��gameSpeed_label��5&   �   $��Скорость игры��6   $��segoe print)�60   $��12(�6I   $
��Bold"�6W   $
��Left=�6i   $��5,48,0,0q�6�   $	��Top=�6�   6�   �� 5'      -   5        $��speedTrackBar��5'   k   $
��Left=�6   $��	10,76,0,0q�64   $	��Top=�6G   $	��100��6_    � Minimum$ 0Q�6�    � Maximum$	 380Q�6�   	 � Value$	 0Q�6�   6�   �� 5(      -   5        $��	speedInfo��5(   �   $
��Left=�6   $��	10,99,0,0q�67   $
��Wrap=�6J   $��Медленно��6^   $��segoe print)�6n   $��12(�6�   $
��Bold"�6�   $	��Top=�6�   6�   5)      5*      5+      5,      