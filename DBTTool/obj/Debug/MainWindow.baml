   M S B A M L   `   `   `  ����B  >DBTTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DBTToolDBTTool  5   	       DBTTool.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DBTTool     5   	     � Title$$  Datenbank Transfer Rechner Pro��5   	   $	��354��60   $	��382��6=    � 
ResizeMode$ NoResize=�6I    � Icon$ icon.png��6_   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ sizetext��5
      $
��Left=�6$   $��31��6?   $��	49,79,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��121��6�   �� 5   
   -   5         ��Name$ combo��5      $
��Left=�6"   $��31��6=   $��
175,79,0,0q�6I   $	��Top=�6]   $��68��6u   .@�5      �� $
��Byte��6   $
��Left=�6*   $��66��6E   �� 5      $��KB��6   $
��Left=�6(   $��66��6C   �� 5      $��MB��6   $
��Left=�6(   $��66��6C   �� 5      $��GB��6   $
��Left=�6(   $��66��6C   �� 5      $��TB��6   $
��Left=�6(   $��66��6C   5      �� 5   
   -   5        $��	Umrechnen��5      $
��Left=�6%   $��47��6@   $��
49,196,0,0q�6L   $	��Top=�6`   $	��267��6x   6�   �� 5   
   -   5        $ 	speedtext��5      $
��Left=�6%   $��31��6@   $��
49,145,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��194��6�   �� 5   
   -   5         ��Name$ resultlabel��5      $��Geschätze Wartezeit:��6%   $
��Left=�6D   $��29��6_   $��
44,248,0,0q�6k   $	��Top=�6   $	��321��6�   $��14(�6�   �� 5   
   $��Größe der Datenbank��6   $
��Left=�6.   $��27��6I   $��	44,55,0,0q�6U   $	��Top=�6h   $	��309��6�   �� 5   
   $"��Internet Anbindung in Mbit/s��6   $
��Left=�67   $��27��6R   $��
44,124,0,0q�6^   $	��Top=�6r   $	��309��6�   �� 5   
   -   5         ��Name$ speedbtn��5      $��Autom.��6#   $
��Left=�64   $��31��6O   $��248,145,0,0q�6[   $	��Top=�6p   $��68��6�   6�   �� 5   
   -   5        $ sizebtn��5      $��Autom.��6"   $
��Left=�63   $��31��6N   $��
248,79,0,0q�6Z   $	��Top=�6n   $��68��6�   6�   �� 5   
   $
��Left=�6   $��23��6+   $��	49,10,0,0q�67   $	��Top=�6J   $��31��6b   $��left-arrow.png��6m    J� RenderTransformOrigin$ 1.581,0.522&�6�   �� 5   
   -   5        $��Button��5      $
��Left=�6"   $��	49,13,0,0q�6=   $	��Top=�6P   $��31��6h   	 J� Opacity$	 0Q�6s   6   5      5      