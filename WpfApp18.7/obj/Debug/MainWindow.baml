   M S B A M L   `   `   `  ����E  AWpfApp18.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfApp18._7WpfApp18._7  5   	       WpfApp18._7.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfApp18._7     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��300��6)   .��5	      �� 
���   �.+�5
   
   A� $��20��6   $��20��6    �� Bottom$ 0��6)    �� Left$	 120��6;   ��5      
� 5       
� RadiusX$ 1Q�6&    
� RadiusY$ 1Q�62    
� GradientOrigin$ 0.3, 0.3&�6>   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $ Black��6#   $ 1Q�61   5       � Triggers 5      :� 5      	 :� RoutedEvent$	 Window.Loaded��6   .[�5      �� .��5      �� .��5      U� 
 �� TargetProperty$
 (Canvas.Bottom)�5   !    g� Duration$ 0:0:3D�5   !    g� AutoReverse .  g� RepeatBehavior$ Forever��5   !    g� DecelerationRatio$ 1Q�6:   .\�5   "   ��  O� KeyTime$ 0%��67    O� Value$ 0Q�6D   �� 5   "   $	 33%��67   $ 60Q�6E   �� 5   "   $	 66%��67   $	 120Q�6E   �� 5   "   $	 99%��67   $	 180Q�6E   5      �� 5      $!
 Fill.GradientStops[1].Color�5    !   $ 0:0:3D�5!   !   $ Forever��62    . g�5$   &   ��  �� KeyTime$ 0:0:1��6:    �� Value$ Green��6J   �� 5%   &   $ 0:0:2��6:   $	 Red��6J   5'      5(      5)      5*      5,      5-      5.      