   M S B A M L   `   `   `  ����K  GWetterVerwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WetterVerwaltungWetterVerwaltung  5   	   !    WetterVerwaltung.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089U QScottPlot.WPF, Version=4.0.48.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WetterVerwaltung     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� $��
MainWindow��6   $��
339,10,0,0q�6%   $��30��69   $	��Top=�6E   $
��Left=�6]   $	��122��6x   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Grid1��5   O      
IsReadOnly$
 True��6   $��
104,50,0,0q�6^   $
��Left=�6r   $	��595��6�   $	��301��6�   $	��Top=�6�   5      �� 5   
   -   5         ��Name$ 
BTN_DBSAVE��5      $��
Save to DB��6%   $��601,375,0,0q�6:   $
��Left=�6O   $��98��6j   $��27��6u   $	��Top=�6�   6�   �� 5   
   -   5        $ 	BTN_GRAPH��5      $��
Show Graph��6<   $��	0,375,0,0q�6Q   $��Center=�6d   $��98��6�   $��30��6�   $	��Top=�6�   �� 5   
   -   5        $ BTN_SAVE��5      $��Save to CSV��6:   $��104,375,0,0q�6P   $
��Left=�6e   $��98��6�   $��27��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ 
DebugIndex��5      $�� ��6$   $��467,375,0,0q�6/   $��27��6D   $	��Top=�6P   $
��Left=�6h   $��43��6�   5      5      