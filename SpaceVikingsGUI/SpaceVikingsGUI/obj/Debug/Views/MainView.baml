   M S B A M L   `   `   `  ����J  FSpaceVikingsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SpaceVikingsGUI.ViewsSpaceVikingsGUI.Views  5      $    SpaceVikingsGUI.Views.MainView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SpaceVikingsGUI.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      -   5          >�Name$  
MainWindow��5         ResourceDictionary � 	Resources# [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��600��5      $
��1024��6   .��5      � .+�5   
   �� 
���   �$	��566��6(   $	��100��65   $��Center=�6A   $
��Left=�6\   $��0,0,0,34q�6w   .+�5      �� $
��Play��6    " MaterialDesignRaisedDarkButton#��[ 5      $��1q�6M   ��5   $   �� *	startGame+5   Z   �� 5      $��Store��6   #��[ 5      $��1q�6M   ��5   %   �� *OpenStoreView+5   Z   �� 5      $
��Char��6   #��[ 5      $��1q�6M   ��5   $   �� *OpenInventoryView+5   Z   5      �� 5    
   
���   �$	��600��6(   $	��924��65   $��Center=�6A   $��Right=�6\   .+�5!      �� $��../background2.png��6   $	��599��60   5"      �� 5#   
   
���   �$��50��6(   $	��100��64   $��Bottom=�6@   $
��Left=�6[   .+�5$      �� $
��Exit��6   $��Bottom=�6%    $  MaterialDesignRaisedAccentButton#��[ 5'      ��5%      �� *CloseApplicationCommand+ �� Mode$ OneWay=���5&      ��  �� ElementName$ 
MainWindow��5'      5(      5)      5+      