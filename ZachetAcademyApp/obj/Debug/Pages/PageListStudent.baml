   M S B A M L   `   `   `  ����K  GZachetAcademyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZachetAcademyApp.PagesZachetAcademyApp.Pages  5      ,    &ZachetAcademyApp.Pages.PageListStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ZachetAcademyApp.Pages     5        N� Title$%  Список студентов��5	       N� WindowTitle$% Спислк студентов��5
      .��5      � .+�5   
   �� $��Center=�6   $	��Top=�61   $%��Список студентов��6I   $
��30pt(�6a   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	10 10 0 0q�6a   .+�5      �� $
��15pt(�6   $��Группа:��6(   $��Center=�67   �� 5      -   5        $��Cmb_ChoiseGroup��5   ;      
CmbDefault#��[  6   6;   �� 5      -   5        $��
Btn_Search��5   �     
BtnDefault#��[ 6   $
��80px��69   $
��40px��6F   $��10 0 0 0q�6T   $��Center=�6f   $��
Поиск��6�   6�   5      �� 5   
     	StpCenter#��[ 6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��ListStudent��5         AutoGenerateColumns .  $   HorizontalScrollBarVisibility$
 Auto=�6F   "   VerticalScrollBarVisibility$
 Auto=�6k      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Студент��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6:   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 * 6-      CellTemplate 5      �� 5       .R�5!   "   �� $��Btn_Evaluation��6:   -   5        $��Оценки��5!   )   6P   5"      5$      5'      5)      5+      5-      