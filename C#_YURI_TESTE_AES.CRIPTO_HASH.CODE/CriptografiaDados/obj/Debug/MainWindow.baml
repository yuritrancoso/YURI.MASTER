   M S B A M L   `   `   `  ����L  HCriptografiaDados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CriptografiaDadosCriptografiaDados  5   	   "    CriptografiaDados.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CriptografiaDados     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   $��18(�65   .��5	      � .+�5
   
   �� -   5         ��Name$ 	textBlock��5
      $
��Left=�6'   $��	36,33,0,0q�6B   $
��Wrap=�6U   $��TEXTO SEM CRIPTOGRAFIA:��6i   $	��Top=�6�   �� 5   
   -   5         ��Name$ txtSemCript��5      $
��Left=�6'   $��31��6B   $��	36,54,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��387��6�   �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��	36,90,0,0q�6G   $
��Wrap=�6Z   $��TEXTO COM CRIPTOGRAFIA:��6n   $	��Top=�6�   �� 5   
   -   5        $ txtCript��5      $
��Left=�6$   $��38��6?   $��
36,119,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��387��6�   �� 5   
   -   5        $ txtResposta��5      $
��Left=�6)   $��
36,162,0,0q�6D   $
��Wrap=�6X   $��RESPOSTA��6l   $	��Top=�6|   �� 5   
   -   5         ��Name$ 	buttonMD5��5      $��hash md5��6$   $
��Left=�67   $��
10,216,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 
buttonSHA1��5      $��	hash sha1��6%   $
��Left=�69   $��
10,253,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ buttonCriptSim��5      $��Criptografar (Simétrica)��6)   $
��Left=�6L   $��222,218,0,0q�6g   $	��Top=�6|   $	��207��6�   6�   �� 5   
   -	   5        $ buttonDecriptSim��5      $"��Descriptografar (simétrica)��6+   $
��Left=�6Q   $��222,260,0,0q�6l   $	��Top=�6�   $	��207��6�   6�   �� 5   
   -
   5        $ button��5      $��Button��6!   $
��Left=�62   $��354,185,0,0q�6M   $	��Top=�6b   $��75��6z   6�   5      5      