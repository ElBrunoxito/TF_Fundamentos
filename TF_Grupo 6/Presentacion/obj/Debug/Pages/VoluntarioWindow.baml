   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Presentacion.PagesPresentacion.Pages  5   	   )    #Presentacion.Pages.VoluntarioWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Presentacion.Pages     5   	     � Title$  VoluntarioWindow��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $��Nombre:��6   $
��Left=�6"   $��	29,40,0,0q�6=   $	��Top=�6P   �� 5   
   $��Hospital��6   $
��Left=�6#   $��	29,71,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Tipo de Voluntariado:��6   $
��Left=�60   $��
29,102,0,0q�6K   $	��Top=�6_   �� 5   
   $��Horario:��6   $
��Left=�6#   $��
29,133,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��
158,40,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��214��6�   �� 5   
   -   5         ��Name$ cmbHospital��5      $
��Left=�6(   $��
158,68,0,0q�6C   $	��Top=�6W   $	��214��6o   �� 5   
   -   5        $ 
txtHorario��5      $
��Left=�6&   $��158,133,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��214��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagridVoluntariado��5      $
��Left=�62   $	��175��6M   $��
26,182,0,0q�6Z   $	��Top=�6n   $	��615��6�   6�   �� 5   
   -   5         ��Name$ btnRegistrar��5      $��	Registrar��6'   $
��Left=�6;   $��
514,43,0,0q�6V   $	��Top=�6j   $	��127��6�   6�   �� 5   
   -   5        $ btnModificar��5      $��	Modificar��6'   $
��Left=�6;   $��
514,68,0,0q�6V   $	��Top=�6j   $	��127��6�   6�   �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $
��Left=�69   $��
514,93,0,0q�6T   $	��Top=�6h   $	��127��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��514,118,0,0q�6N   $	��Top=�6c   $	��127��6{   6�   �� 5   
   -	   5        $ txtTipo��5      $
��Left=�6#   $��158,104,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��214��6   5      5      