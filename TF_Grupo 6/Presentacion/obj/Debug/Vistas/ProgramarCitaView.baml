   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Presentacion.VistasPresentacion.Vistas  5      +    %Presentacion.Vistas.ProgramarCitaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Presentacion.Vistas     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��156* �6   �� 5      $
��153* �6   �� 5      $
��131* �6   .+�5   
   �� $��Especialidad:��6   $
��Left=�6(   $��101,103,0,0q�6C   $	��Top=�6X   $��18(�6p   �� 5   
   $��Médico:��6   $
��Left=�6"   $��107,145,0,0q�6=   $	��Top=�6R   $��18(�6j   $��2��6x   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��
111,37,0,0q�6<   $	��Top=�6P   $��18(�6h   $��1��6v   �� 5   
   -   5         ��Name$ cbEspecialidad��5      $
��Left=�6+   $��248,109,0,0q�6F   $	��Top=�6[   $	��120��6s    J� RenderTransformOrigin$ 0.5,0.5&�6   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.017Q�6&   T� 5      5      ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF0F0F0��6#   � 5      $ 	#FFE1D2D2��6#    � Offset$ 1Q�65   5      5!      �� 5"   
   $��	Hospital:��6   $
��Left=�6$   $��
111,84,0,0q�6?   $	��Top=�6S   $��18(�6k   $��1��6y   �� 5#   
   -   5        $ cbMedico��5#      $
��Left=�6%   $��248,153,0,0q�6@   $	��Top=�6U   $	��120��6m   $��2��6y   6�   �� 5$   
   -   5        $ 
cbHospital��5$      $
��Left=�6'   $��
248,90,0,0q�6B   $	��Top=�6V   $	��120��6n   $��1��6z   (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ DFecha��5%      $
��Left=�6%   $��
248,42,0,0q�6@   $	��Top=�6T   $��1��6l   6y   �� 5&   
   -   5         ��Name$ 
btReversar��5&      $��Reservar��6%   $
��Left=�68   $��
122,23,0,0q�6S   $	��Top=�6g   $��42��6   $	��186��6�   $��18(�6�   $��2��6�   6�   �� 5'   
   $��470,18,20,72q�6   $��/Images/Logo_EsSalud.png��6&   $
��Fill=�6H   �� 5(   
   $��Programa tu cita��6   $
��Left=�6+   $��
186,18,0,0q�6F   $	��Top=�6Z   $	��239��6r   $��25(�6~   $
��Bold"�6�   ���	#FFFBF5F5���	#FF0081C3$��Center=�6�   $��50��6�   $��Center=�6�   5)      5*      