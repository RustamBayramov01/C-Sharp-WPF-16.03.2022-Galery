   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.ListPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  ListPage��5	       � 	Resources 5
         ListBox.Static.Background �� Color  ListBox.Static.Border  ListBox.Disabled.Background  ListBox.Disabled.Border  ListBoxStyle1 �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding	 J� SnapsToDevicePixels
 �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1  FocusVisual ��Name��%O  &	        &	 %     &	 J     &	 o     &	 �     7   7  7  7  &	 s    &	 �    &	 �    &	 �    &		     &	
 ,    &	 Q    &	 v    &	 �    &	 �    7  7  7  7  7  7 	 7 
 7  7  7  �� 5   
   $ Transparent��6<   �� 5   
   $ Transparent��68   �� 5   
   $ Transparent��6>   �� 5   
   $ Transparent��6:   �� 5   
   " ��6&   .�5      ��  � ��8   6+   �� 5       � ��8  6,   �� 5       � ��$ 1q�60   �� 5       � ��# � ��6+   �� 5       � ��$
 Auto=�6K   �� 5       � ��$
 Auto=�6I   �� 5       � �� . 6>   �� 5       �@��PanningMode$
 Both=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ Bd��6!   #��z��6-   #��z��6Y   #��z��6�   $ 1q�6�   	 . ._�5      �� |�.  #��z��6=   .��5   "   �� #	 z	 61   5       5!      
 5"      P� 5#       � {� .  . �5$   "   �� $ Bd��6?   8   � ��6O   �� 5%   "   $ Bd��6@   8   � ��6P   5&      ]� 5'       5(   "   �� 5)   &    �@��
IsGrouping . 6F   �� 5*   &   " �@%�IsVirtualizingWhenGrouping .  6h   ./�5,   "   ��  � �� .  6R   5-      5/      51      52      �� 53   
   $ Transparent��6;   �� 54   
   $ Transparent��67   �� 55   
   $ Transparent��6>   �� 56   
   $ Transparent��6:   �� 57   
   $ Transparent��6<   �� 58   
   $ Transparent��68   �� 59   
   $ Transparent��6=   �� 5:   
   $ Transparent��69   �� 5;   
   $ Transparent��6=   �� 5<   
   " ��6%   .�5=      ��  �@�FocusVisualStyle8   61   �� 5>       � ��8  6+   �� 5?       � ��8  6,   �� 5@       � ��# � ��6+   �� 5A       � ��$ 1q�60   �� 5B       � ��$ Center=�6;   �� 5C       � ��$ Center=�69   �� 5D       � ��$ 1q�6(   �� 5E       � �� 5F      �� 5G      " ��6&   .R�5H      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   	 . ._�5I      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  5J      
 5K      P� 5L       �@��IsDefaulted . . �5M   "   �� $ border��6@   # � ��6T    � ��5N      P� 5O       �@J�IsMouseOver . . �5P   "   �� $ border��6?   8   � ��6S   �� 5Q   "   $ border��6@   8   � ��6T   5R      P� 5S       � �� . . �5T   "   �� $ border��6?   8   � ��6S   �� 5U   "   $ border��6@   8   � ��6T   5V      P� 5W       � {� .  . �5X   "   �� $ border��6?   8   � ��6S   �� 5Y   "   $ border��6@   8   � ��6T   �� 5Z   "   $ contentPresenter��6K   8 	  � ��6i   5[      5]      5_      5`      5a      .��5c      �� 
���   �._�5f   
   �  � RowDefinitions 5i      �� 5k      $	��650 �6    6/   �� 5l      6"   .+�5q      �� -   5        $��listPageAdd��5q   e   $��0��6   $��2��6$   
������ #���  6�   $��Hidden=�6�   $��Hidden=�6�   ��5s      �� 5t      .R�5u      A� $
��Left=�6&   $	��Top=�6A    A� Columns$ 5��6Y   5v      5y      �� 5|      -   5        $��SelectionImage��5|   3   $��0,30,0,0q�6   $��0��6&   6K   �� 5~      -   5        $��StackPanelVisible��5~      $��1��62    �� Orientation$ 
Horizontal=�6?   $��Center=�6X   $��Center=�6s   .+�5�      �� -   5        $��10q�5�   .   $��1��6:   $��32��6G   $��32��6R   
������ #���  6w   .��5�      �� $��Image/previous.png��6   6:   5�      �� 5�      -   5        $��10q�5�   0   $��1��6<   $��64��6I   $��64��6T   
������ #���  6y   .��5�      �� $��Image/pause.png��6   67   5�      �� 5�      -   5        $��10q�5�   1   $��1��6=   $��64��6J   $��64��6U   
������ #���  6z   .��5�      �� $��Image/play-button.png��6   6=   5�      �� 5�      -   5        $��10q�5�   0   $��1��6<   $��32��6I   $��32��6T   
������ #���  6y   .��5�      �� $��Image/next.png��6   66   5�      5�      5�      5�      5�      