   M S B A M L   `   `   `  ����J  FSpaceVikingsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SpaceVikingsGUI.ViewsSpaceVikingsGUI.Views  5      A%clr-namespace:SpaceVikingsGUI.LocatorSpaceVikingsGUI.Locator  5      %    SpaceVikingsGUI.Views.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SpaceVikingsGUI.Views     5      9locater%clr-namespace:SpaceVikingsGUI.Locator     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      -   5          >�Name$  Login��5         ResourceDictionary � 	Resources# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � DataContext 5      ��   ViewModelLocator �� Source# [  �� Path$ LoginViewModel�.��5      � ��5   
   �� 5       �� EndPoint$	 3,1&�6"    �� 
StartPoint$	 2,0&�61   	 � SpreadMethod$	 Reflect=�6B   .��5      � 
 � Color$
 	#FF616161��6    � Offset$ 0Q�61   � 5      $
 DarkCyan��6   $	 1.5Q�60   5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5       $	��150 �6   �� 5!      $��20 �6   �� 5"      $	��150 �6   �� 5#      $��* �6   �� 5$      $	��200 �6    � RowDefinitions 5&   
   �� 5'      $��50 �6   �� 5(      $	��100 �6   �� 5)      $��80 �6   �� 5*      $��50 �6   �� 5+      $��5 �6   �� 5,      $��50 �6   �� 5-      $��10 �6   �� 5.      $��50 �6   �� 5/      $��* �6   �� 50      $��50 �6   .+�53   
   � $��2��6   $��2��6   $��3��6,   .+�54      � .+�55      �� $��Center=�6   $��10q�6:   $��20(�6d   
���  ����6F   �� *ErrorMessage+6r   56      57      � 59   
   $��0��6   $��6��6   .+�5:      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5;      ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6E   $��50��6�   $��50��6�   
���  ����6   �� *CloseApplicationCommand+��6�   Z� ��6�   Z� 6�   5<      5=      � 5?   
   $��1��6   $��1��6   $��5��6,   .+�5@      � .+�5A      �� 
�������$��SPACE VIKINGS��6/   $��Center=�6D   $��Center=�6a   $��60(�6|    # MaterialDesignHeadlineTextBlock#��[ 6�   $��98,10,120,6q�6�   $��84��6�   $	��406��6�   5B      5C      � 5E   
   $��2��6   $��3��6   $��3��6,   .+�5F      � .+�5G      ��   MaterialDesignTextBox#���  6   $��10q�6J   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6V   ��6�   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�    J� InputBindings 5H      �� 5I      
 �� Key$ Return��6%    �� Command 62   �� *LoginCommand+6U   .��5J   -   5K      5L      5M      � 5O   
   $��2��6   $��5��6   $��3��6,   .+�5P      � .+�5Q      G� -   5         G�Name$ PasswordBox��5Q      $��10q�63   $ Password��6?     MaterialDesignPasswordBox#���  6i    5R      �� 5S      $ Return��6%    62   �� *LoginCommand+.  (System.Windows.Interactivity.Interaction   Triggers 5U      /  )System.Windows.Interactivity.EventTrigger  5V         	EventName$ PasswordChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5W      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *PasswordChangedCommand+   CommandParameter 6_   ��  �� ElementName$ PasswordBox��5X      5Z      5[      5\      � 5^   
   $��2��6   $��7��6   $��1��6,   .+�5_      � $��5,0,0,0q�6   .+�5`      �� -   5        $��LoginButton��5`      $��5,0,0,0q�6M    	 MaterialDesignFlatButton#��[	 6^    
 PrimaryHueDarkBrush#��[
 6�   
������� � ForceCursor . ��6,   �� *LoginCommand+.��5a      �� $ 
Horizontal=�6!   .+�5b      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Login=�62   $��Center=�6?   �� 5c      $��10,0,0,0q�6$   $��Center=�66   $��Login��6S   5d      5e      5f      5g      � 5i   
   $��4��6   $��7��6   $��1��6,   .+�5j      � $��0,0,5,0q�6   .+�5k      �� $��0,0,5,0q�6<   #��[	 6M   #��[
 6   
���������6   �� *AddUserCommand+.��5l      �� $ 
Horizontal=�6!   .+�5m        $	 Add=�62   $��Center=�6=   �� 5n      $��10,0,0,0q�6$   $��Center=�66   $��Create User��6S   5o      5p      5q      5r      �� 5s   
   $��3��6=   $
��Exit��6Q   $��2��6`   $
��Left=�6p   $��	10,19,0,0q�6�   $��8��6�   $	��Top=�6�   $	��300��6�    $  MaterialDesignRaisedAccentButton#���  6�   #��[
 6
   . ��6   �� *CloseApplicationCommand+6<  5u      5v      