   M S B A M L   `   `   `  ����  RestYourEyes    RestYourEyes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Rest Your Eyes��5   	   $��347.436��6    $��503.205��61    � 
ResizeMode$ CanMinimize=�6A    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   o� -   5        $��mnuMainMenu��5      $
��Left=�6"   $��21��6=   $��	10,10,0,0q�6I   $	��Top=�6\   $	��462��5   
    o� 
IsMainMenu . .@�5
      m� $��_Timer��6   .@�5      m� -   5        $��E_xit��5      6*   5      m� 5      $��_Help��6   .@�5      m� -   5        $��_About��5      6+   5      5      �� 5   
   -   5        $��lblTopMessage��5      $'��!Set the timer for taking a break:��6%   $
��Left=�6Q   $��	10,53,0,0q�5      $	��Top=�6#   $	��182��6;   �� 5   
   -   5        $��cboTimeChoice��5      $
��Left=�6(   $��
10,107,0,0q�6C   $	��Top=�6W   $	��462��6o    �� Text$ -- select a time --��5   
    �� DisplayMemberPath$
 Name��5   
    �� SelectedValuePath$ Duration��5   
   ��5   
   ��  �� Path$ TimeOptions�5      �� 5!   
   -   5        $��txtbTimerStatus��5!      $
��Left=�6+   $��
10,173,0,0q�6F   $��No timer set��6Z   $	��Top=�5"       �� TextAlignment$ Center=�6,   $��64��6C   $	��462��6O   5$      5%      