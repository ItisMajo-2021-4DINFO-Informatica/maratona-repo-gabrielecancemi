   M S B A M L   `   `   `  ����N  JCancemi_ProvaComune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Cancemi_ProvaComuneCancemi_ProvaComune  5   	   $    Cancemi_ProvaComune.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Cancemi_ProvaComune     5   	     � Title$  
MainWindow��5   	   $	��547��6   $	��800��6)   .��5	      �� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ lstLista��5
      $	��100��6%   �� 5   
   -   5         ��Name$ btnLeggi��5      $��Leggi��6#   63   �� 5   
   -   5         ��Name$ 	lblAtleta��5      $��Nome Atleta��6#   �� 5   
   -   5         ��Name$ 	txtAtleta��5      $�� ��6%    �� TextWrapping$
 Wrap=�6-   �� 5   
   -   5        $ lblCitta��5      $��Città��6"   �� 5   
   -   5        $ txtCitta��5      $�� ��6$   $
 Wrap=�6,   �� 5   
   6   �� 5   
   -   5        $ btnTempo��5      $,��&Visualizza tempo impiegato (in minuti)��6#   6T   �� 5   
   -   5        $ lblTempo��5      $�� ��6"   �� 5   
   6   �� 5   
   -	   5        $ 	btnAtleti��5      $��Visualizza atleti��6$   6@   �� 5   
   -
   5        $ 	lblAtleti��5      $�� ��6#   �� 5   
   6   �� 5   
   -   5        $ 	btnStampa��5      $/��)Stampa su file atleti con tempo inferiore��6$   6X   �� 5   
   6   �� 5   
   -   5        $ txtNomeNuovo��5      $
��Nome��6(   $
 Wrap=�64   �� 5   
   -   5        $ txtSocietaNuovo��5      $��Società��6+   $
 Wrap=�6:   �� 5   
   -   5        $ txtOreNuovo��5      $'��!Ore (Inserire le ore a due cifre)��6'   $
 Wrap=�6P   �� 5   
   -   5        $ txtMinutiNuovo��5      $��Minuti��6*   $
 Wrap=�68   �� 5   
   -   5        $ txtCittaNuovo��5      $��Città��6)   $
 Wrap=�66   �� 5   
   -   5        $ btnInserisci��5      $��	Inserisci��6'   6;   5)      5*      