   M S B A M L   `   `   `  ����J  FSpaceVikingsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SpaceVikingsGUI.ViewsSpaceVikingsGUI.Views  5      %    SpaceVikingsGUI.Views.StoreView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SpaceVikingsGUI.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      -   5          >�Name$  StoreWindow��5         ResourceDictionary � 	Resources# [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � 
�������.+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $
��Left=�6   $	��267��64   
����� �5      �� 5      $	��500��6   $��Center=�6%   
����� �.+�5      �� $��80��6   .+�5      �� 
Credits:6*   5      �� 5       .+�5!      �� $��Store��6    $��29��6-   $��25(�69   $��Center=�6G   $��
222,0,10,0q�6d   $	��268��6x   5"      �� 5$      
����� �.+�5%      �� $ 
Horizontal=�6!   $	��110��6:   .+�5&      �� $	��220��6%   $ 
Horizontal=�62   .+�5'      �� $	��110��6)   5)      �� 5*      -   5        $��90��5*   %   $	��100��61   ��5+   "   �� 5,   &   .R�5-   *   �� $��../Pics/glove_test.png��60   6R   5.   '   50      52      �� 54      $	��220��6%   $ 
Horizontal=�61   .+�55      �� $	��110��6)   57      �� 58      $	��100��6)   .+�59   "   �� -   5        $��90��59   )   $	��100��65   ��5:   &   �� 5;   *   .R�5<   .   �� $��../Pics/sword_test.png��64   6V   5=   +   5?   #   �� 5@   "   $��Center=�6,   $��Center=�6I   $��10(�6d   Sword level 4 - 750kr6�   5A      5C      5D      �� 5F      $ 
Horizontal=�6!   $	��110��6:   .+�5G      �� $	��220��6%   $ 
Horizontal=�62   .+�5H      �� $	��110��6)   5J      �� 5K      $	��100��6)   .+�5L   "   �� -   5        $��90��5L   )   $	��100��65   ��5M   &   �� 5N   *   .R�5O   .   �� $��../Pics/helmet_test.png��64   6W   5P   +   5R   #   �� 5S   "   $��Center=�6,   $��Center=�6I   $��10(�6d   Helmet level 4 - 500kr6�   5U      5V      �� 5X      $	��220��6%   $ 
Horizontal=�61   .+�5Y      �� $	��110��6)   5[      �� 5\      $	��100��6)   
���   �.+�5]   "   �� $��Gloves��6,   $��20(�6:   $��Center=�6H   
�������6   �� 5^   "   $��Nice to have��6,   $��12(�6@   $��Center=�6N   
�������6�   �� 5_   "   $��when its cold��6,   $��12(�6A   $��Center=�6O   
�������6�   �� 5`   "   $��REPLACE W PIC��6,   $��12(�6A   $��Center=�6O   
�������6�   5b      5c      5d      �� 5f      $ 
Horizontal=�6!   $	��110��6:   .+�5g      �� $	��220��6%   $ 
Horizontal=�62   .+�5h      �� $	��110��6)   5j      �� 5k      $	��100��6)   
���   �.+�5l   "   �� $��Helmet��6,   $��16(�6:   $��Center=�6H   
�������6�   �� 5m   "   $��Makes you look��6,   $��12(�6B   $��Center=�6P   
�������6�   �� 5n   "   $��really cool!��6,   $��12(�6@   $��Center=�6N   
�������6�   �� 5o   "   $��REPLACE W PIC��6,   $��12(�6A   $��Center=�6O   
�������6�   5q      5r      �� 5t      $	��220��6%   $ 
Horizontal=�61   .+�5u      �� $	��110��6)   5w      �� 5x      $	��100��6)   
���   �.+�5y   "   �� $��Gloves��6,   $��16(�6:   $��Center=�6H   
�������6�   �� 5z   "   $��Nice to have��6,   $��12(�6@   $��Center=�6N   
�������6�   �� 5{   "   $��when its cold��6,   $��12(�6A   $��Center=�6O   
�������6�   5|      5}      5~      5      � 5�      .+�5�      �� $��Close Store��6    $  MaterialDesignRaisedAccentButton#���  5�      $��
0,48,0,-48q�6X   ��5�      �� *CloseStoreWindowCommand+5�   X   5�      5�      �� 5�      $	��267��6   $��Right=�6%   
����� � J� RenderTransformOrigin$ 0.332,0.487&�6W   5�      5�      5�      