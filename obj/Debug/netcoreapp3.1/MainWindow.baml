   M S B A M L   `   `   `  ����D  @Full_Form, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Full_Form	Full_Form  5   %      Full_Form.MainWindow   6	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6(   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6j   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   )localclr-namespace:Full_Form     6%    � Title$  Registro de Empleados��6\  $	��450��6z  $	��800��6�  .��5      � .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Id��6   ���#000000$��20(�6:   $
��40,0q�6H   $��Normal$�6V   �� 5      $ 
Horizontal=�6   $��102,0q�66   .+�5      �� -   5         ��Name$ 	IdTextBox��5      $��60��61   $��18��6<   $	��0,0q�6H   ��6U   �� *Id+�� 5	      -   5         ��Name$ SearchButton��5	      $
��10,0q�63   $��90��6A   $��28��6L   .��5
      �� $ 
Horizontal=�6%   .+�5      �� $:��4C:\Users\David\source\repos\Full_Form\Icons\lupa.png��6$   �� 5      $��Buscar��6$   5      5      5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Nombre��6   ���#000000$��20(�6>   $
��20,0q�6L   $��Normal$�6Z   �� 5      -   5        $ NameTextBox��5      $	��160��6/   $��25��6;   $
��86,0q�6G   ��6U   �� *Name+5      �� 5      $ 
Horizontal=�6   .+�5      �� $��	Teléfono��6   ���#000000$��20(�6@   $
��20,0q�6N   $��Normal$�6\   �� 5      -   5        $ PhoneTextBox��5      $	��160��60   $��25��6<   $
��84,0q�6H   ��6V   �� *PhoneNumber+5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Cédula��6   ���#000000$��20(�6>   $
��20,0q�6L   $��Normal$�6Z   �� 5      -   5        $ CedulaTextBox��5      $	��160��61   $��25��6=   $
��98,0q�6I   ��6W   �� *Cedula+5      �� 5!      $ 
Horizontal=�6   .+�5"      �� $��
Dirección��6   ���#000000$��20(�6A   $
��20,0q�6O   $��Normal$�6]   �� 5#      -   5        $ AddressTextBox��5#      $	��160��62   $��25��6>   $
��76,0q�6J   ��6X   �� *	Address+5$      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��Fecha Nacimiento��6   ���#000000$��20(�6H   $
��20,0q�6V   $��Normal$�6d   (  "System.Windows.Controls.DatePicker  5(      -   5          Name$ BirthDatePicker��5(      $	��160��66   $��25��6B      SelectedDateFormat$
 Long=�6N      Text 6h   �� *	BirthDate+5)      �� 5+      $ 
Horizontal=�6   $��30,10q�62   .+�5,      �� -   5        $ 	NewButton��5,      $
��10,0q�6,   $��90��6:   $��28��6E   .��5-      �� $ 
Horizontal=�6!   .+�5.      �� $;��5C:\Users\David\source\repos\Full_Form\Icons\nuevo.png��6    �� 5/      $��Nuevo��6    50      51      �� 52      -	   5        $ 
SaveButton��52      $
��10,0q�6-   $��90��6;   $��28��6F   .��53      �� $ 
Horizontal=�6!   .+�54      �� $>��8C:\Users\David\source\repos\Full_Form\Icons\disquete.png��6    �� 55      $��Guardar��6    56      57      �� 58      -
   5        $ DeleteButton��58      $
��10,0q�6/   $��90��6=   $��28��6H   .��59      �� $ 
Horizontal=�6!   .+�5:      �� $<��6C:\Users\David\source\repos\Full_Form\Icons\borrar.png��6    �� 5;      $��Eliminar��6    5<      5=      5>      5?      5@      5A      