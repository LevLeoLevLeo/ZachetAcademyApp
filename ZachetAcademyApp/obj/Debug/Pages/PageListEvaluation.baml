   M S B A M L   `   `   `  ����K  GZachetAcademyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZachetAcademyApp.PagesZachetAcademyApp.Pages  5      /    )ZachetAcademyApp.Pages.PageListEvaluation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ZachetAcademyApp.Pages     5        N� Title$
  Page��5	       N� WindowTitle$ Список оценок��5
      .��5      � .+�5   
   �� $��Center=�6   $	��Top=�61   $��Список оценок��6I   $
��30pt(�6^   �� 5   
   -   5        $��Txt_NameStudent��5      $
��Left=�6A   $	��Top=�6\   $��	0 10 10 0q�6t   ��6+   �� *Name+6t   �� 5   
   -   5        $��	Btn_Print��5      $��Печать��6"      
BtnDefault#��[  63   $��Right=�6W   $	��Top=�6s   $��	0 10 10 0q�6�   6�   �� 5   
     	StpCenter#��[ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��ListEvaluation��5         AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�6E   $   HorizontalScrollBarVisibility$
 Auto=�6h      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Предмет��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Discipline.NameDiscipline+  5      $ Оценка��6%    65   �� *Evaluation1+5      5      5!      5#      