   M S B A M L   `   `   `  ����   RestYourEyes    RestYourEyes.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Rest Your Eyes��$��347.436��$��503.205�� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�.��� .+�o� -   $��mnuMainMenu��$
��Left=�$��21��$��	10,10,0,0q�$	��Top=�$	��462�� o� 
IsMainMenu . .@�m� $��_Timer��.@�m� -   $��E_xit��m� $��_Help��.@�m� -   $��_About���� -   $��lblTopMessage��$'��!Set the timer for taking a break:��$
��Left=�$��	10,53,0,0q�$	��Top=�$	��182���� -   $��cboTimeChoice��$
��Left=�$��
10,107,0,0q�$	��Top=�$	��462�� �� Text$ -- select a time --�� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$ Duration������  �� Path$ TimeOptions��� -   $��txtbTimerStatus��$
��Left=�$��
10,173,0,0q�$��No timer set��$	��Top=� �� TextAlignment$ Center=�$��64��$	��462��