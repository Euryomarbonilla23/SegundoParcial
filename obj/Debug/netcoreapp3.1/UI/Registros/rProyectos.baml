   M S B A M L   `   `   `  ����I  ESegundoParcial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SegundoParcial.UI.RegistrosSegundoParcial.UI.Registros  5   	   ,    &SegundoParcial.UI.Registros.rProyectos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:SegundoParcial.UI.Registros     5   	     � Title$  Registro de Proyectos��5   	   $	��450��6'   $	��550��64   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   .+�5      �� $��
ProyectoId��6   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ ProyectoIdTextBox��5      $��18��6U   $��80��6a   ��69   �� *
ProyectoId+6a   �� 5      -   5         ��Name$ BuscarButton��5      $��Buscar��63   $
��10,0q�6D   6R   5      �� 5      $��Fecha��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 	FechaDate��5      $��81��6O   $
��Left=�6Z      SelectedDate 60   �� *Fecha+6Z   �� 5      $��
Descrpcion��6   �� 5      -   5        $ DescipcionTextbox��5      $��10,10q�6R   $��50��6a   ��65   �� *Descripcion+6a   5      �� 5      $��Detalles de tarea��6   .��5      �� .+�5      �� $ 
Horizontal=�6!   .+�5      �� $ Vertical=�6%   .+�5      �� $��Tipo de tarea��6$   �� 5      -   5         ��Name$ TipoTareaComboBox��5   '   5      5      �� 5      $ Vertical=�6%   $
��30,0q�6<   .+�5       �� $ ��Requerimientos de la tarea��6$   �� 5!      -   5        $ RequerimientosTextBox��5!   &   $	��150��6E   $��20��6Q   ��6]   �� *Detalles.Requerimientos+5"      �� 5#      $ Vertical=�6%   $
��10,0q�6<   .+�5$      �� $��Tiempo(Minutos)��6$   �� 5%      -   5        $ MinutosTextBox��5%   &   $��80��6?   $��20��6J   ��6V   �� *Detalles.Tiempo+5'      �� 5(      -   5        $ AgregarButton��5(   !   $��Agregar��68   $��20��6J   6V   5)      &   System.Windows.Controls.DataGrid  5*      -	   5          Name$ DetalleDataGrid��5*      $��80��6Z      AutoGenerateColumns$ False��6f   ��68   �� *
Detalles+	   Columns	 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn
   Header$
 TipoId��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *TipoId+  5-      $
 	TipoTarea��61    6D   �� *	TipoTarea+  5.      $
 Requerimiento��61    6H   �� *Requerimiento+  5/      $
 Tiempo��61    6A   �� *Tiempo+51      �� 52      -
   5        $ RemoverButton��52      $��RemoverFila��64   $
��Left=�6J   6e   53      54      �� 55      .��56      �� $ 
Horizontal=�6   .+�57      �� -   5        $ NuevoButton��57      $��Nuevo��62   $
��10,0q�6B   $��22��6P   6\   �� 58      -   5        $ GuardarButton��58      $��Guardar��64   $
��10,0q�6F   $��22��6T   6`   �� 59      -   5        $ EliminarButton��59      $��Eliinar ��65   $
��10,0q�6H   $��22��6V   6b   �� 5:      $ Vertical=�6!   $��Right=�68   $��170,0q�6T   .+�5;      �� $��Total de tiempo��6    �� 5<      -   5        $ TiempoTotalTextBox��5<   "   ��6>   �� *TiempoTotal+5=      5>      5?      5@      5A      5B      